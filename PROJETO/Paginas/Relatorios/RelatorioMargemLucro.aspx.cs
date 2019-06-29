using PROJETO.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Paginas_Relatorios_Default : System.Web.UI.Page
{
    public string[][] data { get; private set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CarregarDrop();

        }
        
    }
    protected void ddlProduto_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    void CarregarDrop()
    {
        DataSet ds = new ProdutoBD().SelectAll2();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            ddlProduto.DataSource = ds.Tables[0].DefaultView;
            ddlProduto.DataTextField = "pro_nome";
            ddlProduto.DataValueField = "pro_codigo";
            ddlProduto.DataBind();
            ddlProduto.Items.Insert(0, "Selecione");
        }
    }
    

    protected void btnSalvar_Click(object sender, EventArgs e)
    {

        if (ddlProduto.SelectedItem.Text != "Selecione")
        {
            int idProduto = Convert.ToInt32(ddlProduto.SelectedItem.Value);
            //DataSet ds = new ProdutoBD().Select4(idProduto);
            ProdutoBD bd = new ProdutoBD();
            DataSet ds = bd.Select4(idProduto);
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();


        }


        //ddlProduto.DataSource = ddlProduto;
        //ddlProduto.DataBind();
        //GridView1.DataSource = ddlProduto;
        //GridView1.DataBind();



    }


}