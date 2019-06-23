<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioVenda.aspx.cs" Inherits="Paginas_Relatórios_RelatorioVenda" %>

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
            gValues[0] = ["Dia", "Quant", "Total"];
            console.log(valuesResult, valuesResult.length);
            for (i = 0; i < valuesResult.length; i++) {
                gValues[i+1] = [valuesResult[i][0], parseInt(valuesResult[i][1]), parseInt(valuesResult[i][2])];
            }

            console.log(gValues);
              google.charts.load('current', {'packages':['corechart']});
              google.charts.setOnLoadCallback(drawChart);

              function drawChart() {
                var data = google.visualization.arrayToDataTable(gValues);

                var options = {
                  title: 'Company Performance',
                  hAxis: {title: 'Year',  titleTextStyle: {color: '#333'}},
                  vAxis: {minValue: 0}
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
            <br />
            <br />
            <asp:Label ID="lblDataIni" runat="server" Text="Data Inicial">
                <asp:TextBox ID="txtDataIni" runat="server" type="date" value="2019-01-01"></asp:TextBox></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblDataFim" runat="server" Text="Data Final">
                <asp:TextBox ID="txtDataFim" runat="server" type="date" value="2019-12-12"></asp:TextBox></asp:Label>
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
