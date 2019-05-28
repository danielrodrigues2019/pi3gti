<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AlterarProduto.aspx.cs" Inherits="Paginas_AlterarProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Alteração de Produto<br />
            Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            Categoria:<asp:TextBox ID="txtData" runat="server"></asp:TextBox>
            <br />
            Preço de Venda:<asp:TextBox ID="txtPrecoVenda" runat="server"></asp:TextBox>
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