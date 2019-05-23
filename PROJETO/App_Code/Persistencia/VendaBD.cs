using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PROJETO.Classes;
using FATEC;

namespace PROJETO.Persistencia
{

    public class VendaBD
    {
        //métodos
        //Search
        public DataSet Search(string termo)
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_venda WHERE vnd_codigo LIKE ? nome ORDER BY vnd_codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", '%' + termo + '%'));
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //insert
        public bool Insert(Venda venda)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_venda(vnd_pagamento, vnd_data, vnd_valor) VALUES (?pagamento, ?data, ?valor)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pagamento", venda.Pagamento));
            objCommand.Parameters.Add(Mapped.Parameter("?data", venda.Data));
            objCommand.Parameters.Add(Mapped.Parameter("?valor", venda.Valor));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //selectall
        //select
        //update
        //delete
        //construtor
        public VendaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}