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
            string sql = "INSERT INTO tbl_itenscompra(itc_quantidade, itc_precocusto) VALUES (?quantidade, ?precocusto)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", itenscompra.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?precocusto", itenscompra.PrecoCusto));
            objCommand.Parameters.Add(Mapped.Parameter("?comprarevendacodigo", itenscompra.CompraRevendaCodigo));
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

        public ItensCompraBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

}