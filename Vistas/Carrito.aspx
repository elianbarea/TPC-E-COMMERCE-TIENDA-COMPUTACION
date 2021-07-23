<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Vistas.Carrito" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


     <div class="container mt-4">




        <div class="row align-items-center">








            <div class="col-12">
                <table class="table" id="jose">
                    <thead>
                        <tr>
                            <th scope="col">PRODUCTO</th>
                            <th style="width: 100px">IMAGEN</th>

                            <th scope="col">CANTIDAD</th>
                            <th scope="col">PRECIO</th>
                        </tr>
                    </thead>
                    <tbody>
                        <%if (Lista != null)
                            { %>
                        <% foreach (Dominio.ArticuloXcarrito item in Lista)
                            {
                        %>

                           
                           
                        <tr>
                            <th scope="row"><%=item.producto.Nombre %></th>
                            <td>
                                <img src="<%=item.producto.UrlImagen %>" height="50" width="50" /></td>
                           
                            <td>
                                <p><%=item.Cantidad %></p>
                            </td>
                            <td>
                                <p>$<%=item.sub_total %></p>
                            </td>
                         

                        </tr>
                        <%total += item.sub_total;
                            } %> 
                        
                       <tr> 
                         <th scope="col">Detalles</th>
                         <td class="text-center"> 
                             Total : $<%= total %>
                         </td>    
                            
                            <td>
                                    <a href="Formulario.aspx" class="btn btn-outline-success mb-5" type="button">CONTINUAR CON LA COMPRA</a>
                            </td>

                       </tr>
                        <%} %>
                        <%else{ %>
                                                   
                       

                        <%} %>
                    </tbody> 
                 
                </table>

            </div>





        </div>
   

 </div>



</asp:Content>
