<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Paginas_Login_Administrador_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<script src="../../../Scripts/popper.min.js"></script>
<script src="../../../Scripts/jquery-3.0.0.min.js"></script>
<script src="../../../Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Tela Principal do ADM"></asp:Label>
            <br />
            <asp:LinkButton ID="lbSair" runat="server" OnClick="lbSair_Click">Sair</asp:LinkButton>
        </div>
    </form>
</body>
</html>