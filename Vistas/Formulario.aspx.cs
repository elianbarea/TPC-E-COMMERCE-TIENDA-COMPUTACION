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
    public partial class Formulario : System.Web.UI.Page
    {
        public Usuario usu = new Usuario();
        public List<DatosUsuario> lista = new List<DatosUsuario>();
        public PersonaNegocio personas = new PersonaNegocio();
        public DatosUsuario usuario ;
        public int Cargados= 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           usu = (Usuario)Session[Session.SessionID + "Usuario_Sesion"];

           lista = personas.listar_Datos();
           usuario = lista.Find(i => i.MAIL == usu.Mail);
           if(usuario != null) {

                Cargados++;

            }


        }

        protected void Registrar_Compra_Click(object sender, EventArgs e)
        {
            PersonaNegocio persona = new PersonaNegocio();
            Usuario verificarmail = new Usuario();
            Usuario usuarioaux = new Usuario();
            DatosUsuario usuario = new DatosUsuario();

           


            if(Cargados == 0) { 
        verificarmail.Mail = txtMail.Text;

            usuarioaux = persona.Verificar_Mail(verificarmail);


            usuario.DNI = txtDNI.Text;
            usuario.MAIL = txtMail.Text;
            usuario.NOMBRE = txtNombre.Text;
            usuario.Direccion = TextDirec.Text;
            usuario.Telefono = txtTelef.Text;

            if (usuarioaux.Mail != null) {

                    persona.agregar_Detalles_Usuario(usuario);

                Response.Redirect("Confirmar_compra.aspx");

            }
}
            Response.Redirect("Confirmar_compra.aspx");
        }
    }
}