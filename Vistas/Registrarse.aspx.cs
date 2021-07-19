using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Vistas
{
    public partial class Registrarse : System.Web.UI.Page
    {
        public AccesoDatos datos = new AccesoDatos();
        public string error;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Registrar_Click(object sender, EventArgs e)
        {
            PersonaNegocio persona = new PersonaNegocio();
            string confirma = "confirma";
            Usuario usuario = new Usuario();
            Usuario usuarioaux = new Usuario();

            usuario.Mail = txtcorreo.Text;
            usuario.Contraseña = txtcontraseña.Text;
         
            usuarioaux = persona.Verificar_Mail(usuario);

            if (usuarioaux.Mail == null) {
            usuarioaux.Contraseña = txtConfirma.Text;
                if (usuario.Contraseña == usuarioaux.Contraseña) { 

                persona.agregar_Persona(usuario);
            
                Response.Redirect("Iniciar Sesion.aspx?key="+ confirma);
                }
                else {

                    error = "no";
                }
            }


            else {

                error = "error";
            }



        }
    }
}