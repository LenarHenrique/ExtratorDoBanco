using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtratorDoBanco.Repository;

public class SystemRepository : AcessoBase
{
    public SystemRepository(string conn)
        : base(conn)
    {

    }
    public async Task<List<string>> ListaObjeto(string typeObj)
    {
        try
        {
            string busca = "SELECT  name FROM sys.objects where type_desc = @type";
            var procedures = await RetornarLista<string>(new { type = typeObj }, busca, System.Data.CommandType.Text);
            return procedures;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
    public async Task<List<string>> ListaProcs()
    {
        try
        {
            string busca = "SELECT  name FROM sys.objects where type_desc = @type";
            var procedures = await RetornarLista<string>(new { type = "SQL_STORED_PROCEDURE" }, busca, System.Data.CommandType.Text);
            return procedures;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
    public async Task<List<string>> ListaFunctions()
    {
        try
        {
            string busca = "SELECT  name FROM sys.objects where type_desc = @type";
            var procedures = await RetornarLista<string>(new { type = "SQL_SCALAR_FUNCTION" }, busca, System.Data.CommandType.Text);
            return procedures;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<List<string>> HelpText(string procedure)
    {
        try
        {
            var scriptCreate = await RetornarLista<string>(new { objname = procedure }, "SP_HELPTEXT", System.Data.CommandType.StoredProcedure);
            return scriptCreate;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}
