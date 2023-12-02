<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorEditar.aspx.cs" Inherits="UI.TutorEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div>
        <h3>Tutor - Editar</h3>
    </div> <br />

    <div>
        <table style="width: 100%;">
            <tr>
                <td class="text-right" style="width: 181px; height: 22px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tutor ID:</td>
                <td class="modal-sm" style="width: 247px; height: 22px;">
                    <asp:TextBox ID="txtID" runat="server" Width="161px" ReadOnly="true"></asp:TextBox>
                </td>
                <td style="height: 22px"></td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Nombre:</td>
                <td style="width: 247px; height: 37px">
                    <asp:TextBox ID="txtNombre" runat="server" Width="158px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="¡Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td style="height: 37px">
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Relación</td>
                <td style="width: 247px; height: 37px">
                    <asp:TextBox ID="txtRelacion" runat="server" Width="161px"></asp:TextBox>
                </td>
                <td style="height: 37px">
                    <asp:RequiredFieldValidator ID="rfvRelacion" runat="server" ControlToValidate="txtNombre" ErrorMessage="¡Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td style="height: 34px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="text-center" style="width: 213px; height: 78px"></td>
                <td style="height: 78px; width: 247px">
                    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" Width="84px" />
                    <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click"/>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />
                </td>
                <td style="height: 78px"></td>
            </tr>
        </table>
    </div>
</asp:Content>
