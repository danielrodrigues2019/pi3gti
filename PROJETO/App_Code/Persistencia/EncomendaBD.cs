using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FATEC;
using PROJETO.Classes;
using System.Data;

namespace PROJETO.Persistencia
{
    /// <summary>
    /// Descrição resumida de EncomendaBD
    /// </summary>
    public class EncomendaBD
    {
        //métodos
        //insert
        public bool Insert(Encomenda encomenda)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_encomenda(enc_produto, enc_datapedido, enc_valor, enc_cliente) VALUES (?produto, ?datapedido, ?valor, ?cliente)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?produto", encomenda.Produto));
            objCommand.Parameters.Add(Mapped.Parameter("?datapedido", encomenda.DataPedido));            
            objCommand.Parameters.Add(Mapped.Parameter("?valor", encomenda.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("?cliente", encomenda.Cliente));           
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
            objCommand = Mapped.Command("SELECT * FROM tbl_Encomenda", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public Encomenda Select(int id)
        {
            Encomenda obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_encomenda WHERE enc_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Encomenda();
                obj.Codigo = Convert.ToInt32(objDataReader["enc_codigo"]);
                obj.Produto = Convert.ToString(objDataReader["enc_produto"]);
                obj.Valor = Convert.ToDouble(objDataReader["enc_valor"]);
                obj.Cliente = Convert.ToString(objDataReader["enc_cliente"]);
                obj.DataPedido = Convert.ToDateTime(objDataReader["enc_datapedido"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //update
        public bool Update(Encomenda encomenda)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_encomenda SET enc_produto=?produto, enc_datapedido=?datapedido, enc_valor=?valor, enc_cliente=?cliente WHERE enc_codigo=?codigo";
 objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?produto", encomenda.Produto));
            objCommand.Parameters.Add(Mapped.Parameter("?datapedido", encomenda.DataPedido));
            objCommand.Parameters.Add(Mapped.Parameter("?valor", encomenda.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("?cliente", encomenda.Cliente));
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", encomenda.Codigo));
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
            string sql = "DELETE FROM tbl_encomenda WHERE enc_codigo=?codigo";
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

        public EncomendaBD()
        {
            //
            // TODO: Adicionar lógica do construtor aqui
            //
        }
    }
}