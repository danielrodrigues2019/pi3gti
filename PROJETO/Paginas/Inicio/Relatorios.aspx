<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Relatorios.aspx.cs" Inherits="Paginas_Inicio_Relatorios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Relatórios</title>
    <style type="text/css">
        body {
            background-image: url(../../Imagens/backgroud.jpg)
        }
        
        .auto-style1 {
            height:80px;
            width: 350px;
            border:4px solid #808080;
            color: #6cf6ba;
            font-size: 25px;
            margin: 30px;
            margin-left:80px;
            background-color:#ffffff;
        }
       
       
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="auto-style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <a href="../Relatorios/RelatorioCliente.aspx">Adesão de Clientes</a>
            </div>
            
             <div class="auto-style1">
                &nbsp;
                <a href="../Relatorios/RelatorioMargemLucro.aspx">Margem de Lucro por produto</a>
            </div>
            
             <div class="auto-style1">
                &nbsp;&nbsp;
                <a href="../Relatorios/RelatorioVenda.aspx">Relatório de Valor de Vendas</a><br />
            </div>

             <div class="auto-style1">
                  &nbsp;<a href="../Relatorios/RelatorioVendasRealizadas.aspx">Relatório de Vendas Realizadas</a>
            </div>
        </div>
    </form>
</body>
</html>
