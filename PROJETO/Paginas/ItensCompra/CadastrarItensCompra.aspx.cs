using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;
using System.Data;

public partial class Paginas_ItensCompra_CadastrarItensCompra : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            ProdutoBD bd = new ProdutoBD();
            DataSet ds = bd.SelectAll();
            ddlProduto.DataSource = ds.Tables[0].DefaultView;
            ddlProduto.DataTextField = "pro_codigo";
            ddlProduto.DataValueField = "pro_codigo";
            ddlProduto.DataBind();
            ddlProduto.Items.Insert(0, "Selecione");


        }

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        ItensCompra itenscompra = new ItensCompra();
        itenscompra.Quantidade = Convert.ToInt32(txtQuantidade.Text);
        itenscompra.PrecoCusto = Convert.ToInt32(txtPrecocusto.Text);
        ItensCompraBD bd = new ItensCompraBD();
        if (bd.Insert(itenscompra))
        {
            lblMensagem.Text = "Itens Compra cadastrado com sucesso";
            txtQuantidade.Text = "";
            txtPrecocusto.Text = "";
            txtQuantidade.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}