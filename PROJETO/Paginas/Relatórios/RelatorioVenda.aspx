<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioVenda.aspx.cs" Inherits="Paginas_Relatórios_RelatorioVenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="lblDataIni" runat="server" Text="Data Inicial">
                <asp:TextBox ID="txtDataIni" runat="server" type="date"></asp:TextBox></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblDataFim" runat="server" Text="Data Final">
                <asp:TextBox ID="txtDataFim" runat="server" type="date"></asp:TextBox></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnGerar" runat="server" Text="Gerar Relatorio" OnClick="GerarRelatorio" />
            <br />

           
        </div>
        <asp:GridView ID="QuantidadeVendas" runat="server"></asp:GridView>
        <div>
            <asp:Chart ID="Grafico1" runat="server">
                <Series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>
    </form>
    <script type="text/javascript">
        data = "<%= data  %>");
        console.log(data);
    </script>
</body>
</html>
