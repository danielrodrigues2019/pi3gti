using FATEC;
using System;
using System.Web;
using PROJETO.Classes;
using System.Data;

namespace PROJETO.Persistencia
{
    /// <summary>
    /// Summary 
    /// </summary>
    public class ComprarevendaBD
    {
        //métodos
        //insert
        public int Insert(CompraRevenda comprarevenda)
        {
            int retorno = 0;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_comprarevenda(com_pagamento, com_data, forn_codigo) VALUES (?pagamento, ?data, ?fornecedor); SELECT LAST_INSERT_ID();";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pagamento", comprarevenda.Pagamento));
            objCommand.Parameters.Add(Mapped.Parameter("?data", comprarevenda.Data));
            objCommand.Parameters.Add(Mapped.Parameter("?fornecedor", comprarevenda.FornecedorCodigo));
            retorno = Convert.ToInt32(objCommand.ExecuteScalar());
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return retorno;
        }
        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_comprarevenda", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public CompraRevenda Select(int id)
        {
            CompraRevenda obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_comprarevenda WHERE com_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new CompraRevenda();
                obj.Codigo = Convert.ToInt32(objDataReader["enc_codigo"]);
                obj.FornecedorCodigo = Convert.ToInt32(objDataReader["forn_codigo"]);
                obj.Pagamento = Convert.ToString(objDataReader["com_pagamento"]);
                obj.Data = Convert.ToDateTime(objDataReader["com_data"]);

            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //update
        //delete
        //construtor
        //getlastid
        public DataSet SelectLastID()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT LAST_INSERT_ID()", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;

        }
        public ComprarevendaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }

    }

}