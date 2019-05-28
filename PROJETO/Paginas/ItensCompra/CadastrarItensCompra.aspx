<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarItensCompra.aspx.cs" Inherits="Paginas_ItensCompra_CadastrarItensCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="quantidade" runat="server" Text="Quantidade"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="precocusto" runat="server" Text="Preço Custo"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrecocusto" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />

            <br />
            <br />

            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
