﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarCliente.aspx.cs" Inherits="Paginas_Cadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Cadastrar Cliente</title>
    <style type="text/css">
        body {
            background-image: url(../../Imagens/backgroud.jpg)
        }
        
        #GridView1 {
            background-color: #ffffff;
        }
         #cabecalho{
            height: 30px;
            background-color:#b5b2b2;
        }
       
    </style>
</head>
<body>
    <div id="cabecalho">
        <a href="ListarCliente.aspx">Voltar</a>
    </div>
    <form id="form1" runat="server">
        <div>

            <strong>

            <asp:Label ID="Label" runat="server" Text="Cadastro de Cliente"></asp:Label>
            </strong>
            <br />
            <br />
            <asp:Label ID="nome" runat="server" Text="Nome"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNome" runat="server" OnTextChanged="nome1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="cpf" runat="server" Text="CPF"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="telefone" runat="server" Text="Telefone"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="endereco" runat="server" Text="Endereço"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="datacadastro" runat="server" Text="Data de Cadastro"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtDatacadastro" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="salvar_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>

</html>
