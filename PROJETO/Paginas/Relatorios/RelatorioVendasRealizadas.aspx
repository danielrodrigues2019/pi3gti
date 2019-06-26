<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioVendasRealizadas.aspx.cs" Inherits="Paginas_Relatorios_RelatorioQuantidadeVenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
        function showData() {
            valuesResult = JSON.parse($("#hdnResultado").val());
            gValues = [];
            gValues[0] = ["Dia", "vendasrealizadas"];
            console.log(valuesResult, valuesResult.length);
            for (i = 0; i < valuesResult.length; i++) {
                gValues[i + 1] = [valuesResult[i][0], parseInt(valuesResult[i][1])];
            }

            console.log(gValues);
            google.charts.load('current', { 'packages': ['corechart'] });
            google.charts.setOnLoadCallback(drawChart);

            function drawChart() {
                var data = google.visualization.arrayToDataTable(gValues);

                var options = {
                    title: 'Company Performance',
                    hAxis: { title: 'Year', titleTextStyle: { color: '#333' } },
                    vAxis: { minValue: 0 }
                };

                var chart = new google.visualization.AreaChart(document.getElementById('chart_div'));
                chart.draw(data, options);
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="lblTipo" runat="server" Text="Tipo de relatorio"></asp:Label>
            <asp:DropDownList ID="ddlTipo" runat="server">
                <asp:ListItem>Selecione</asp:ListItem>
                <asp:ListItem>vendasrealizadas</asp:ListItem>
            </asp:DropDownList>
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
            <asp:Button ID="btnGerar" runat="server" Text="Gerar Relatorio" OnClick="GetData" />
            <br />


            <asp:TextBox ID="hdnResultado" runat="server" type="text" />

        </div>
        <div id="chart_div" style="width: 100%; height: 500px;"></div>
    </form>
</body>
</html>
