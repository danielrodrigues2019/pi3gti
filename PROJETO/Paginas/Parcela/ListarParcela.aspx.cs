﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Persistencia;
using System.Data;

public partial class Paginas_Parcela_ListarParcela : System.Web.UI.Page
{
    private void Carrega()
    {
        ParcelaBD bd = new ParcelaBD();
        DataSet ds = bd.SelectAll();
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();
    }
    //protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
    //    int codigo = 0;
    //    switch (e.CommandName)
    //    {
    //        case "Alterar":
    //            codigo = Convert.ToInt32(e.CommandArgument);
    //            Session["ID"] = codigo;
    //            Response.Redirect("AlterarParcela.aspx");
    //            break;
    //        case "Deletar":
    //            codigo = Convert.ToInt32(e.CommandArgument);
    //            ParcelaBD bd = new ParcelaBD();
    //            bd.Delete(codigo);
    //            Carrega();
    //            break;
    //        default:
    //            break;
    //    }
    //}
}