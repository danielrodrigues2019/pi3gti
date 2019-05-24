<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarProduto.aspx.cs" Inherits="Paginas_CadastrarProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cadastro de Produto<br />
            Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            Data de Cadastro:<asp:TextBox ID="txtCadastro" runat="server"></asp:TextBox>
            <br />
            Preço de Venda:<asp:TextBox ID="txtPrecoVenda" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>