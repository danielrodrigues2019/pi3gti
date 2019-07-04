<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioMargemLucro.aspx.cs" Inherits="Paginas_Relatorios_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Margem de Lucro</title>
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
        #GridView1 {
            background-color: #ffffff;
        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblProduto" runat="server" Text="Produto"></asp:Label>
        <asp:DropDownList ID="ddlProduto" runat="server" data-live-search="true" OnSelectedIndexChanged="ddlProduto_SelectedIndexChanged">
        </asp:DropDownList>
            <br />
            <br />
        </div>
        <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Calcular" OnClick="btnSalvar_Click" />
        <br />
        <br />
        <div>
                <asp:GridView ID="GridView1" runat="server" >
                <Columns>
                 
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
