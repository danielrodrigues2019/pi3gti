<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarEncomenda.aspx.cs" Inherits="Paginas_Encomenda_CadastrarEncomenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Cadastro de Encomenda"></asp:Label>
            <br />
            <br />
&nbsp;Produto :<br />
            <asp:TextBox ID="txtProduto" runat="server"></asp:TextBox>
            <br />
            <br />
            Data de Pedido:<br />
            <asp:TextBox ID="txtDataPedido" runat="server"></asp:TextBox>
            <br />
            <br />
            Valor:<br />
            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            <br />
            <br />
            Cliente:<br />
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
