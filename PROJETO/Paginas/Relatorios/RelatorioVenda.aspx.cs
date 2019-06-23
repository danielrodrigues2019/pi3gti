using PROJETO.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json;




public partial class Paginas_Relatórios_RelatorioVenda : System.Web.UI.Page
{
    public string[][] data { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void GetData(object sender, EventArgs e)
    {
        if (ddlTipo.Text == "Parcelado")
        {
            data = new VendaBD().QuantidadeVendas(txtDataIni.Text, txtDataFim.Text);
        }
        else
        {
            data = new ClienteBD().QuantidadeClientes(txtDataIni.Text, txtDataFim.Text);
        }
        string json = JsonConvert.SerializeObject(data);
        hdnResultado.Text = json;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "data", "showData()", true);
    }
}