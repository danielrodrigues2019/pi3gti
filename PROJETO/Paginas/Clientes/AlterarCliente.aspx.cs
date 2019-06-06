using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;

public partial class Paginas_Alterar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ClienteBD bd = new ClienteBD();
            Cliente cliente = bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone.ToString();
            txtCpf.Text = cliente.CPF.ToString();
            txtEndereco.Text = cliente.Endereco;
            txtTelefone.Text = cliente.Telefone;
        }

    }

    protected void salvar_Click(object sender, EventArgs e)
    {
        ClienteBD bd = new ClienteBD();
        Cliente cliente = bd.Select(Convert.ToInt32(Session["ID"]));
        cliente.Nome = txtNome.Text;
        cliente.Telefone = txtTelefone.Text;
        cliente.Endereco = txtEndereco.Text;
        cliente.CPF = txtCpf.Text;
        txtTelefone.Text = cliente.Telefone;
        if (bd.Update(cliente))
        {
            lblMensagem.Text = "Cliente alterado com sucesso";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }
}