<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstudianteListar.aspx.cs" Inherits="UI.EstudianteListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3>¡Autores - Listar!</h3>
    </div> 

    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Index</asp:HyperLink> | 
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/EstudianteRegistrar.aspx">Registrar</asp:HyperLink> | 
        ID: <asp:TextBox ID="txtID" runat="server" Width="60px"></asp:TextBox> 
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    </div> <br />

    <div>
        <asp:GridView ID="gvEstudiante" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="901px" AllowPaging="True" OnPageIndexChanging="gvEstudiantes_PageIndexChanging" PageSize="8">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </div>
</asp:Content>
