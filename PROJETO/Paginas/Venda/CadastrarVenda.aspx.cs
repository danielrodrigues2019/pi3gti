using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;

public partial class Paginas_Venda_CadastrarVenda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //FornecedorBD bd = new FornecedorBD();
            //DataSet ds = bd.SelectAll();
            //ddlClientes.DataSource = ds.Tables[0].DefaultView;
            //ddlClientes.DataTextField = "forn_nome";
            //ddlClientes.DataValueField = "forn_codigo";
            //ddlClientes.DataBind();
            //ddlClientes.Items.Insert(0, "Selecione");
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
        if (ddlClientes.SelectedItem.Text != "Selecione")
        {
            int idCliente = Convert.ToInt32(ddlClientes.SelectedItem.Value);


            Venda venda = new Venda();
            venda.Pagamento = ddl.Text;
            venda.Data = Convert.ToDateTime(txtData.Text);
            venda.ClienteCodigo = Convert.ToInt32(idCliente);
            VendaBD bd = new VendaBD();
            int flag = bd.Insert(venda);

            if (flag > 0)
            {
                foreach (GridViewRow item in gdvProdutos.Rows)
                {
                    TextBox txtQnt = item.FindControl("txtQnt") as TextBox;
                    TextBox txtPreco = item.FindControl("txtpreco") as TextBox;
                    if (!String.IsNullOrEmpty(txtQnt.Text) && !String.IsNullOrEmpty(txtPreco.Text))
                    {
                        ItensVenda ic = new ItensVenda();
                        ic.Preco = Convert.ToInt32(txtPreco.Text);
                        ic.Quantidade = Convert.ToInt32(txtQnt.Text);
                        ic.VendaCodigo = flag;
                        ic.Produto = Convert.ToInt32(item.Cells[0].Text);

                        ItensVendaBD icbd = new ItensVendaBD();

                        icbd.Inserir(ic);

                    }
                }


                lblMensagem.Text = "Venda cadastrada com sucesso";
                ddlpagamento.Text = "";
                txtData.Text = "";
                txtData.Focus();

                for (int i = 0; i < ddlClientes.Items.Count; i++)
                {
                    ddlClientes.Items[i].Selected = false;
                }
                ddlClientes.Items[0].Selected = true;
            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }
        }
        else
        {
            lblMensagem.Text = "Selecione um Cliente";
            ddlClientes.Focus();
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
        DataSet ds = ClienteBD.SelectTodos();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            ddlClientes.DataSource = ds.Tables[0].DefaultView;
            ddlClientes.DataTextField = "cli_nome";
            ddlClientes.DataValueField = "cli_codigo";
            ddlClientes.DataBind();
            ddlClientes.Items.Insert(0, "Selecione");
        }
    }


    protected void gdvProdutos_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
}