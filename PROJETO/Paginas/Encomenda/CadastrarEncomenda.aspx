<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarEncomenda.aspx.cs" Inherits="Paginas_Encomenda_CadastrarEncomenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Cadastrar Encomenda</title>
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
        <a href="ListarEncomenda.aspx">Voltar</a>
    </div>
    <form id="form1" runat="server">
        <div>
            <strong>
            <asp:Label ID="lblTitulo" runat="server" Text="Cadastro de Encomenda"></asp:Label>
            </strong>
            <br />
            <br />
&nbsp;Produto :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProduto" runat="server"></asp:TextBox>
            <br />
            <br />
            Data de Pedido: <asp:TextBox ID="txtDataPedido" runat="server"></asp:TextBox>
            <br />
            <br />
            Valor:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            <br />
            <br />
            Cliente:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCliente" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
