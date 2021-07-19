<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Iniciar Sesion.aspx.cs" Inherits="Vistas.Iniciar_Sesion" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server" >
    <div class="container ">   
        <div class="row justify-content-center">   
        <div class="card text-center" style="width: 30rem;">
            <div class="card-header" style="background-color:white "> 
                <h5>    INICIO DE SESION</h5>
                <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqvCfpcjuk5yw-VMg_4TffqyY_eaxx9t3p62HkUCREuAKGV5IR8Oqdx_i6940Xpl_q9ew&usqp=CAU" alt="Alternate Text" />
            </div>
  <div class="card-body">
     <asp:TextBox runat="server" placeholder="Correo electronico" class="form-control" id="txtMail"/> 
     <asp:TextBox runat="server" placeholder="Contraseña" class="form-control" id="TxtContrasenia" />    
      <div class="card-footer" style="background-color:white ">
      <asp:Button ID="Btniniciar" type="button" CssClass="btn btn-outline-primary mt-3" runat="server" Text="Iniciar Sesion" OnClick="Iniciar_Click" /> 
      <asp:Button  type="button" CssClass="btn btn-outline-primary mt-3" runat="server" Text="Registrate"  /> 


               
          <%if (error == "error")
              { %>
          
            <div class="alert alert-danger mt-3" role="alert">
             Mail o Contraseña incorrectos!
            </div>
  
          <% }%>

          <% else if (error== "confirma")
    {  %>
          
            <div class="alert alert-success mt-3" role="alert">
             Creada con exito!
            </div>
          
          <%} %>

      </div> 
  </div>
</div>

</div>


    </div>


         
         
</asp:Content>
