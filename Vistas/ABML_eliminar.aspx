<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ABML_eliminar.aspx.cs" Inherits="Vistas.ABML_eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Una vez eliminado no se podra recuperar ¿Desea eliminar este elemento? </h2>
   <table>
       <tr>
       <th><asp:Button ID="btnEliminar" OnClick="btnEliminar_Click" runat="server" Text="Eliminar"  /></th>
           <th>
               <asp:Button ID="btnCancelar" OnClick ="btnCancelar_Click"  runat="server" Text="Cancelar" /></th>
       </tr>
</table>
</asp:Content>
