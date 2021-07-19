using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using System.Data.SqlTypes;


namespace Vistas
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<ArticuloXcarrito> Lista = new List<ArticuloXcarrito>();
        public SqlMoney total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           
           
            Lista = (List<ArticuloXcarrito>)Session[Session.SessionID + "Lista"];





        }
    }
}