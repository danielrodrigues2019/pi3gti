<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarCarne.aspx.cs" Inherits="Paginas_Carne_CadastrarCarne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastrar Conta Corrente</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="margin-left: 40px">
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="contacorrente" runat="server" Text="Conta Corrente"></asp:Label>
                <asp:DropDownList ID="ddlStatus" runat="server">
                    <asp:ListItem Selected="True" Value="Select"> Selecione </asp:ListItem>
                    <asp:ListItem Value="contacorrente"> Conta Corrente </asp:ListItem>
                    <asp:ListItem Value="carne"> Carnê </asp:ListItem>
                </asp:DropDownList>

                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="cliente" runat="server" Text="Cliente"></asp:Label>
                <asp:DropDownList ID="ddlCliente" runat="server"></asp:DropDownList>

                &nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                <br />
                &nbsp;
        
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="salvar_Click" />
                <br />
                <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
