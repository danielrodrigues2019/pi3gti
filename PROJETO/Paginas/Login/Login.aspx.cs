using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;

public partial class Paginas_Login_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private bool IsPreenchido(string str)
    {
        bool retorno = false;
        if (str != string.Empty)
        {
            retorno = true;
        }
        return retorno;
    }
    private bool UsuarioEncontrado(Vendedor vendedor)
    {
        bool retorno = false;
        if (vendedor != null)
        {
            retorno = true;
        }
        return retorno;
    }

    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string senha = txtSenha.Text.Trim();
        if (!IsPreenchido(email))
        {
            lblMensagem.Text = "Preencha o email";
            txtEmail.Focus();
            return;
        }
        if (!IsPreenchido(senha))
        {
            lblMensagem.Text = "Preencha a senha";
            txtSenha.Focus();
            return;
        }
        VendedorBD bd = new VendedorBD();
        Vendedor vendedor = new Vendedor();
        vendedor = bd.Autentica(email, senha);
        if (!UsuarioEncontrado(vendedor))
        {
            lblMensagem.Text = "Usuário não encontrado";
            txtEmail.Focus();
            return;
        }
        Session["ID"] = vendedor.Codigo;
        switch (vendedor.Tipo)
        {
            case 0:
                Response.Redirect("Administrador/Index.aspx");
                break;
            case 1:
                Response.Redirect("Cliente/Index.aspx");
                break;
            default:
                break;
        }
    }
}