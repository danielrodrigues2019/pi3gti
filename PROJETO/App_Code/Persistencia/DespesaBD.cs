using FATEC;
using System;
using System.Web;
using PROJETO.Classes;
using System.Data;

namespace PROJETO.Persistencia
{
    /// <summary>
    /// Summary description for DespesaBD
    /// </summary>

    public class DespesaBD
    {
        //métodos
        //insert
        public bool Insert(Despesa despesa)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_despesa(des_descricao, des_valor, des_datavencimento, des_status) VALUES (?descricao, ?valor, ?datavencimento, ?status)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?descricao", despesa.Descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?valor", despesa.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("?datavencimento", despesa.DataVencimento));
            objCommand.Parameters.Add(Mapped.Parameter("?status", despesa.Status));
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
            objCommand = Mapped.Command("SELECT * FROM tbl_despesa", objConexao);
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
        public DespesaBD()
        {
        }

    }
}