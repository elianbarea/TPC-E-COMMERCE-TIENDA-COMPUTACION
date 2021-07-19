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
    public partial class Iniciar_Sesion : System.Web.UI.Page
    {
        public AccesoDatos datos = new AccesoDatos();
        public string error;
        protected void Page_Load(object sender, EventArgs e)
        {

           error =  Convert.ToString(Request.QueryString["key"]);

        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {
            PersonaNegocio persona = new PersonaNegocio();

            Usuario usuario = new Usuario() ;
            

            usuario.Mail = txtMail.Text;
            usuario.Contraseña = TxtContrasenia.Text;

           usuario = persona.Verificar_Cuenta(usuario);

            
                

            if (usuario.Mail != null) {

                Session.Add(Session.SessionID + "Usuario_Sesion", usuario);
                Response.Redirect("Productos.aspx");
            }


            else {

                error = "error"; }

            
        }
    }
}