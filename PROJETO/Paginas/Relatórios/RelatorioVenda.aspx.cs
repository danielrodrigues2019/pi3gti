using PROJETO.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Paginas_Relatórios_RelatorioVenda : System.Web.UI.Page
{
    public string[][] data { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //string dataInicio = Request.Params.Get("dataInicio");
        //string dataFim = Request.Params.Get("dataFim");
        //if (dataInicio != null && dataFim != null)
        //{
        GetData();
        //}

    }
    public void GetData()
    {
        data = new VendaBD().QuantidadeVendas("2019-01-01", "2019-12-01");
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



    protected void GerarRelatorio(object sender, EventArgs e)
    {
        string dataInicio = txtDataIni.Text;
        string dataFim = txtDataFim.Text;

        Response.Redirect("RelatorioVenda.aspx?dataInicio=" + dataInicio + "&dataFim=" + dataFim);
    }
}