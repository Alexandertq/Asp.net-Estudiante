<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorRegistrar.aspx.cs" Inherits="UI.TutorRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3>Tutor - Registrar</h3>
    </div> <br />

    <div>
        <table style="width: 100%;">
            <tr>
                <td class="text-center" style="width: 213px; height: 37px">Nombre:</td>
                <td style="width: 178px; height: 37px">
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
                <td style="width: 178px; height: 37px">
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
                <td style="height: 78px; width: 178px">
                    <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" Width="84px" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />
                </td>
                <td style="height: 78px"></td>
            </tr>
        </table>
    </div>
</asp:Content>
