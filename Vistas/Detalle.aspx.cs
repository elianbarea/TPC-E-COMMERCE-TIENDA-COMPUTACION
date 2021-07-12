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
    public partial class Detalle : System.Web.UI.Page
    {
        public Producto producto;

        protected void Page_Load(object sender, EventArgs e) 
       {
            ProductoNegocio negocio = new ProductoNegocio ();
            int id = int.Parse(Request.QueryString["id"]);

            List<Producto> lista = new List<Producto>();
            lista = negocio.listar();
            producto = lista.Find(x => x.Id == id);
       
       }


            
   }
}
