<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstudianteRegistrar.aspx.cs" Inherits="UI.EstudianteRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3>¡Estudiante - Registrar</h3>
    </div> <br />

    <div>
        <table style="width: 100%; height: 172px;">
            <tr>
                <td class="text-right" style="width: 181px; height: 34px;"><strong>Nombre:&nbsp;</strong></td>
                <td class="modal-sm" style="width: 202px; height: 34px;">
                    <asp:TextBox ID="txtNombre" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td style="height: 34px">
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="¡Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-right" style="width: 181px; height: 11px"><strong>Apellido:&nbsp;</strong></td>
                <td class="modal-sm" style="height: 11px; width: 202px">
                    <asp:TextBox ID="txtApellido" runat="server" Width="161px"></asp:TextBox>
                </td>
                <td style="height: 11px">
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="¡Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-right" style="width: 181px; height: 34px;"><strong>Fecha de nacimiento:&nbsp;</strong></td>
                <td class="modal-sm" style="width: 202px; height: 34px;">
                    <asp:TextBox ID="txtFechaNacimiento" runat="server" Width="161px"></asp:TextBox>
                </td>
                <td style="height: 34px">
                    <asp:RequiredFieldValidator ID="rfvFnacimiento" runat="server" ControlToValidate="txtFechaNacimiento" Display="Dynamic" ErrorMessage="¡Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvFnacimiento" runat="server" ControlToValidate="txtFechaNacimiento" Display="Dynamic" ErrorMessage="¡Formato incorrecto!" ForeColor="Red" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="text-right" style="width: 181px; height: 34px;">D<strong>irección:&nbsp;</strong></td>
                <td class="modal-sm" style="width: 202px; height: 34px;">
                    <asp:TextBox ID="txtDireccion" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td style="height: 34px">
                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="¡Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-right" style="width: 181px; height: 11px">E-<strong>mail:&nbsp;</strong></td>
                <td class="modal-sm" style="height: 11px; width: 202px">
                    <asp:TextBox ID="txtEmail" runat="server" Width="161px"></asp:TextBox>
                </td>
                <td style="height: 11px">
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="¡Campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="text-right" style="width: 181px">T<strong>utor:&nbsp;</strong></td>
                <td class="modal-sm" style="width: 202px">
                    <asp:DropDownList ID="ddlTutor" runat="server" Height="25px" Width="161px">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td style="width: 181px">&nbsp;</td>
                <td class="modal-sm" style="width: 202px">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>
