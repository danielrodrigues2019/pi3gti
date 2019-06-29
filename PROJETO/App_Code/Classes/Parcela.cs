using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Carne
/// </summary>
public class Parcela
{
    public int Codigo { get; set; }
    public int Clicodigo { get; set; }
    public int Vencodigo { get; set; }
    public DateTime DataPagamento { get; set; }
    public Double Valor{ get; set; }
    public int Status { get; set; }
    public DateTime DataVencimento { get; set; }
    public int CodigoVenda { get; set; }



    public Parcela()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}