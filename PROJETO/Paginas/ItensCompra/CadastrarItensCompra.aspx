<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarItensCompra.aspx.cs" Inherits="Paginas_ItensCompra_CadastrarItensCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"> 
<head runat="server">
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Itens compra</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="Produto1" runat="server" Text="Produto"></asp:Label>
            <asp:DropDownList ID="ddlProduto" runat="server">
        </asp:DropDownList>
            <br />
            <asp:Label ID="quantidade" runat="server" Text="Quantidade"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="precocusto" runat="server" Text="Preço Custo"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrecocusto" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" PostBackUrl="~/Paginas/ItensCompra/CadastrarItensCompra.aspx" />

            <br />
            <br />

            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
    <a href="../CompraRevenda/CadastrarCompraRevenda.aspx">Cadastrar Compra Revenda</a>
</body>
</html>
