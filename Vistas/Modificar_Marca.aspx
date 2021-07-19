<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Modificar_Marca.aspx.cs" Inherits="Vistas.Modificar_Marca" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    
         <div class="container">
<div class="row row-cols-1 row-cols-sm-2 row-cols-md-4">

          <div class="col; mt-2" ><div class="mb-3">Marca
              <asp:DropDownList  ID="Modificar_nombre"   runat="server" class="form-control" ></asp:DropDownList>
</div>
    </div>

    <div class="d-grid gap-2; mt-3">
       <asp:Button Text="MODIFICAR MARCA" class="btn btn-outline-success mb-5" runat="server" OnClick="Modificar_Click" />
            </div>
</div>

        </div>

</asp:Content>
