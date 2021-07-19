<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Vistas.Registrarse" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <div class="container ">   
        <div class="row justify-content-center">   
        <div class="card text-center" style="width: 30rem;">
            <div class="card-header" style="background-color:white "> 
             
                <img src="https://media.istockphoto.com/vectors/sign-up-icon-in-flat-style-finger-cursor-vector-illustration-on-white-vector-id1140065786?k=6&m=1140065786&s=612x612&w=0&h=_q0iXR2XGsBTIKV9jI1oW2lphjCc04aTzuy0pn1y_3I=" class="w-50"  alt="Alternate Text" />
            </div>
  <div class="card-body">
     <asp:TextBox runat="server" placeholder="Correo electronico" class="form-control" id="txtcorreo"/> 
     <asp:TextBox runat="server" placeholder="Contraseña" class="form-control" id="txtcontraseña" />    
      <asp:TextBox runat="server" placeholder="Confirmar Contraseña" class="form-control" id="txtConfirma" />  
      <div class="card-footer" style="background-color:white ">
      <asp:Button ID="Btniniciar" type="button" CssClass="btn btn-outline-primary mt-3" runat="server" Text="Registrar Cuenta" OnClick="Registrar_Click"  /> 

                    <%if (error == "error")
                  { %>
          
            <div class="alert alert-danger mt-3" role="alert">
             Cuenta Existente!
            </div>
  
          <% }
            else if (error == "no")
            {%>
            <div class="alert alert-danger mt-3" role="alert">
             Las contraseñas no coinciden!
            </div>

            <%}
              %>


      </div> 
  </div>
</div>

</div>


    </div>
</asp:Content>
