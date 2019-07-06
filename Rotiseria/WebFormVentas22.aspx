<% Rotiseria.Controllers.MVCLlamarVista.RenderAction("Home", "About", new { }); %><%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormVentas22.aspx.cs" Inherits="Rotiseria.WebFormVentas" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Probando WEbForms</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Label ID="lblTitulo" runat="server" ></asp:Label>
            </h1>
            <p>
                <asp:Label ID="Label4" runat="server" Text="Nro Venta"></asp:Label>
                <asp:TextBox ID="txtNroVenta" runat="server" OnTextChanged="txtNroVenta_TextChanged" AutoPostBack="True"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
                <asp:DropDownList ID="ddlusuario" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Fecha"></asp:Label>
                <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Total"></asp:Label>
                <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
            </p>
        </div>
    </form>
</body>
</html>
