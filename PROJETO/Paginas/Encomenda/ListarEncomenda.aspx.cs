using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;
using System.Data;

public partial class Paginas_Encomenda_ListarEncomenda : System.Web.UI.Page
{
    private void Carrega()
    {
        EncomendaBD bd = new EncomendaBD();
        DataSet ds = bd.SelectAll();
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();
    }
}