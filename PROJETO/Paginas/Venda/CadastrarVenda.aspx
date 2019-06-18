<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarVenda.aspx.cs" Inherits="Paginas_Venda_CadastrarVenda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../js/plugins/datatables/dataTables.bootstrap.css" rel="stylesheet" />
    <link href="../../js/plugins/datatables/extensions/Buttons/css/buttons.dataTables.min.css" rel="stylesheet" />
    <link href="../../js/plugins/datatables/jquery.dataTables.min.css" rel="stylesheet" />
    <link href="../../Content/font-awesome.min.css" rel="stylesheet" />
    <%--<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-select@1.13.9/dist/css/bootstrap-select.min.css">--%>
</head>
<body style="padding: 30px">

    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Cliente"></asp:Label>
        &nbsp;<asp:DropDownList ID="ddlClientes" CssClass="" data-live-search="true" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Label ID="ddlpagamento" runat="server" Text="Pagamento"></asp:Label>
        <asp:DropDownList ID="ddl" runat="server">
            <asp:ListItem>Selecione</asp:ListItem>            
            <asp:ListItem>Débito</asp:ListItem>
            <asp:ListItem>Crédito</asp:ListItem>
            <asp:ListItem>Dinheiro</asp:ListItem>
            <asp:ListItem>Carnê</asp:ListItem>

        </asp:DropDownList>
        <br />
        <%--<asp:Label ID="pagamento" runat="server" Text="Pagamento"></asp:Label>
        &nbsp;<asp:TextBox ID="txtPagamento" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>--%>
        <br />
        <asp:Label ID="data" runat="server" Text="Data"></asp:Label>
        &nbsp;<asp:TextBox ID="txtData" CssClass="" TextMode="Date" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:GridView ID="gdvProdutos" CssClass="table table-hover tabelaCompleta" runat="server" OnRowDataBound="gdvProdutos_RowDataBound" AutoGenerateColumns="false">
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
                        <asp:TextBox ID="txtpreco" runat="server" TextMode="Number"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>





        <p>
            <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        </p>
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