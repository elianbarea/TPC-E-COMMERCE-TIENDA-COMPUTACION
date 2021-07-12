<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Vistas.Carrito" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="padre">
        <div class="container">
  <div class="row">
    <div class="col-6">
      PRODUCTO
    </div>
      <div class="col">
          CANTIDAD
      </div>
      <div class="col">
          PRECIO
      </div>
  </div>
        </div>

        <div class="container">
            <div class="row justify-content-start">
                <div class="col-1">
                    <a href="#">
                        <asp:Button Text="Eliminar" Class="btn  btn-outline-danger" style="color:black" runat="server" /> </a>
                </div>
            </div>
        </div>
        <hr>

                <div class="container">
            <div class="row justify-content-end">
                <div class="col-4">
                    <p>ENVIO : $500.00</p> 
                    <p>Total con envio : $0.00</p>

                </div>
            </div>
        </div>
                <hr>
                        <div class="container">
            <div class="row justify-content-end">
                <div class="col-4">
        <a href="#" > <asp:Button Text="Continuar compra" Class="btn  btn-outline-warning" style="color:black" runat="server" /> </a>

                </div>
            </div>
        </div>



             
    </div>



</asp:Content>
