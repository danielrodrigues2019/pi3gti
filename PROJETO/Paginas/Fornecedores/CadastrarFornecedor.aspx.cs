using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;

public partial class Paginas_Fornecedores_CadastrarFornecedor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void salvar_Click(object sender, EventArgs e)
    {
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Nome = txtNome.Text;
            fornecedor.Telefone = Convert.ToString(txtTelefone.Text);
            fornecedor.CNPJ = txtCNPJ.Text;
            fornecedor.Endereco = txtEndereco.Text;
            FornecedorBD bd = new FornecedorBD();
            if (bd.Insert(fornecedor))
            {
                lblMensagem.Text = "Fornecedor cadastrado com sucesso";
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtCNPJ.Text = "";
                txtEndereco.Text = "";
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }

        }
    }
}