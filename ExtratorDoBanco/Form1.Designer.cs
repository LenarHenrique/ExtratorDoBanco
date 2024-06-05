namespace ExtratorDoBanco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblConnectionString = new Label();
            txtConnectionString = new TextBox();
            lblCaminhoDestino = new Label();
            txtCaminhoDestino = new TextBox();
            iblTituloProbrama = new Label();
            lblTipoScript = new Label();
            cbTipoScript = new ComboBox();
            btnEscolhePastaDestino = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnExtrair = new Button();
            barraProgresso = new ProgressBar();
            SuspendLayout();
            // 
            // lblConnectionString
            // 
            lblConnectionString.AutoSize = true;
            lblConnectionString.Location = new Point(15, 69);
            lblConnectionString.Name = "lblConnectionString";
            lblConnectionString.Size = new Size(127, 20);
            lblConnectionString.TabIndex = 0;
            lblConnectionString.Text = "Connection String";
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(15, 92);
            txtConnectionString.Multiline = true;
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(576, 129);
            txtConnectionString.TabIndex = 1;
            // 
            // lblCaminhoDestino
            // 
            lblCaminhoDestino.AutoSize = true;
            lblCaminhoDestino.Location = new Point(15, 297);
            lblCaminhoDestino.Name = "lblCaminhoDestino";
            lblCaminhoDestino.Size = new Size(220, 20);
            lblCaminhoDestino.TabIndex = 2;
            lblCaminhoDestino.Text = "Caminho de Destino dos Scripts";
            // 
            // txtCaminhoDestino
            // 
            txtCaminhoDestino.Location = new Point(15, 354);
            txtCaminhoDestino.Name = "txtCaminhoDestino";
            txtCaminhoDestino.ReadOnly = true;
            txtCaminhoDestino.Size = new Size(576, 27);
            txtCaminhoDestino.TabIndex = 3;
            // 
            // iblTituloProbrama
            // 
            iblTituloProbrama.AutoSize = true;
            iblTituloProbrama.Font = new Font("Segoe UI", 15F);
            iblTituloProbrama.Location = new Point(21, 9);
            iblTituloProbrama.Name = "iblTituloProbrama";
            iblTituloProbrama.Size = new Size(558, 35);
            iblTituloProbrama.TabIndex = 4;
            iblTituloProbrama.Text = "Programa Extrator de Scripts de Banco de Dados";
            // 
            // lblTipoScript
            // 
            lblTipoScript.AutoSize = true;
            lblTipoScript.Location = new Point(15, 236);
            lblTipoScript.Name = "lblTipoScript";
            lblTipoScript.Size = new Size(257, 20);
            lblTipoScript.TabIndex = 5;
            lblTipoScript.Text = "Tipo de Objeto para Extrair do banco";
            // 
            // cbTipoScript
            // 
            cbTipoScript.FormattingEnabled = true;
            cbTipoScript.Items.AddRange(new object[] { "Store Procedure", "Function", "VIEW", "TRIGGER" });
            cbTipoScript.Location = new Point(15, 266);
            cbTipoScript.Name = "cbTipoScript";
            cbTipoScript.Size = new Size(573, 28);
            cbTipoScript.TabIndex = 6;
            // 
            // btnEscolhePastaDestino
            // 
            btnEscolhePastaDestino.BackgroundImageLayout = ImageLayout.Center;
            btnEscolhePastaDestino.Location = new Point(162, 320);
            btnEscolhePastaDestino.Name = "btnEscolhePastaDestino";
            btnEscolhePastaDestino.Size = new Size(276, 29);
            btnEscolhePastaDestino.TabIndex = 7;
            btnEscolhePastaDestino.Text = "Selecione Pasta Destino dos Scripts";
            btnEscolhePastaDestino.UseVisualStyleBackColor = true;
            btnEscolhePastaDestino.Click += btnEscolhePastaDestino_Click;
            // 
            // btnExtrair
            // 
            btnExtrair.Location = new Point(201, 400);
            btnExtrair.Name = "btnExtrair";
            btnExtrair.Size = new Size(198, 29);
            btnExtrair.TabIndex = 8;
            btnExtrair.Text = "Extrair Objetos do Banco";
            btnExtrair.UseVisualStyleBackColor = true;
            btnExtrair.Click += btnExtrair_Click;
            // 
            // barraProgresso
            // 
            barraProgresso.Location = new Point(15, 440);
            barraProgresso.Name = "barraProgresso";
            barraProgresso.Size = new Size(573, 29);
            barraProgresso.TabIndex = 9;
            barraProgresso.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 515);
            Controls.Add(barraProgresso);
            Controls.Add(btnExtrair);
            Controls.Add(btnEscolhePastaDestino);
            Controls.Add(cbTipoScript);
            Controls.Add(lblTipoScript);
            Controls.Add(iblTituloProbrama);
            Controls.Add(txtCaminhoDestino);
            Controls.Add(lblCaminhoDestino);
            Controls.Add(txtConnectionString);
            Controls.Add(lblConnectionString);
            Name = "Form1";
            Text = "Programa Extrator de Scripts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConnectionString;
        private TextBox txtConnectionString;
        private Label lblCaminhoDestino;
        private Label iblTituloProbrama;
        private TextBox txtCaminhoDestino;
        private Label lblTipoScript;
        private ComboBox cbTipoScript;
        private Button btnEscolhePastaDestino;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnExtrair;
        private ProgressBar barraProgresso;
    }
}
