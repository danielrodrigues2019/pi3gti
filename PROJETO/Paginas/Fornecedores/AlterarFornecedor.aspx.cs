using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;

public partial class Paginas_Fornecedores_AlterarFornecedor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FornecedorBD bd = new FornecedorBD();
            Fornecedor fornecedor = bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = fornecedor.Nome;
            txtTelefone.Text = fornecedor.Telefone;
            txtCNPJ.Text = fornecedor.CNPJ;
            txtEndereco.Text = fornecedor.Endereco;
        }

    }

    protected void salvar_Click(object sender, EventArgs e)
    {
        FornecedorBD bd = new FornecedorBD();
        Fornecedor fornecedor = bd.Select(Convert.ToInt32(Session["ID"]));
        fornecedor.Nome = txtNome.Text;
        fornecedor.Telefone = txtTelefone.Text;
        fornecedor.CNPJ = txtCNPJ.Text;
        fornecedor.Endereco = txtEndereco.Text;
        
        if (bd.Update(fornecedor))
        {
            lblMensagem.Text = "Fornecedor alterado com sucesso";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }
}