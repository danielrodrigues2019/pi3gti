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
            List<string[]> data = new List<string[]>();
            // data.Add(new string[]{ "Dia", "Quant", "Total" });


            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT vnd_data AS 'dia', SUM(itv_preco)  as 'total' from tbl_venda vda inner join tbl_itensvenda itv on vda.vnd_codigo = itv.vnd_codigo where vnd_data between ?dataini and ?datafim GROUP BY vnd_data", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dataini", dataIni));
            objCommand.Parameters.Add(Mapped.Parameter("?datafim", dataFim));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                data.Add(new string[] { objDataReader["dia"].ToString(), objDataReader["total"].ToString() });
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return data.ToArray();
        }
        //relatoriovenda
        public string[][] VendasRealizadas(string dataIni, string dataFim)
        {
            List<string[]> data = new List<string[]>();
            
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT SUM(itv.itv_preco) AS 'vendasrealizadas', (vnd.vnd_data) AS 'dia' FROM tbl_itensvenda itv INNER JOIN tbl_venda vnd ON itv.vnd_codigo = vnd.vnd_codigo WHERE vnd.vnd_data BETWEEN ?dataini and ?datafim group by vnd_data", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dataini", dataIni));
            objCommand.Parameters.Add(Mapped.Parameter("?datafim", dataFim));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                data.Add(new string[] { objDataReader["dia"].ToString(), objDataReader["vendasrealizadas"].ToString() });
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return data.ToArray();
        }
        public DataSet Lucrodomes()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("select sum(itv.itv_preco) as  Vendas, sum(des.des_valor) as Despesas, sum(com.parc_valor) as ContasPagar, sum(ven.par_valor) as ContasReceber,(sum(itv.itv_preco) + sum(ven.par_valor)) - (sum(des.des_valor) + sum(com.parc_valor)) as Lucro, (sum(itv.itv_preco) + sum(ven.par_valor)) - (sum(des.des_valor) + sum(com.parc_valor)) / (sum(itv.itv_preco) + sum(ven.par_valor)) * 100 as Porcentagem from tbl_itensvenda itv inner join tbl_despesa des inner join tbl_parcelacompra com inner join tbl_parcelavenda ven on com.parc_valor between '2019-06-01' and '2019-06-30' and ven.par_valor between '2019-06-01' and '2019-06-30'", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }

        public VendaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }

    }

}