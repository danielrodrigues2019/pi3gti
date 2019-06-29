using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using PROJETO.Persistencia;


public partial class Paginas_Relatorios_RelatorioQuantidadeVenda : System.Web.UI.Page
{
    
    public string[][] data { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GetData(object sender, EventArgs e)
    {
        if (ddlTipo.Text == "vendasrealizadas")
        {
            data = new VendaBD().VendasRealizadas(txtDataIni.Text, txtDataFim.Text);
        }
        
        string json = JsonConvert.SerializeObject(data);
        hdnResultado.Text = json;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "data", "showData()", true);
    }

}