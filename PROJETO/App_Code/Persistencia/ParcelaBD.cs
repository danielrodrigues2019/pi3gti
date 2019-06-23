using FATEC;
using System;
using System.Web;
using PROJETO.Classes;
using System.Data;

/// <summary>
/// Summary description for ParcelaBD
/// </summary>
public class ParcelaBD
{
    public bool Insert(Parcela parcela)
    {
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        string sql = "INSERT INTO tbl_parcelavenda(par_codigo, cli_codigo, ven_codigo, par_datavencimento, par_valor, par_status, par_datapagamento VALUES (?codigo, ?clicodigo, ?vencodigo, ?datavencimento, ?valor, ?status, ?datapagamento)";
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?codigo", parcela.Codigo));
        objCommand.Parameters.Add(Mapped.Parameter("?clicodigo", parcela.Clicodigo));
        objCommand.Parameters.Add(Mapped.Parameter("?vencodigo", parcela.Vencodigo));
        objCommand.Parameters.Add(Mapped.Parameter("?datavencimento", parcela.DataPagamento));
        objCommand.Parameters.Add(Mapped.Parameter("?valor", parcela.Valor));
        objCommand.Parameters.Add(Mapped.Parameter("?status", parcela.Status));
        objCommand.Parameters.Add(Mapped.Parameter("?datapagamento", parcela.DataVencimento));
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
    }    // select    public Parcela Select(Parcela parcela)
    {
        Parcela obj = null;
        System.Data.IDbConnection objConexao;
        System.Data.IDbCommand objCommand;
        System.Data.IDataReader objDataReader;
        objConexao = Mapped.Connection();
        objCommand = Mapped.Command("SELECT * FROM tbl_parcelavenda WHERE parc_codigo = ?codigo", objConexao);
        objDataReader = objCommand.ExecuteReader();
        while (objDataReader.Read())
        {
            obj = new Parcela();
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", parcela.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?clicodigo", parcela.Clicodigo));
            objCommand.Parameters.Add(Mapped.Parameter("?vencodigo", parcela.Vencodigo));
            objCommand.Parameters.Add(Mapped.Parameter("?datavencimento", parcela.DataPagamento));
            objCommand.Parameters.Add(Mapped.Parameter("?valor", parcela.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("?status", parcela.Status));
            objCommand.Parameters.Add(Mapped.Parameter("?datapagamento", parcela.DataVencimento));
        }
        objDataReader.Close();
        objConexao.Close();
        objCommand.Dispose();
        objConexao.Dispose();
        objDataReader.Dispose();
        return obj;
    }
    public ParcelaBD()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}