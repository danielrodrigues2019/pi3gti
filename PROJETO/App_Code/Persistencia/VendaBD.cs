using FATEC;
using System;
using System.Web;
using PROJETO.Classes;
using System.Data;
using System.Collections.Generic;

namespace PROJETO.Persistencia
{
    /// <summary>
    /// Summary 
    /// </summary>
    public class VendaBD
    {
        //métodos
        //insert
        public int Insert(Venda venda)
        {
            int retorno = 0;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_venda(vnd_pagamento, vnd_data, cli_codigo, ven_codigo) VALUES (?pagamento, ?data, ?cliente, ?vendedor); SELECT LAST_INSERT_ID();";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pagamento", venda.Pagamento));
            objCommand.Parameters.Add(Mapped.Parameter("?data", venda.Data));
            objCommand.Parameters.Add(Mapped.Parameter("?cliente", venda.ClienteCodigo));
            objCommand.Parameters.Add(Mapped.Parameter("?vendedor", venda.VendedorCodigo));
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
            objCommand = Mapped.Command("SELECT * FROM tbl_venda", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public Venda Select(int id)
        {
            Venda obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_venda WHERE vnd_codigo=?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Venda();
                obj.Codigo = Convert.ToInt32(objDataReader["enc_codigo"]);
                obj.ClienteCodigo = Convert.ToInt32(objDataReader["cli_codigo"]);
                obj.Pagamento = Convert.ToString(objDataReader["vnd_pagamento"]);
                obj.Data = Convert.ToDateTime(objDataReader["vnd_data"]);

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
        //relatoriovenda
        public string[][] QuantidadeVendas(string dataIni, string dataFim)
        {
            List<string> datas = new List<string>();
            List<string> vendas = new List<string>();
            List<string> quantidades= new List<string>();
            
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT vnd_data AS 'dia', COUNT(DISTINCT(vda.vnd_codigo)) AS 'quantidade', SUM(itv_preco)  as 'total' from tbl_venda vda inner join tbl_itensvenda itv on vda.vnd_codigo = itv.vnd_codigo where vnd_data between ?dataini and ?datafim GROUP BY vnd_data", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dataini", dataIni));
            objCommand.Parameters.Add(Mapped.Parameter("?datafim", dataFim));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                string teste = objDataReader["dia"].ToString() + " - "+ objDataReader["quantidade"].ToString() + " - " + objDataReader["total"].ToString();
                datas.Add(objDataReader["dia"].ToString());
                vendas.Add(objDataReader["quantidade"].ToString());
                quantidades.Add(objDataReader["total"].ToString());
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            string[][] retorno = new string[][] { datas.ToArray(), vendas.ToArray(), quantidades.ToArray() };
            return retorno;
        }
        public VendaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }

    }

}