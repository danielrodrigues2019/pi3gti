using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;
using System.Data;


public partial class Paginas_Carne_CadastrarCarne : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            CarregarClientes();
    }

     void CarregarClientes()
    {
        DataSet ds = ClienteBD.SelectTodos();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            ddlCliente.DataSource = ds.Tables[0].DefaultView;
            ddlCliente.DataValueField = "cli_codigo";
            ddlCliente.DataTextField = "cli_nome";
            
            ddlCliente.DataBind();
            ddlCliente.Items.Insert(0,new ListItem("Selecione", "0"));

        }
    }


   
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        if (ddlCliente.SelectedItem.Text != "Selecione")
        {
            int idCliente = Convert.ToInt32(ddlCliente.SelectedItem.Value);


            Carne carne = new Carne();
            carne.Valor = Convert.ToDecimal(txtValor.Text);
            carne.DataParcela = Convert.ToDateTime(txtData.Text);
            carne.NumeroParcelas = Convert.ToInt32(txtNparcelas.Text);
            carne.Clicodigo = idCliente;

           

            CarneBD bd = new CarneBD();
            if (bd.Insert(carne))
            {
                lblMensagem.Text = "Carnê cadastrada com sucesso";
              

            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }


            lblMensagem.Text = "Carnê cadastrada com sucesso";
            
            txtData.Text = "";
            txtData.Focus();

            for (int i = 0; i < ddlCliente.Items.Count; i++)
            {
                ddlCliente.Items[i].Selected = false;
            }
            ddlCliente.Items[0].Selected = true;
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }


    
}
    


    
        

