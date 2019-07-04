<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarSaidaCaixa.aspx.cs" Inherits="Paginas_SaidaCaixa_ListarSaidaCaixa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Listar Saida de Caixa</title>
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
        <a href="../Inicio/Inicio.aspx">Voltar</a>&nbsp;
        <a href="SaidaCaixa.aspx">Cadastrar Saida deCaixa</a>
    </div>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
 <asp:TemplateField>
 <ItemTemplate>
 <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar"
CommandArgument='<%# Bind("cai_codigo")%>'>Alterar</asp:LinkButton>
 </ItemTemplate>
 </asp:TemplateField>
 <asp:TemplateField>
 <ItemTemplate>
 <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar"
CommandArgument='<%# Bind("cai_codigo")%>'>Excluir</asp:LinkButton>
 </ItemTemplate>
 </asp:TemplateField>
 </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
