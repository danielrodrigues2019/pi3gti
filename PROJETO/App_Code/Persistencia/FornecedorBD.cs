using FATEC;
using System;
using System.Web;
using PROJETO.Classes;
using System.Data;

namespace PROJETO.Persistencia
{
    /// <summary>
    /// Summary description for FuncionarioBD
    /// </summary>
    public class FornecedorBD
    {
        //métodos
        //insert
        public bool Insert(Fornecedor fornecedor)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_fornecedor(forn_nome, forn_telefone, forn_cnpj, forn_endereco) VALUES (?nome, ?telefone, ?cnpj, ?endereco)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", fornecedor.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", fornecedor.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?cnpj", fornecedor.CNPJ));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", fornecedor.Endereco));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //selectall
        public static DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_fornecedor", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public  DataSet SelectAll1()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_fornecedor", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }



        //select
        public  Fornecedor Select(int id)
        {

            Fornecedor obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_fornecedor WHERE forn_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Fornecedor();
                obj.Codigo = Convert.ToInt32(objDataReader["forn_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["forn_nome"]);
                obj.Telefone = Convert.ToString(objDataReader["forn_telefone"]);
                obj.CNPJ = Convert.ToString(objDataReader["forn_cnpj"]);
                obj.Endereco = Convert.ToString(objDataReader["forn_endereco"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;


        }
        //update
        public bool Update(Fornecedor fornecedor)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_fornecedor SET forn_nome=?nome, forn_telefone=?telefone, forn_cnpj=?cnpj, forn_endereco=?endereco WHERE forn_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", fornecedor.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?nome", fornecedor.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", fornecedor.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?cnpj", fornecedor.CNPJ));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", fornecedor.Endereco));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;

        }

        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_fornecedor WHERE forn_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //construtor
        public FornecedorBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}