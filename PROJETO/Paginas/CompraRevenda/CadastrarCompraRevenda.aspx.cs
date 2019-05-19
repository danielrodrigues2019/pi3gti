using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;

public partial class Paginas_CompraRevenda_CadastrarCompraRevenda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        CompraRevenda compraRevenda = new CompraRevenda();
        compraRevenda.Pagamento = txtPagamento.Text;
        compraRevenda.Data = txtData.Text;
        ComprarevendaBD bd = new ComprarevendaBD();
        if (bd.Insert(compraRevenda))
        {
            lblMensagem.Text = "CompraRevenda cadastrada com sucesso";
            txtPagamento.Text = "";
            txtData.Text = "";
            txtPagamento.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }
}