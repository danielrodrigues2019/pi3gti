using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;


public partial class Paginas_Vendedor_CadastrarVendedor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void salvar_Click(object sender, EventArgs e)
    {
        Vendedor vendedor = new Vendedor();
        vendedor.Nome = txtNome.Text;
        vendedor.Usuario = txtUsuario.Text;
        vendedor.Senha = txtSenha.Text;
        vendedor.CPF = txtcpf.Text;
        vendedor.Email = txtEmail.Text;
        VendedorBD bd = new VendedorBD();
        if (bd.Insert(vendedor))
        {
            lblMensagem.Text = "Vendedor cadastrado com sucesso";
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtcpf.Text = "";
            txtEmail.Text = "";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}