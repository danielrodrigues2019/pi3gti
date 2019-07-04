using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using PROJETO.Persistencia;


public partial class Paginas_Relatorios_RelatorioLucroDoMes : System.Web.UI.Page
{
    public string[][] data { get; private set; }

    void CarregarDrop()
    {
        DataSet ds = new VendaBD().Lucrodomes();
        
    }      
}