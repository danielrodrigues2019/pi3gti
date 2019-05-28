using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Persistencia;
using PROJETO.Classes;
using System.Data;

public partial class Paginas_AlterarProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ProdutoBD bd = new ProdutoBD();
            Produto produto = bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = produto.Nome;
            txtPrecoVenda.Text = produto.PrecoVenda.ToString();
            txtCadastro.Text = produto.Cadastro.ToShortDateString();
        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        ProdutoBD bd = new ProdutoBD();
        Produto produto = bd.Select(Convert.ToInt32(Session["ID"]));
        produto.Nome = txtNome.Text;
        produto.PrecoVenda = Convert.ToDouble(txtPrecoVenda.Text);
        produto.Data = Convert.ToDateTime(txtData.Text);
        if (bd.Update(produto))
        {
            lblMensagem.Text = "Produto alterado com sucesso";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}