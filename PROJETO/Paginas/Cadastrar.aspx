<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastrar.aspx.cs" Inherits="Paginas_Cadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        
        <asp:Label ID="nome" runat="server" Text="Nome"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNome" runat="server" OnTextChanged="nome1_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="cpf" runat="server" Text="CPF"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="telefone" runat="server" Text="Telefone"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="endereco" runat="server" Text="Endereço"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="salvar_Click" />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
