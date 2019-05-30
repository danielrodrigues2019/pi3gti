<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarCarne.aspx.cs" Inherits="Paginas_Carne_ListarCarne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
 <asp:TemplateField>
 <ItemTemplate>
 <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar"
CommandArgument='<%# Bind("cc_codigo")%>'>Alterar</asp:LinkButton>
 </ItemTemplate>
 </asp:TemplateField>
 <asp:TemplateField>
 <ItemTemplate>
 <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar"
CommandArgument='<%# Bind("cc_codigo")%>'>Excluir</asp:LinkButton>
 </ItemTemplate>
 </asp:TemplateField>
 </Columns>
            </asp:GridView>
        </div>
        </div>
    </form>
</body>
</html>
