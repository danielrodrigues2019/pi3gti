using FATEC;
using System;
using System.Web;
using PROJETO.Classes;
using System.Data;

namespace PROJETO.Persistencia
{
    /// <summary>
    /// Summary description for ItensCompraBD
    /// </summary>
    public class ItensCompraBD
    {
        //métodos
        //insert
        public bool Insert(ItensCompra itenscompra)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_itenscompra(itc_quantidade, itc_precocusto, pro_codigo) VALUES (?quantidade, ?precocusto, ?produto)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", itenscompra.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?precocusto", itenscompra.PrecoCusto));
            objCommand.Parameters.Add(Mapped.Parameter("?comprarevendacodigo", itenscompra.CompraRevendaCodigo));
            objCommand.Parameters.Add(Mapped.Parameter("?produto", itenscompra.CompraRevendaCodigo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }

        public void Inserir(ItensCompra itenscompra)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_itenscompra(itc_quantidade, itc_precocusto, pro_codigo, com_codigo) VALUES (?quantidade, ?precocusto, ?produto, ?comprarevendacodigo)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", itenscompra.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?precocusto", itenscompra.PrecoCusto));
            objCommand.Parameters.Add(Mapped.Parameter("?comprarevendacodigo", itenscompra.CompraRevendaCodigo));
            objCommand.Parameters.Add(Mapped.Parameter("?produto", itenscompra.Produto));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
        }

        //selectall
        //select
        //update
        //delete
        //construtor

        public ItensCompraBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

}