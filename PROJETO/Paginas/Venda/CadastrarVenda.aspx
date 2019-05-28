<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarVenda.aspx.cs" Inherits="Paginas_Venda_CadastrarVenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Selecione o cliente:<br />
            <asp:DropDownList ID="ddlCliente" runat="server" OnSelectedIndexChanged="ddlCliente_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
