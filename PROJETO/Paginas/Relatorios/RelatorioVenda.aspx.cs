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
        //string dataInicio = Request.Params.Get("dataInicio");
        //string dataFim = Request.Params.Get("dataFim");
        //if (dataInicio != null && dataFim != null)
        //{
        //}
    }
  

    //protected void Carrega()
    //{
    //    VendaBD bd = new VendaBD();
    //    DataSet ds = bd.SelectAll();
    //    QuantidadeVendas.DataSource = ds.Tables[0].DefaultView;
    //    QuantidadeVendas.DataBind();

    //    //grafico
    //    int TotalDeRegistros = ds.Tables[0].Rows.Count;

    //    int[] Fatias = new int[TotalDeRegistros];
    //    string[] Produtos = new string[TotalDeRegistros];

    //    for (int i = 0; i < TotalDeRegistros; i++)
    //    {
    //        Fatias[i] = Convert.ToInt32(ds.Tables[0].Rows[i]["Produtos Mais Vendidos"].ToString());
    //        //Produtos[i] = ds.Tables[0].Rows[i]["Produto"].ToString;
    //    }

    //    Grafico1.Series["Series"].Points.DataBindXY(Produtos, Fatias);

    //}

    protected void GetData(object sender, EventArgs e)
    {
        data = new VendaBD().QuantidadeVendas("2019-01-01", "2019-12-01");
        string json = JsonConvert.SerializeObject(data);
        hdnResultado.Text = json;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "data", "showData()", true);
    }
}