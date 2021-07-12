<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Vistas.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel runat="server">
        <ContentTemplate>



     <div class="container text-center mt-4">
            <i class="fas fa-search  fa-x2 mt-5"></i> <asp:TextBox ID="txtbuscar" runat="server"  /> 
    <asp:Button class="btn btn-group-sm btn-primary" Text="btnBuscar" runat="server" OnClick="Buscar_Click" />

    <div class="row ">
        <asp:Repeater runat="server" ID="repetidor">
            <ItemTemplate>

   <div class="col-4 mt-3 d-flex align-items-stretch">
     
   <div class="card" style="width: 18rem;">
       <div class="card-header text-center"> <img src="<%#Eval("UrlImagen") %>"  class=" w-50 " /> </div>
  <div class="card-body ">

    <h5 class="card-title"><%#Eval("Nombre") %></p></h5>
    <p class="card-text"><%#Eval("Descripion") %></p></p>
      <p class="card-text">$<%#Eval("Precio") %></p></p>

  </div>      
    <div class="card-footer text-center">
    <a href="Detalle.aspx?id=<%#Eval ("Id") %>" class="btn btn-primary">Ver producto</a>
    </div>
</div>
         
    </div>

            </ItemTemplate>
        </asp:Repeater>


     
       

     
      </div>
         </div>   


        </ContentTemplate>
    </asp:UpdatePanel>



</asp:Content>


