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
    public partial class ABML_PRODUCTO : System.Web.UI.Page
    {
        public List<Producto> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio nego = new ProductoNegocio();
            lista = nego.listar();

            var ID1 = Request.QueryString["ELIMINAR"];
            if (ID1 != null) 
            {
                nego.eliminar_producto("delete from Articulos where ID =" + ID1);
                lista = nego.listar();
            }

            var ID2 = Request.QueryString["SUSPENDER"];
            if (ID2 != null) {
                nego.eliminar_producto("update Articulos set Estado = 0 where ID =" + ID2);
                lista = nego.listar();
            }

            var ID3 = Request.QueryString["ACTIVAR"];
            if (ID3 != null) {
                nego.eliminar_producto("update Articulos set Estado = 1 where ID =" + ID3);
                lista = nego.listar();
            }







        }
    }
}