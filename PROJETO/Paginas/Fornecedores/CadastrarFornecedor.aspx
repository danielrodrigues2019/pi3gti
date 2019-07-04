<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarFornecedor.aspx.cs" Inherits="Paginas_Fornecedores_CadastrarFornecedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Cadastrar Fornecedor</title>
    <style type="text/css">
        body {
            background-image: url(../../Imagens/backgroud.jpg)
        }
        
        #GridView1 {
            background-color: #ffffff;
        }
        #cabecalho{
            height: 30px;
            background-color:#b5b2b2;
        }
       
    </style>
</head>
<body>
    <div id="cabecalho">
        <a href="ListarFornecedor.aspx">Voltar</a>
    </div>
    <form id="form1" runat="server">
        <div>
            <strong>
            <asp:Label ID="Label" runat="server" Text="Cadastrar Fornecedor"></asp:Label>
            </strong>
            <br />
            <br />
            <asp:Label ID="nome" runat="server" Text="Nome"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="telefone" runat="server" Text="Telefone"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="cnpj" runat="server" Text="CNPJ"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
