<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarCompraRevenda.aspx.cs" Inherits="Paginas_CompraRevenda_ListarCompraRevenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Listar Compra</title>
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
        <a href="CadastrarCompraRevenda.aspx">Cadastrar Compra</a>
    </div>
    <form id="form2" runat="server">
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar" CommandArgument='<%# Bind("com_codigo")%>'>Alterar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar" CommandArgument='<%# Bind("com_codigo")%>'>Excluir</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>

