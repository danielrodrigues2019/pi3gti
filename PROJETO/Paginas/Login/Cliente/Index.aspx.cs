using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;

public partial class Paginas_Login_Cliente_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int codigo = Convert.ToInt32(Session["ID"]);
        VendedorBD bd = new VendedorBD();
        Vendedor vendedor = bd.Select(codigo);
        if (!IsCliente(vendedor.Tipo))
        {
            Response.Redirect("../Erro/AcessoNegado.aspx");
        }
        else
        {
            lblTitulo.Text = "Bem vindo (Cliente) : " + vendedor.Nome;
        }
    }
    private bool IsCliente(int tipo)
    {
        bool retorno = false;
        if (tipo == 1)
        {
            retorno = true;
        }
        return retorno;
    }

    protected void lbSair_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Session.RemoveAll();
        Response.Redirect("../Login.aspx");
    }
}