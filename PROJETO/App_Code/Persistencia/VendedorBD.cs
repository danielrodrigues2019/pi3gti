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
    public class VendedorBD
    {
        //métodos
        //insert
        public bool Insert(Vendedor vendedor)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_vendedor(ven_nome, ven_usuario, ven_senha, ven_cpf, ven_email) VALUES (?nome, ?usuario, ?senha, ?cpf, ?email)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", vendedor.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?usuario", vendedor.Usuario));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", vendedor.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", vendedor.CPF));
            objCommand.Parameters.Add(Mapped.Parameter("?email", vendedor.Email));
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
            objCommand = Mapped.Command("SELECT * FROM tbl_vendedor", objConexao);
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
        public VendedorBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}