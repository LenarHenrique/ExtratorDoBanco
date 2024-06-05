using ExtratorDoBanco.Repository;

namespace ExtratorDoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolhePastaDestino_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                txtCaminhoDestino.Text = folderBrowserDialog1.SelectedPath;
            }
            else
                txtCaminhoDestino.Text = "";
        }

        private async void btnExtrair_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConnectionString.Text))
            {
                MessageBox.Show("Preencha o campo da Connection String!");
                return;
            }
            if(cbTipoScript.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de objeto para extrair do banco!");
                return;
            }
            if (string.IsNullOrEmpty(txtCaminhoDestino.Text))
            {
                MessageBox.Show("Selecione a pasta destino da extração!");
                return;
            }

            //MessageBox.Show($"{cbTipoScript.SelectedIndex}");
            try
            {
                List<string> listObj = new List<string>();
                var systemRepo = new Repository.SystemRepository(txtConnectionString.Text);
                listObj = cbTipoScript.SelectedIndex switch
                {
                    0 => await systemRepo.ListaObjeto("SQL_STORED_PROCEDURE"),
                    1 => await systemRepo.ListaObjeto("SQL_SCALAR_FUNCTION"),
                    2 => await systemRepo.ListaObjeto("VIEW"),
                    3 => await systemRepo.ListaObjeto("SQL_TRIGGER"),
                    _ => Enumerable.Empty<string>().ToList()
                };
                barraProgresso.Minimum = 0;
                barraProgresso.Maximum = listObj.Count;
                barraProgresso.Step = 1;
                barraProgresso.Value = 0;
                barraProgresso.Visible = true;
                foreach (var item in listObj)
                {
                    var arquivo = await systemRepo.HelpText(item);
                    Utils.ArquivoUtil.ExportToTextFile(arquivo, $"{txtCaminhoDestino.Text}\\{item}.sql");

                    barraProgresso.PerformStep();
                }
                DialogResult resultMsg = MessageBox.Show($"Arquivos gerados na pasta:\n {txtCaminhoDestino.Text}", "Extração Completa", MessageBoxButtons.OK);
                barraProgresso.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro");
                barraProgresso.Visible = false;
            }

        }
    }
}
