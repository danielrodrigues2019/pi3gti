<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarCarne.aspx.cs" Inherits="Paginas_Carne_CadastrarCarne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastrar Carnê</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="margin-left: 40px">
                
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblcliente" runat="server" Text="Selecione o Cliente"></asp:Label>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlCliente" runat="server" data-live-search="true">
                </asp:DropDownList>
                <br />
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblData" runat="server" Text="Data:"></asp:Label>
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtData" runat="server" TextMode="Date"></asp:TextBox>
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblValor" runat="server" Text="Valor da Parcela"></asp:Label>
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNumeroParcelas" runat="server" Text="Número de Parcelas: "></asp:Label>
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNparcelas" runat="server"></asp:TextBox>
                <br />
                <br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;
                
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="salvar_Click" />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>
        </div>
    </form>
</body>
</html>
