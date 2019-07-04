<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarDespesa.aspx.cs" Inherits="Paginas_Despesa_CadastrarDespesa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Cadastrar Despesa</title>
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
        <a href="ListarDespesa.aspx">Voltar</a>
    </div>
    <form id="form1" runat="server">
        <div>
            <strong>
            <asp:Label ID="Label" runat="server" Text="Cadastrar Despesa"></asp:Label>
            </strong>
            <br />
            <br />
            <asp:Label ID="descricao" runat="server" Text="Descrição"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="valor" runat="server" Text="Valor"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="datavencimento" runat="server" Text="Data de Vencimento"></asp:Label>
            &nbsp;
        <asp:TextBox ID="txtDataVencimento" runat="server"></asp:TextBox>
            <br />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:DropDownList ID="ddlstatus" runat="server" DataTextField="Status" DataTextFormatString="Status"></asp:DropDownList>
            &nbsp;
                   <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="salvar_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
