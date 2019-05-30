<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SaidaCaixa.aspx.cs" Inherits="Paginas_SaidaCaixa_SaidaCaixa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Saídas de Caixa<br />
            Vendedor:<br />
            <asp:TextBox ID="txtVendedor" runat="server"></asp:TextBox>
            <br />
            <br />
            Data:<br />
            <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
            <br />
            <br />
            Preco:<br />
            <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>
            <br />
            <br />
            Descrição:<br />
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
