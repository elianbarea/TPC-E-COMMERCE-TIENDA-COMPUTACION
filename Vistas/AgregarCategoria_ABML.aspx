<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarCategoria_ABML.aspx.cs" Inherits="Vistas.AgregarMarca_ABML" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="container"> 
    <div style="text-align:center;width:100%;height:100%">
<div style="justify-content:center;" >
    <h3>Nombre de la categoria</h3>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <table>
        <tr>
            <th> <asp:Button ID="txTagregar" runat="server" Text="AGREGAR" OnClick="txTagregar_Click" /></th>
            <th><a href="ABML_CATEGORIA.aspx" class="btn btn-outline-secondary  btn-sm" id="btnvolver">VOLVER</a></th>
           </tr>
    </table>

     
</div>
        </div>
</div>  

</asp:Content>
