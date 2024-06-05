using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace ExtratorDoBanco.Repository;

public abstract class AcessoBase
{
    public string connStr { get; set; }
    public AcessoBase(string connStr)
    {
        this.connStr = connStr;
    }

    protected async Task<Y> RetornarItem<Y>(Object entrada, string query, System.Data.CommandType type)
    {
        Y retorno = default(Y);
        await using (var connection = new SqlConnection(connStr))
        {
            await connection.OpenAsync();
            retorno = await connection.QueryFirstOrDefaultAsync<Y>(query, param: entrada, commandType: type);
            await connection.CloseAsync();
        }
        return retorno;
    }
    protected async Task<Y> RetornarItem<Y>(Object entrada, string query, System.Data.CommandType type, int queryTimeout)
    {
        Y retorno = default(Y);
        await using (var connection = new SqlConnection(connStr))
        {
            await connection.OpenAsync();
            retorno = await connection.QueryFirstOrDefaultAsync<Y>(query, param: entrada, commandType: type, commandTimeout: queryTimeout);
            await connection.CloseAsync();
        }
        return retorno;
    }
    protected async Task<List<Y>> RetornarLista<Y>(Object entrada, string query, System.Data.CommandType type)
    {
        List<Y> retorno = default(List<Y>);
        await using (var connection = new SqlConnection(connStr))
        {
            await connection.OpenAsync();
            var lista = await connection.QueryAsync<Y>(query, param: entrada, commandType: type);
            retorno = lista?.ToList();
            await connection.CloseAsync();
        }
        return retorno;
    }
    protected async Task<List<Y>> RetornarLista<Y>(Object entrada, string query, System.Data.CommandType type, int queryTimeout)
    {
        List<Y> retorno = default(List<Y>);
        await using (var connection = new SqlConnection(connStr))
        {
            await connection.OpenAsync();
            var lista = await connection.QueryAsync<Y>(query, param: entrada, commandType: type, commandTimeout: queryTimeout);
            retorno = lista?.ToList();
            await connection.CloseAsync();
        }
        return retorno;
    }
}
