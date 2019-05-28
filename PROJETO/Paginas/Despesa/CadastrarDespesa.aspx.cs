using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;

public partial class Paginas_Despesa_CadastrarDespesa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DespesaBD bd = new DespesaBD();
            DataSet ds = bd.SelectAll();
            ddlstatus.DataSource = ds.Tables[0].DefaultView;
            ddlstatus.DataTextField = "des_status";
            ddlstatus.DataValueField = "des_status";
            ddlstatus.DataBind();
            ddlstatus.Items.Insert(0, "Selecione");

        }
    }

    protected void salvar_Click(object sender, EventArgs e)
    {
        Despesa despesa = new Despesa();
        despesa.Descricao = txtDescricao.Text;
        despesa.Valor = txtValor.Text;
        despesa.DataVencimento = txtDataVencimento.Text;
        despesa.Status = ddlstatus.Text;
        DespesaBD bd = new DespesaBD();
        if (bd.Insert(despesa))Convert.ToDateTime
        {
            lblMensagem.Text = "Funcionário cadastrado com sucesso";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtDataVencimento.Text = "";
            ddlstatus.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}