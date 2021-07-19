<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ABML_PRODUCTO.aspx.cs" Inherits="Vistas.ABML_PRODUCTO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

          <div class="container mt-4">




        <div class="row align-items-center">






            <div class="d-grid gap-2">
                <a href="AGREGAR_PRODUCTO.aspx" class="btn btn-outline-success mb-5" type="button">AGREGAR PRODUCTO</a>
            </div>

            <div class="col-12">
                <table class="table" id="jose">
                    <thead>
                        <tr>
                            <th scope="col">ID</th>
                            <th style="width: 100px">Imagen</th>
                            <th>Nombre</th>
                            <th scope="col">Descripcion</th>
                            <th scope="col">Precio</th>
                        </tr>
                    </thead>
                    <tbody>
                        <% foreach (Dominio.Producto item in lista)
                            {
                        %>

                            
                           
                        <tr>
                            <th scope="row"><%=item.Id %></th>
                            <td>
                                <img src="<%=item.UrlImagen %>" height="50" width="50" /></td>
                            <td><%=item.Nombre %></td>
                            <td>
                                <p><%=item.Descripion %></p>
                            </td>
                            <td>
                                <p>$<%=item.Precio %></p>
                            </td>
                            <td><a href="ABML_Modificar.aspx?id=<% = item.Id %>" class="btn btn-outline-secondary  btn-sm">MODIFICAR</a></td>
                            <%if (item.estado == false) {%><td><a href="ABML_PRODUCTO.aspx?ACTIVAR=<% = item.Id.ToString() %>" class="btn btn-outline-success  btn-sm">ACTIVAR</a></td><%} %>
                            <%else{ %><td><a href="ABML_PRODUCTO.aspx?SUSPENDER=<% = item.Id.ToString() %>" class="btn btn-outline-secondary  btn-sm">SUSPENDER</a></td><%} %>
                            <td><a href="ABML_PRODUCTO.aspx?ELIMINAR=<% = item.Id.ToString() %>" class="btn btn-outline-danger  btn-sm">ELIMINAR</a></td>

                        </tr>
                             

                        <%} %> 
                    </tbody> 
                </table>


            </div>





        </div>
   

 </div>
   
</asp:Content>


<%--     <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/bs5/jq-3.3.1/dt-1.10.25/r-2.2.9/datatables.min.css"/>
    <script type="text/javascript" src="https://cdn.datatables.net/v/bs5/jq-3.3.1/dt-1.10.25/r-2.2.9/datatables.min.js"></script>

    <script>
        $(document).ready(function () {
            $('#table_id').DataTable();
        });
    </script>
    
    <table id="table_id" class="table">
  <thead>
    <tr>
      <th><i class="fas fa-university" style="color:red;"></i> CBU</th>
      <th><i class="fas fa-file-invoice" style="color:red;"></i> Tipo de Movimiento</th>
      <th><i class="fas fa-info-circle" style="color:red;"></i> Detalle</th>
      <th><i class="fas fa-calendar-alt" style="color:red;"></i> Fecha</th>
    </tr>
  </thead>
  <tbody>
    <% foreach (Dominio.Producto item in lista)
                            {
                        %>



        <tr>
      <td><%=item.Nombre %></td>
      <td><%=item.Nombre %></td>
      <td><%=item.Nombre %> </td>
      <td><%=item.Nombre %></td>
    </tr>


        <%} %> 
  </tbody>
</table>--%>