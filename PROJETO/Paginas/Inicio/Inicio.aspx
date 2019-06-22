<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Paginas_Inicio_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="../Produto/ListarProduto.aspx">Produtos</a>
            <a href="../Clientes/ListarCliente.aspx">Clientes</a>
            <a href="../CompraRevenda/ListarCompraRevenda.aspx">Compras</a>
            <a href="../Despesa/ListarDespesa.aspx">Despesas</a>
            <a href="../Encomenda/ListarEncomenda.aspx">Encomendas</a>
            <a href="../Fornecedores/ListarFornecedor.aspx">Fornecedores</a>
            <a href="../SaidaCaixa/ListarSaidaCaixa.aspx">Saída de Caixa</a>

        </div>
    </form>
</body>
</html>
