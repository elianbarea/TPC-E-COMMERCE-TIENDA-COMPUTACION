<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Vistas.Detalle" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Producto seleccionado</h1>


     
        <div class="container">
        <!--CONTENEDOR DE PRODUCTOS -->
        <div class="row align-items-center">



                            <div class="col-7">
                <div class="card mt-4">
                    <img src="<% = producto.UrlImagen %>" alt="Alternate Text" />
                    <div class="card-body">
                        
                        
                    </div>
                </div>
            </div>

     
    
              <div class="col"  >
                <div class="card mt-3">
                    <div class="card-body" style="height: 500px">
                        <h3><% = producto.Nombre %></h3>
                     

                        <p>  <%= producto.Marca %></p>
                        <p><% = producto.Precio %></p>
                        
                            <button class="btn-danger"> 
                                <a class="nav-link fs-7" style="color:black;" href="#">
                                 Agregar a carrito</a>
                                 </button>
                       
                        
                    </div>
                </div>
            </div>

                            <hr>
                        <div class="container">
            <div class="row justify-content-center">
                <div class="col-4">
           <p><%= producto.Descripion %></p>
                </div>
            </div>
        </div>
</div>
                           
                             

                 

            
            

</asp:Content>
