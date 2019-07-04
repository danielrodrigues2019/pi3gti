<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioLucroDoMes.aspx.cs" Inherits="Paginas_Relatorios_RelatorioLucroDoMes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Lucro do mes</title>


</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" Height="196px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="284px">
                <Columns>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
