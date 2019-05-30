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
        string sql = "INSERT INTO tbl_carne(cc_codigo, cc_tipo, cli_codigo) VALUES (?codigo, ?tipo, ?clicodigo)";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", carne.Codigo));
        objCommand.Parameters.Add(Mapped.Parameter("?tipo", carne.Tipo));
        objCommand.Parameters.Add(Mapped.Parameter("?clicodigo", carne.Clicodigo));
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
        objCommand = Mapped.Command("SELECT * FROM tbl_contacorrente", objConexao);
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