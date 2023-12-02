<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstutList_xTutor.aspx.cs" Inherits="UI.EstutList_xTutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h3>¡Listar Libros x Genero!</h3>
    </div>

    <div style="padding-top:10px;">
        Seleccione: <asp:DropDownList ID="ddlTutor" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTutor_SelectedIndexChanged"></asp:DropDownList>
    </div>

    <div style="padding-top:10px;">
        <asp:GridView ID="gvEstudiante" runat="server" AllowPaging="True" CellPadding="4" OnPageIndexChanging="gvEstudiante_PageIndexChanging" PageSize="8" Width="910px" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
    </div>

</asp:Content>
