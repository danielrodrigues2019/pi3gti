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

    }

    protected void salvar_Click(object sender, EventArgs e)
    {

        Despesa despesa = new Despesa();

        DespesaBD bd = new DespesaBD();
        if (bd.Insert(despesa))
        {
            lblMensagem.Text = "Carnê cadastrada com sucesso";
            ddlCliente.Text = "";

        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
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
            
            carne.Clicodigo = idCliente;
            CarneBD bd = new CarneBD();
            


            lblMensagem.Text = "CompraRevenda cadastrada com sucesso";
            ddlCliente.Text = "";
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
    //void CarregarDrop()
    //{
    //    DataSet ds = CarneBD.SelectAll();
    //    int qtd = ds.Tables[0].Rows.Count;
    //    if (qtd > 0)
    //    {
    //        dllCliente.DataSource = ds.Tables[0].DefaultView;
    //        dllCliente.DataTextField = "cli_nome";
    //        dllCliente.DataValueField = "cli_codigo";
    //        dllCliente.DataBind();
    //        dllCliente.Items.Insert(0, "Selecione");
    //    }
//    }

//}


    
        

