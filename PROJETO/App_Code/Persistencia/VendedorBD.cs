using FATEC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROJETO.Classes;
using System.Data;

namespace PROJETO.Persistencia
{
    /// <summary>
    /// Summary description for VendedorBD
    /// </summary>
    public class VendedorBD
    { 
        public bool Insert(Vendedor vendedor)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "INSERT INTO tbl_vendedor(ven_nome, ven_usuario, ven_senha, ven_cpf, ven_email, ven_tipo) VALUES (?nome, ?usuario, ?senha, ?cpf, ?email, ?tipo)";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?nome",vendedor.Nome));
        objCommand.Parameters.Add(Mapped.Parameter("?usuario",vendedor.Usuario));
        objCommand.Parameters.Add(Mapped.Parameter("?senha",vendedor.Senha));
        objCommand.Parameters.Add(Mapped.Parameter("?cpf", vendedor.CPF));
            objCommand.Parameters.Add(Mapped.Parameter("?email", vendedor.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", vendedor.Tipo));
            objCommand.ExecuteNonQuery();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return true;
    }
    
        public Vendedor Autentica(string email, string senha)
        {
            Vendedor obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_vendedor WHERE ven_email=?email and ven_senha=?senha", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?email", email));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", senha));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Vendedor();
                obj.Codigo = Convert.ToInt32(objDataReader["ven_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["ven_nome"]);
                obj.Email = Convert.ToString(objDataReader["ven_email"]);
                obj.Tipo = Convert.ToInt32(objDataReader["ven_tipo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        public Vendedor Select(int codigo)
        {
            Vendedor obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_vendedor WHERE ven_codigo=?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", codigo));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Vendedor();
                obj.Codigo = Convert.ToInt32(objDataReader["ven_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["ven_nome"]);
                obj.Email = Convert.ToString(objDataReader["ven_email"]);
                obj.Tipo = Convert.ToInt32(objDataReader["ven_tipo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
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
        public DataSet SelectAllAdministradores()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_vendedor WHERE ven_tipo = 0", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        public DataSet SelectAllClientes()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_vendedor WHERE ven_tipo = 1", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        public VendedorBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}