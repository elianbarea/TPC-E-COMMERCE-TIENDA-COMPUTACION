 <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ABML_CATEGORIA.aspx.cs" Inherits="Vistas.ABML_CATEGORIA" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


            <asp:UpdatePanel runat="server">
                <ContentTemplate>
    <div class="container mt-4">
        <div class="row align-items-center">

            <div class="d-grid gap-2">
             <label for="exampleFormControlInput1" class="form-label"></label>
             <asp:TextBox runat="server" placeholder="Nombre" class="form-control " id="txtnombre" />  
                <asp:Button Text="AGREGAR CATEGORIA" class="mb-4 "  runat="server" OnClick="Unnamed1_Click" />
            </div>

                        <div class="col-12">
                <table class="table">
                    <thead>
                        <tr>
                            <th scope="col">ID</th>
                            <th>Nombre</th>
                            <th scope="col">Acciones</th>
                        </tr>
                    </thead>
                    <tbody>

                    <asp:Repeater runat="server" ID="REPETIDOR">
                        <ItemTemplate>




 

                        <tr>
                            <th scope="row"><%#Eval ("IDcategoria") %></th>
                            <td> <%#Eval ("Nombre") %>  </td>
                            <td><a href="Modificar_Categoria.aspx?id=<%#Eval ("IDcategoria") %>" class="btn btn-outline-secondary  btn-sm">MODIFICAR</a> <a href="ABML_CATEGORIA.aspx?ELIMINAR=<%#Eval("IDcategoria").ToString() %>" class="btn btn-outline-danger  btn-sm">ELIMINAR</a></td>





                        </ItemTemplate>
                    </asp:Repeater>
                    </tbody>
                </table>


            </div>

            </div>
            </div>
                </ContentTemplate>
            </asp:UpdatePanel>





           

</asp:Content>
