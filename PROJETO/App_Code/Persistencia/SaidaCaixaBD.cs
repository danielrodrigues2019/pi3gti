using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using PROJETO.Classes; //para acesso a classe Funcionario
using System.Data; //para uso de DataSet
namespace PROJETO.Persistencia
{
    /// <summary>
    /// </summary>
    public class SaidaCaixaBD
    {
        //métodos
        //insert
        public bool Insert(SaidaCaixa saidacaixa)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_saidacaixa(cai_vendedor, cai_data, cai_preco, cai_descricao) VALUES (?vendedor, ?data, ?preco, ?descricao)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?vendedor", saidacaixa.Vendedor));
            objCommand.Parameters.Add(Mapped.Parameter("?data", saidacaixa.Data));
            objCommand.Parameters.Add(Mapped.Parameter("?preco", saidacaixa.Preco));
            objCommand.Parameters.Add(Mapped.Parameter("?descricao", saidacaixa.Descricao));
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
        objCommand = Mapped.Command("SELECT * FROM tbl_saidacaixa", objConexao);
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
    public SaidaCaixaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}