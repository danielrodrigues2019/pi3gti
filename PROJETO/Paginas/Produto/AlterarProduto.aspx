<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AlterarProduto.aspx.cs" Inherits="Paginas_AlterarProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Alterar Produto</title>
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
        <a href="ListarProduto.aspx">Voltar</a>
    </div>
    <form id="form1" runat="server">
        <p>
            <strong>Alteração de Produto</strong></p>
        <p>
            <br />
            Nome:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            Categoria:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
            <br />
            Preço de Venda:&nbsp;&nbsp; <asp:TextBox ID="txtPrecoVenda" runat="server"></asp:TextBox>
        </p>
        <p>
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </p>
        <div>
        </div>
    </form>
</body>
</html>