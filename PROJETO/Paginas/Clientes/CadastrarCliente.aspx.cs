﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETO.Classes;
using PROJETO.Persistencia;

public partial class Paginas_Cadastrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void nome1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void salvar_Click(object sender, EventArgs e)
    {
        Cliente cliente = new Cliente();
        cliente.Nome = txtNome.Text;
        cliente.Telefone = Convert.ToString(txtTelefone.Text);
        cliente.Endereco = txtEndereco.Text;
        cliente.CPF = txtCpf.Text;
        cliente.Telefone = txtTelefone.Text;
        cliente.Datacadastro = Convert.ToDateTime(txtDatacadastro.Text);
        ClienteBD bd = new ClienteBD();
        if (bd.Insert(cliente))
        {
            lblMensagem.Text = "Cliente cadastrado com sucesso";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtDatacadastro.Text = "";
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }
}