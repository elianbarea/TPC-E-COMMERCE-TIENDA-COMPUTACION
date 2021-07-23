<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Confirmar_compra.aspx.cs" Inherits="Vistas.Confirmar_compra" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <table class="table table-dark table-striped">
            <thead>
                <tr>
                    <th scope="col">Nombre Del Producto</th>
                    <th scope="col">producto</th>
                    <th scope="col">cantidad</th>
                    <th scope="col">sub_total</th>
                    


                </tr>
            </thead>
            <%foreach (Dominio.ArticuloXcarrito item in Lista)
                { %>
            <tbody>
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
                     
                        <% total += item.sub_total;
                            %> 
                        
                     
            </tbody>
            <%} %>
        </table>

        <table class="table table-dark table-striped">
            <thead>
                <tr>
                    <th scope="col">Nombre</th>
                    <th scope="col">Dni</th>
                    <th scope="col">Email</th>
                    <th scope="col">Direccio</th>
                    <th scope="col">Tarjeta de credito</th>
                    <th scope="col">Total</th>


                </tr>
            </thead>
            <tbody>
                <tr>

                    <td><% = datosUsuario.NOMBRE %></td>
                    <td><% = datosUsuario.DNI %></td>
                    <td><% = datosUsuario.MAIL %></td>
                    <td><% = datosUsuario.Direccion %></td>
                    <td></td>
                    <td>$ <%=total %></td>


                </tr>
            </tbody>
        </table>
        <div class="text-center">
            <asp:Button Text="CONFIRMAR COMPRA" class="btn btn-outline-success" runat="server" />
        </div>
    </div>
</asp:Content>
