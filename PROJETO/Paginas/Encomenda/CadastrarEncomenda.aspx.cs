using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;
using FATEC;

public partial class Paginas_Encomenda_CadastrarEncomenda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Encomenda encomenda = new Encomenda();
        encomenda.Produto = txtProduto.Text;
        encomenda.Valor = Convert.ToDouble(txtValor.Text);
        encomenda.DataPedido = Convert.ToDateTime(txtDataPedido.Text);
        encomenda.Cliente = txtCliente.Text;
        EncomendaBD bd = new EncomendaBD();
        if (bd.Insert(encomenda))
        {
            lblMensagem.Text = "Encomenda cadastrada com sucesso";
            txtProduto.Text = "";
            txtDataPedido.Text = "";
            txtValor.Text = "";
            txtProduto.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}