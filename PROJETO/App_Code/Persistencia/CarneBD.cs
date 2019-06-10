using FATEC;
using System;
using System.Web;
using PROJETO.Classes;
using System.Data;

/// <summary>
/// Summary description for CarneBD
/// </summary>
public class CarneBD
{
    public bool Insert(Carne carne)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "INSERT INTO tbl_parcelavenda(par_codigo, cli_codigo, par_data, par_valor, par_status, par_nparcelas) VALUES (?codigo, ?clicodigo, ?data, ?valor, ?status, ?nparcelas)";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", carne.Codigo));
        objCommand.Parameters.Add(Mapped.Parameter("?clicodigo", carne.Clicodigo));
        objCommand.Parameters.Add(Mapped.Parameter("?data", carne.DataParcela));
        objCommand.Parameters.Add(Mapped.Parameter("?valor", carne.Valor));
        objCommand.Parameters.Add(Mapped.Parameter("?status", carne.Status));
        objCommand.Parameters.Add(Mapped.Parameter("?nparcelas", carne.NumeroParcelas));
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
        objCommand = Mapped.Command("SELECT * FROM tbl_parcelavenda", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
        //objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }
    // selectClientes
    public DataSet SelectAllClientes()
    {
        DataSet ds = new DataSet();
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM tbl_cliente WHERE cli_codigo=?clicodigo", objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        return ds;
    }
    public CarneBD()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}