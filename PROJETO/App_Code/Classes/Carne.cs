using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Carne
/// </summary>
public class Carne
{
    public int Codigo { get; set; }
    public int Clicodigo { get; set; }
    public DateTime DataParcela { get; set; }
    public decimal Valor{ get; set; }
    public int Status { get; set; }
    public int NumeroParcelas { get; set; }


    public Carne()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}