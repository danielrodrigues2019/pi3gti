using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;

public partial class Paginas_CadastrarProduto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnSalvar_Click(object sender, EventArgs e)
    {

        Produto produto = new Produto();
        produto.Nome = txtNome.Text;
        produto.Data = Convert.ToDateTime(txtData.Text);
        produto.PrecoVenda = Convert.ToDouble(txtPrecoVenda.Text);
        ProdutoBD bd = new ProdutoBD();
        if (bd.Insert(produto))
        {
            lblMensagem.Text = "Produto cadastrado com sucesso";
            txtNome.Text = "";
            txtData.Text = "";
            txtPrecoVenda.Text = "";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }
}