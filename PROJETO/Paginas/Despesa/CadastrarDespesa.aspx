<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarDespesa.aspx.cs" Inherits="Paginas_Despesa_CadastrarDespesa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="descricao" runat="server" Text="Descrição"></asp:Label>
            &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="valor" runat="server" Text="Valor"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="datavencimento" runat="server" Text="Data de Vencimento"></asp:Label>
            &nbsp;
        <asp:TextBox ID="txtDataVencimento" runat="server"></asp:TextBox>
            <br />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:DropDownList ID="ddlstatus" runat="server" DataTextField="Status" DataTextFormatString="Status"></asp:DropDownList>
            &nbsp;&nbsp;
                   <br />
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="salvar_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
