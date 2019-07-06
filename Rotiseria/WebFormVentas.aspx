<%@ Page Title="" Language="C#" MasterPageFile="~/layout.Master" AutoEventWireup="true" CodeBehind="WebFormVentas.aspx.cs" Inherits="Rotiseria.WebFormVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
