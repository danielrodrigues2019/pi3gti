<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarVenda.aspx.cs" Inherits="Paginas_Venda_CadastrarVenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastar Venda</title>
    <style type="text/css">
        body {
            background-image: url(../../Imagens/backgroud.jpg)
        }
        
        #GridView1 {
            background-color: #ffffff;
        }
        #cabecalho{
            height: 30px;
            background-color:#b5b2b2;
        }
       
    </style>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../js/plugins/datatables/dataTables.bootstrap.css" rel="stylesheet" />
    <link href="../../js/plugins/datatables/extensions/Buttons/css/buttons.dataTables.min.css" rel="stylesheet" />
    <link href="../../js/plugins/datatables/jquery.dataTables.min.css" rel="stylesheet" />
    <link href="../../Content/font-awesome.min.css" rel="stylesheet" />
    <%--<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-select@1.13.9/dist/css/bootstrap-select.min.css">--%>
</head>
<body >
    <div id="cabecalho">
        <a href="ListarVendas.aspx">Voltar</a>
    </div>

    <form id="form1" runat="server">
        <div>
        </div>
        <strong>
        <asp:Label ID="Label" runat="server" Text="Cadastrar Venda"></asp:Label>
        </strong>
        <br />
        <br />
        <asp:Label ID="lblVendedor" runat="server" Text="Vendedor"></asp:Label>
        &nbsp;
        <asp:DropDownList ID="ddlVendedor" runat="server" data-live-search="true" OnSelectedIndexChanged="ddlVendedor_SelectedIndexChanged">
        </asp:DropDownList>

        <br />

        <asp:Label ID="lblCliente" runat="server" Text="Cliente"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddlClientes" CssClass="" data-live-search="true" runat="server">
        </asp:DropDownList>
        <br />
       
        <asp:Label ID="data" runat="server" Text="Data"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtData" CssClass="" TextMode="Date" runat="server"></asp:TextBox>
        <br />
     
        <asp:GridView ID="gdvProdutos" CssClass="table table-hover tabelaCompleta" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField HeaderText="Codigo" DataField="pro_codigo" />
                <asp:BoundField HeaderText="Produto" DataField="pro_nome" />
                <asp:TemplateField HeaderText="Quantidade">
                    <ItemTemplate>
                        <asp:TextBox ID="txtQnt" runat="server" TextMode="Number"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Preço de Compra">
                    <ItemTemplate>
                        <asp:TextBox ID="txtpreco" runat="server" TextMode="Number" ></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        
        <asp:Label ID="lblPagamento" runat="server" Text="Pagamento"></asp:Label>
        <asp:DropDownList ID="ddlPagamento" runat="server">
            <asp:ListItem>Selecione</asp:ListItem>
            <asp:ListItem>Débito</asp:ListItem>
            <asp:ListItem>Crédito</asp:ListItem>
            <asp:ListItem>Dinheiro</asp:ListItem>
            <asp:ListItem>Parcelado</asp:ListItem>
        </asp:DropDownList>
                
        &nbsp;<asp:Label ID="lblTotal" runat="server" Text="Total"></asp:Label>
        &nbsp;<asp:TextBox ID="txtTotal" runat="server" TextMode="Number"></asp:TextBox>

        &nbsp;<asp:Label ID="lblEntrada" runat="server" Text="Entrada"></asp:Label>
        &nbsp;<asp:TextBox ID="txtEntrada" runat="server" TextMode="Number" ></asp:TextBox>

        &nbsp;<asp:Label ID="lblNumparcelas" runat="server" Text="Numero de Parcelas"></asp:Label>
        <asp:TextBox ID="txtNumparcelas" runat="server" TextMode="Number" ></asp:TextBox>
        
        <asp:Label ID="lblValor" runat="server" Text="Valor Parcela"></asp:Label>
        <asp:TextBox ID="txtValor" runat="server" TextMode="Number" ></asp:TextBox>

        <asp:Button ID="CalcularTotal" CssClass="btn btn-primary" runat="server" Text="Calcular Total" OnClick="CalcularTotal_Click" />

        <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Finalizar Venda" OnClick="btnSalvar_Click" />
        
        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>

    </form>
    <script src="../../js/jquery-1.12.3.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
    <link href="../../Scripts/bootstrap-select.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap-select.min.js"></script>
    <%--caso seja master--%>    <%--<script src="js/plugins/datatables/jquery.dataTables.min.js"></script>--%>

    <script src="../../js/plugins/datatables/jquery.dataTables.min.js"></script>
    <script src="../../js/plugins/datatables/dataTables.bootstrap.min.js"></script>
    <script src="../../js/plugins/datatables/extensions/Buttons/js/dataTables.buttons.min.js"></script>
    <script src="../../js/plugins/datatables/extensions/Buttons/js/buttons.flash.min.js"></script>
    <script src="../../js/plugins/datatables/jszip.min.js"></script>
    <script src="../../js/plugins/datatables/extensions/Buttons/js/pdfmake.min.js"></script>
    <script src="../../js/plugins/datatables/vfs_fonts.js"></script>
    <script src="../../js/plugins/datatables/extensions/Buttons/js/buttons.html5.min.js"></script>
    <script src="../../js/plugins/datatables/extensions/Buttons/js/buttons.print.min.js"></script>
    <script src="../../js/plugins/datatables/extensions/Buttons/js/buttons.colVis.min.js"></script>


    <script src="../../js/Tabela.js"></script>

    <script>
        $('.dropA').selectpicker();
    </script>

</body>
</html>
