<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Vistas.Registrarse" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container"> 
    <div style="text-align:center;width:100%;height:100%">
<div style="justify-content:center;" >

      <h5 style="">Nombre de usuario</h5>
    <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            
       <h5 style="">Correo electronico</h5>
    <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
            
       <h5 style="">Direccion</h5>
    <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
           
       <h5 style="">Numero de telefono</h5>
    <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
           
            <h5 style="">Contraseña</h5>
    
            
    <br />
    <asp:TextBox ID="txtcontraseña" runat="server"></asp:TextBox>
            <br />
    <asp:Button class="mb-4; btn-dark" ID="Btniniciar" runat="server" Text="Registrarse" OnClick="Btniniciar_Click" />
         
            

</div>
        </div>
</div>  
</asp:Content>
