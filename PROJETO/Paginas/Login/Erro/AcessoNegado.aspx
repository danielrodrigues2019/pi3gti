﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AcessoNegado.aspx.cs" Inherits="Paginas_Login_Erro_AcessoNegado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <title>Erro</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Acesso Negado"></asp:Label>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Paginas/Login/Login.aspx">Voltar para a tela de Login</asp:HyperLink>
        </div>
    </form>
</body>
</html>