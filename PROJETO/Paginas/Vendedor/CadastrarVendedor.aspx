<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarVendedor.aspx.cs" Inherits="Paginas_Vendedor_CadastrarVendedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Cadastar Vendedor</title>
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
        <a href="ListarVendedor.aspx">Voltar</a>
    </div>
    <form id="form1" runat="server">
        <div>
            <strong>
            <asp:Label ID="Label" runat="server" Text="Cadastrar Vendedor"></asp:Label>
            </strong>
            <br />
            <br />
            <asp:Label ID="nome" runat="server" Text="Nome"></asp:Label>
            &nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="usuario" runat="server" Text="Usuario"></asp:Label>
            &nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="senha" runat="server" Text="Senha"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="cpf" runat="server" Text="CPF"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcpf" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="email" runat="server" Text="Email"></asp:Label>
            &nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            Tipo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="salvar_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            
        </div>
    </form>
</body>
</html>
