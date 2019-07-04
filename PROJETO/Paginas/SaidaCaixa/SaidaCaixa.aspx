<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaidaCaixa.aspx.cs" Inherits="Paginas_SaidaCaixa_SaidaCaixa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Cadastrar Saída de Caixa</title>
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
        <a href="ListarSaidaCaixa.aspx">Voltar</a>
    </div>
    <form id="form1" runat="server">
        <div>
            <strong>Saídas de Caixa</strong><br />
            <br />
            Vendedor:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtVendedor" runat="server"></asp:TextBox>
            <br />
            Data:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
            <br />
            Preco:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>
            <br />
            Descrição:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
