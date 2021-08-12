<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Vistas.Formulario" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <% if(Cargados ==0) {%>
    <h3 class="text-center">RELLENE LOS CAMPOS CON SUS DATOS</h3>

              <div class="container">
<div class="row  d-block">

<div class="col"><div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label"></label>
       <asp:TextBox runat="server" placeholder="Nombre Completo" class="form-control" id="txtNombre" />  
</div>
</div>
<div class="col"><div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label"></label>
       <asp:TextBox runat="server" placeholder="DNI" class="form-control" id="txtDNI" />  
</div>
</div>
<div class="col"><div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label"></label>
       <asp:TextBox runat="server" placeholder="Mail" class="form-control" id="txtMail" />  
</div>
</div>
<div class="col"><div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label"></label>
       <asp:TextBox runat="server" placeholder="Telefono"  class="form-control" id="txtTelef" />  
</div>
</div>
    <div class="col"><div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label"></label>
       <asp:TextBox runat="server" placeholder="Direccion"  class="form-control" id="TextDirec" />  
</div>
</div><% }%>
    <%if (Cargados == 1)
        { %>
        <h3 class="text-center">RELLENE LOS CAMPOS DE PAGO</h3><%} %>

              <div class="col; mt-2" ><div class="mb-3">Tarjeta de credito
              <asp:DropDownList  ID="DropDownList1"   runat="server" class="form-control" >
                  <asp:ListItem>VISA</asp:ListItem>
                  <asp:ListItem>MASTER CARD</asp:ListItem>
                  <asp:ListItem>PATAGONIA</asp:ListItem>
                  </asp:DropDownList>
</div>
    </div>
        <div class="col"><div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label"></label>
       <asp:TextBox runat="server" placeholder="Numero de la tarjeta"  class="form-control" id="TextBox1" />  
</div>
</div>
        <div class="col"><div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label"></label>
       <asp:TextBox runat="server" placeholder="Clave"  class="form-control" id="TextBox2" />  
</div>
</div>
        <div class="col"><div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label"></label>
       <asp:TextBox runat="server" placeholder="Nombre que figura en la Tarjeta"  class="form-control" id="TextBox3" />  
</div>
</div>

  </div>

<div class="d-grid gap-2; mt-3">
       <asp:Button Text="CONTINUAR CON LA COMPRA"  class="btn btn-outline-secondary mb-5" runat="server" OnClick="Registrar_Compra_Click"  />

            </div>

</div>      
   


</asp:Content>
