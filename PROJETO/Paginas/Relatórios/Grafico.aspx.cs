using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Graficos_Grafico : System.Web.UI.Page
{
    int[] barras = new int[3];
    string[] nomes = new string[3];

    protected void Page_Load(object sender, EventArgs e)
    {
        ObterDados();
    }

    protected void ObterDados()
    {
        DataSet cn = new Conection();

        SqlConnection conn = new 
    }
}