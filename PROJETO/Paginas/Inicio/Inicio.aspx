<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Paginas_Inicio_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Home</title>
    <style type="text/css">
        body {
            background-image: url(../../Imagens/backgroud.jpg)
        }
        
        .auto-style1 {
            height:110px;
            width: 298px;
            border:4px solid #808080;
            color: #6cf6ba;
            font-size: 25px;
            margin: 30px;
            margin-left:80px;
            background-color:#ffffff;
        }
       
       
        .auto-style2 {
            width: 402px;
            height: 233px;
            margin-bottom: 0px;
            float: right;
            margin-right: 100px;

        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <img src="../../Imagens/logo.png" class="auto-style2" />
        &nbsp;<div class="auto-style1">
           <a href="../Produto/ListarProduto.aspx">Produtos</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <img src="../../Imagens/produto.png" />
       </div>
       <div class="auto-style1">
           <a href="../Venda/ListarVendas.aspx">Venda</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <img src="../../Imagens/venda.png" />
       </div>
       <div class="auto-style1">
            <a href="../Encomenda/ListarEncomenda.aspx">Encomendas</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <img src="../../Imagens/encomenda.png" />
        </div>
        <div class="auto-style1">
            <a href="../Clientes/ListarCliente.aspx">Clientes</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <img src="../../Imagens/clientes.png" />
        </div>
        <div class="auto-style1">
            <a href="Relatorios.aspx">Relatórios</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <img src="../../Imagens/relatorios.png" />
        </div>
            <div class="auto-style1">
            <a href="../Fornecedores/ListarFornecedor.aspx">Fornecedores</a>&nbsp;&nbsp;
            <img src="../../Imagens/fornecedores.png" />
        </div>
        <div class="auto-style1">
            <a href="../CompraRevenda/ListarCompraRevenda.aspx">Compras</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <img src="../../Imagens/compras.jpg" />
        </div>
        <div class="auto-style1">
            <a href="../Despesa/ListarDespesa.aspx">Despesas</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <img src="../../Imagens/despesas.png" />
        </div>
        <div class="auto-style1">
            <a href="../SaidaCaixa/ListarSaidaCaixa.aspx">Saída de Caixa</a>&nbsp;&nbsp;
            <img src="../../Imagens/saidacaixa.png" />
        </div>
        <div class="auto-style1">
            <a href="../Vendedor/ListarVendedor.aspx">Vendedor</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <img src="../../Imagens/vendedor.png" />
        </div>
        <div class="auto-style1">
            <a href="../Parcela/ListarParcela.aspx">Carnê</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <img src="../../Imagens/parcela.png" />
        </div>

        
    </form>
</body>
</html>
