using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using FATEC;
using System.Data;
using PROJETO.Persistencia;

public partial class Paginas_SaidaCaixa_SaidaCaixa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        SaidaCaixa saidacaixa = new SaidaCaixa();
        saidacaixa.Vendedor = txtVendedor.Text;
        saidacaixa.Data = Convert.ToDateTime(txtData.Text);
        saidacaixa.Preco = Convert.ToDouble(txtPreco.Text);
        saidacaixa.Descricao = txtDescricao.Text;
        SaidaCaixaBD bd = new SaidaCaixaBD();
        if (bd.Insert(saidacaixa))
        {
            lblMensagem.Text = "Saída de caixa cadastrada com sucesso";
            txtVendedor.Text = "";
            txtData.Text = "";
            txtPreco.Text = "";
            txtDescricao.Text = "";
            txtVendedor.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}