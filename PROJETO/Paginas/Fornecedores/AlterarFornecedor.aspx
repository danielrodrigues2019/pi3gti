<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AlterarFornecedor.aspx.cs" Inherits="Paginas_Fornecedores_AlterarFornecedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="nome" runat="server" Text="Nome"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="telefone" runat="server" Text="Telefone"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="cnpj" runat="server" Text="CNPJ"></asp:Label>
            &nbsp;
        <asp:TextBox ID="txtCNPJ" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="endereco" runat="server" Text="Endereço"></asp:Label>
            &nbsp;&nbsp;
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="salvar_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
