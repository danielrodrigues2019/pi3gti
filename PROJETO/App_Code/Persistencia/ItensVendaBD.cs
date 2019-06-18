using FATEC;
using System;
using System.Web;
using PROJETO.Classes;
using System.Data;

namespace PROJETO.Persistencia
{
    /// <summary>
    /// Summary description for ItensVendaBD
    /// </summary>
    public class ItensVendaBD
    {
        //métodos
        //insert
        public bool Insert(ItensVenda itensvenda)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_itensvenda(itv_quantidade, itv_preco, pro_codigo) VALUES (?quantidade, ?preco, ?produto)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", itensvenda.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?preco", itensvenda.Preco));
            objCommand.Parameters.Add(Mapped.Parameter("?vendacodigo", itensvenda.VendaCodigo));
            objCommand.Parameters.Add(Mapped.Parameter("?produto", itensvenda.VendaCodigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        public void Inserir(ItensVenda itensvenda)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_itensvenda(itv_quantidade, itv_preco, pro_codigo, vnd_codigo) VALUES (?quantidade, ?preco, ?produto, ?vendacodigo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade",itensvenda.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?preco",itensvenda.Preco));
            objCommand.Parameters.Add(Mapped.Parameter("?vendacodigo",itensvenda.VendaCodigo));
            objCommand.Parameters.Add(Mapped.Parameter("?produto",itensvenda.Produto));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }

        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_itensvenda", objConexao);
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

        public ItensVendaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

}