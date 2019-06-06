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
    private void CarregaDDL()
    {
        CarneBD bd = new CarneBD();
        DataSet ds = null;

        
        {
            ds = bd.SelectAllClientes();
        }
        ddlCliente.Items.Clear();
        //vincula dados do ds ao componente ddl
        ddlCliente.DataSource = ds.Tables[0].DefaultView;
        ddlCliente.DataTextField = "cli_nome";
        ddlCliente.DataValueField = "cli_codigo";
        ddlCliente.DataBind();
        //adiciona item "Selecione" na primeira posição do ddl
        ddlCliente.Items.Insert(0, "Selecione");
    }
    //protected void CarregaDDL()
    //{
    //    CarneBD bd = new CarneBD();
    //    DataSet ds = null;

    //    ds = bd.SelectAll();

    //    ddlCliente.Items.Clear();

    //    ddlCliente.DataSource = ds.Tables[0].DefaultView;
    //    ddlCliente.DataTextField = "par_codigo";
    //    ddlCliente.DataValueField = "par_codigo";
    //    ddlCliente.DataBind();

    //    ddlStatus.Items.Insert(0, "Selecione");
    //}


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
    {
        CarregaDDL();
        //SelectddlClientes();

        ClienteBD cli = new ClienteBD();
        Cliente cliente = cli.Select(Convert.ToInt32(Session["ID"]));
        ddlCliente.SelectedIndex = cliente.Codigo;





    }
   }

    protected void salvar_Click(object sender, EventArgs e)
    {
        {
            Despesa despesa = new Despesa();

            DespesaBD bd = new DespesaBD();
            if (bd.Insert(despesa))
            {
                lblMensagem.Text = "Despesa cadastrada com sucesso";
                ddlStatus.Text = "";

            }
            else
            {
                lblMensagem.Text = "Erro ao salvar.";
            }

        }
    }
}