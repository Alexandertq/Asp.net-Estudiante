<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorListar.aspx.cs" Inherits="UI.TutorListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3>¡Tutor - Listar!</h3>
    </div> 

    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Index</asp:HyperLink> | 
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/TutorRegistrar.aspx">Registrar</asp:HyperLink> | 
        ID: <asp:TextBox ID="txtID" runat="server" Width="60px"></asp:TextBox> 
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    </div> <br />

    <div>
        <asp:GridView ID="gvTutor" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="550px" AllowPaging="True" OnPageIndexChanging="gvTutores_PageIndexChanging" PageSize="8">
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
