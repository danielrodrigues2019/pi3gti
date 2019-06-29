<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioMargemLucro.aspx.cs" Inherits="Paginas_Relatorios_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Margem de Lucro</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblProduto" runat="server" Text="Produto"></asp:Label>
        <asp:DropDownList ID="ddlProduto" runat="server" data-live-search="true" OnSelectedIndexChanged="ddlProduto_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
        <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Calcular" OnClick="btnSalvar_Click" />
        <div>
                <asp:GridView ID="GridView1" runat="server" >
                <Columns>
                 
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
