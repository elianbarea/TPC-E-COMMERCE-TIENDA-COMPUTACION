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
    public partial class SiteMaster : MasterPage
    {
   
        public Usuario usu = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            usu.Tipo = 3;


             int ID1 = Convert.ToInt32 (Request.QueryString["SALIR"]);
            if (ID1 == 1) {
                Session[Session.SessionID + "Usuario_Sesion"] = null;
            }

            if (Session[Session.SessionID + "Usuario_Sesion"] != null) {
                usu = (Usuario)Session[Session.SessionID + "Usuario_Sesion"];
            }


        }
    }
}