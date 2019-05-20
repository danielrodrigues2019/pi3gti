<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarVendedor.aspx.cs" Inherits="Paginas_Vendedor_CadastrarVendedor" %>

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
            <asp:Label ID="usuario" runat="server" Text="Usuario"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="senha" runat="server" Text="Senha"></asp:Label>
            &nbsp;
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="cpf" runat="server" Text="CPF"></asp:Label>
            &nbsp;&nbsp;
        <asp:TextBox ID="txtcpf" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="email" runat="server" Text="Email"></asp:Label>
            &nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="salvar_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
