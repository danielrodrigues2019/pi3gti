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
            //FornecedorBD bd = new FornecedorBD();
            //DataSet ds = bd.SelectAll();
            //ddlFornecedores.DataSource = ds.Tables[0].DefaultView;
            //ddlFornecedores.DataTextField = "forn_nome";
            //ddlFornecedores.DataValueField = "forn_codigo";
            //ddlFornecedores.DataBind();
            //ddlFornecedores.Items.Insert(0, "Selecione");
            CarregarGrid();
            CarregarDrop();

        }

        //todo grid tem que ter isso no page load
        if (gdvProdutos.Rows.Count > 0) //-----------------
            gdvProdutos.HeaderRow.TableSection = TableRowSection.TableHeader;
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
            compraRevenda.Pagamento = ddlpagamento.Text;
            compraRevenda.Data = Convert.ToDateTime(txtData.Text);
            compraRevenda.FornecedorCodigo = idFornecedor;
            ComprarevendaBD bd = new ComprarevendaBD();
            int flag = bd.Insert(compraRevenda);

            if (flag > 0)
            {
                foreach (GridViewRow item in gdvProdutos.Rows)
                {
                    TextBox txtQnt = item.FindControl("txtQnt") as TextBox;
                    TextBox txtPreco = item.FindControl("txtpreco") as TextBox;
                    if (!String.IsNullOrEmpty(txtQnt.Text) && !String.IsNullOrEmpty(txtPreco.Text))
                    {
                        ItensCompra ic = new ItensCompra();
                        ic.PrecoCusto = Convert.ToInt32(txtPreco.Text);
                        ic.Quantidade = Convert.ToInt32(txtQnt.Text);
                        ic.CompraRevendaCodigo = flag;
                        ic.Produto = Convert.ToInt32(item.Cells[0].Text);

                        ItensCompraBD icbd = new ItensCompraBD();

                        icbd.Inserir(ic);

                    }
                }


                lblMensagem.Text = "CompraRevenda cadastrada com sucesso";
                ddlpagamento.Text = "";
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


    private void CarregarGrid()
    {
        DataSet ds = ProdutoBD.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            gdvProdutos.DataSource = ds.Tables[0].DefaultView;
            gdvProdutos.DataBind();
            gdvProdutos.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }

    void CarregarDrop()
    {
        DataSet ds = FornecedorBD.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            ddlFornecedores.DataSource = ds.Tables[0].DefaultView;
            ddlFornecedores.DataTextField = "forn_nome";
            ddlFornecedores.DataValueField = "forn_codigo";
            ddlFornecedores.DataBind();
            ddlFornecedores.Items.Insert(0, "Selecione");
        }
    }


    protected void gdvProdutos_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
}