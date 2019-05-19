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
        public bool Insert(CompraRevenda comprarevenda)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_comprarevenda(com_pagamento, com_data) VALUES (?pagamento, ?data)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);          
            objCommand.Parameters.Add(Mapped.Parameter("?pagamento", comprarevenda.Pagamento));
            objCommand.Parameters.Add(Mapped.Parameter("?data", comprarevenda.Data));
            


            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
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
        //update
        //delete
        //construtor
        public ComprarevendaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}