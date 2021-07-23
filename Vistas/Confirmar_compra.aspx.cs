using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data.SqlTypes;

namespace Vistas
{
    public partial class Confirmar_compra : System.Web.UI.Page
    {
        public List<ArticuloXcarrito> Lista = new List<ArticuloXcarrito>();
        public Usuario usu = new Usuario();
        public PersonaNegocio per = new PersonaNegocio();
        public DatosUsuario datosUsuario = new DatosUsuario();
        public SqlMoney total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Lista = (List<ArticuloXcarrito>)Session[Session.SessionID + "Lista"];
            usu = (Usuario)Session[Session.SessionID + "Usuario_Sesion"];


           datosUsuario =  per.Buscarpersona(usu);
            


        }
    }
}