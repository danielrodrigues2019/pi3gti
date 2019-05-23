<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarCompraRevenda.aspx.cs" Inherits="Paginas_CompraRevenda_CadastrarCompraRevenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Fornecedor"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlFornecedores" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="pagamento" runat="server" Text="Pagamento"></asp:Label>
&nbsp;<asp:TextBox ID="txtPagamento" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="data" runat="server" Text="Data"></asp:Label>
&nbsp;<asp:TextBox ID="txtData" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        </p>
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        
    </form>
</body>
</html>
