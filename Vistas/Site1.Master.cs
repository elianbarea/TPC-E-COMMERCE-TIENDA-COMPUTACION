using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;


namespace Vistas
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        AccesoDatos datos = new AccesoDatos();
        public Usuario usu = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            usu.Tipo = 3;

            if (Session[Session.SessionID + "Usuario_Sesion"] != null) {
                usu = (Usuario)Session[Session.SessionID + "Usuario_Sesion"];
            }
            



        }
    }
}

