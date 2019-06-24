using System;
using System.Data;
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
            CarregarGrid();
            CarregarDrop();

        }

        //todo grid tem que ter isso no page load
        if (gdvProdutos.Rows.Count > 0) //-----------------
            gdvProdutos.HeaderRow.TableSection = TableRowSection.TableHeader;
    }

    private void CarregarGrid()
    {
        DataSet ds = new ProdutoBD().SelectAll();
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

        ds = new VendedorBD().SelectAll();
        qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            ddlVendedor.DataSource = ds.Tables[0].DefaultView;
            ddlVendedor.DataTextField = "ven_nome";
            ddlVendedor.DataValueField = "ven_codigo";
            ddlVendedor.DataBind();
            ddlVendedor.Items.Insert(0, "Selecione");
        }
    }


    protected void onCellTextChange(object sender, EventArgs e)
    {
        double total = 0.0;
        foreach (GridViewRow item in gdvProdutos.Rows)
        {
            TextBox txtPreco = item.FindControl("txtpreco") as TextBox;
            if (!String.IsNullOrEmpty(txtPreco.Text))
            {
                total += Convert.ToDouble(txtPreco.Text);
            }
        }
        txtTotal.Text = total.ToString();
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        if (ddlClientes.SelectedItem.Text != "Selecione")
        {
            int idCliente = Convert.ToInt32(ddlClientes.SelectedItem.Value);
            int idVendedor = Convert.ToInt32(ddlVendedor.SelectedItem.Value);


            Venda venda = new Venda();
            venda.Pagamento = ddlPagamento.Text;
            venda.Data = Convert.ToDateTime(txtData.Text);
            venda.ClienteCodigo = Convert.ToInt32(idCliente);
            venda.VendedorCodigo = Convert.ToInt32(idVendedor);
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

                if (ddlPagamento.Text == "Parcelado")
                {
                    Parcela parcela = new Parcela();
                    parcela.Valor = Convert.ToDouble(txtValor.Text);
                    parcela.Clicodigo = Convert.ToInt32(idCliente);
                    parcela.Vencodigo = flag;

                    ParcelaBD parcelaBD = new ParcelaBD();
                    DateTime today = new DateTime(2019, 6, 23);
                    for (int i = 1; i <= Convert.ToInt16(txtNumparcelas.Text); i++)
                    {
                        today.AddMonths(1);
                        parcela.DataPagamento = today;
                        parcelaBD.Insert(parcela);
                    }
                    //Parcela parcela = new Parcela();
                    //parcela.Valor = Convert.ToDouble(txtValor.Text);
                    //parcela.Clicodigo = Convert.ToInt32(idCliente);
                    //parcela.Vencodigo = flag;

                    //ParcelaBD parcelaBD = new ParcelaBD();
                    //DateTime today = DateTime.Today;
                    //int i = 0;
                    //for (i = 1; i <= Convert.ToInt32(txtNumparcelas.Text); i++)
                    //{
                    //    parcela.DataPagamento = today.AddMonths(1);
                    //    parcelaBD.Insert(parcela); //Creio que não seja aqui, mas não sei o que tem dentro de ParcelaBD
                    //}


                }



                lblMensagem.Text = "Venda cadastrada com sucesso";
                ddlPagamento.Text = "";
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

    protected void CalcularTotal_Click(object sender, EventArgs e)
    {
        double total = GeraTotal();
        if (ddlPagamento.Text == "Parcelado")
        {
            double entrada = Convert.ToDouble(txtEntrada.Text);
            txtValor.Text = ((total - entrada) / Convert.ToDouble(txtNumparcelas.Text)).ToString();
        }
        txtTotal.Text = total.ToString();
    }

    private double GeraTotal()
    {
        double total = 0.0;
        foreach (GridViewRow item in gdvProdutos.Rows)
        {
            TextBox txtPreco = item.FindControl("txtpreco") as TextBox;
            if (!String.IsNullOrEmpty(txtPreco.Text))
            {
                total += Convert.ToDouble(txtPreco.Text);
            }
        }
        return total;
    }
}