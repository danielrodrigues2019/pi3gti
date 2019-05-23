using System;
using System.Collections.Generic;
using System.Data;
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
        if (!Page.IsPostBack)
        {
            FornecedorBD bd = new FornecedorBD();
            DataSet ds = bd.SelectAll();
            ddlFornecedores.DataSource = ds.Tables[0].DefaultView;
            ddlFornecedores.DataTextField = "forn_nome";
            ddlFornecedores.DataValueField = "forn_codigo";
            ddlFornecedores.DataBind();
            ddlFornecedores.Items.Insert(0, "Selecione");


        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        if (ddlFornecedores.SelectedItem.Text != "Selecione")
        {
            int idFornecedor = Convert.ToInt32(ddlFornecedores.SelectedItem.Value);


            CompraRevenda compraRevenda = new CompraRevenda();
            compraRevenda.Pagamento = txtPagamento.Text;
            compraRevenda.Data = Convert.ToDateTime(txtData.Text);
            compraRevenda.FornecedorCodigo = idFornecedor;


            ComprarevendaBD bd = new ComprarevendaBD();
            if (bd.Insert(compraRevenda))
            {
                lblMensagem.Text = "CompraRevenda cadastrada com sucesso";
                txtPagamento.Text = "";
                txtData.Text = "";
                txtData.Focus();

                for (int i = 0; i < ddlFornecedores.Items.Count; i++)
                {
                    ddlFornecedores.Items[i].Selected = false;
                }
                ddlFornecedores.Items[0].Selected = true;
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
        else
        {
            lblMensagem.Text = "Selecione um fornecedor";
            ddlFornecedores.Focus();
        }

    }
}