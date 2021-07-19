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
        public    List<ArticuloXcarrito> lista = new List<ArticuloXcarrito>();
        public    ArticuloXcarrito Articulo = new ArticuloXcarrito();
        protected void Page_Load(object sender, EventArgs e) 
       {
            ProductoNegocio negocio = new ProductoNegocio ();
            int id = int.Parse(Request.QueryString["id"]);

            List<Producto> lista = new List<Producto>();
            lista = negocio.listar();
            producto = lista.Find(x => x.Id == id);
       
       }

        protected void CargarSesion_Click(object sender, EventArgs e)
        {


            Articulo.IDcarrito = 0;
            Articulo.Cantidad = Convert.ToInt32(txtCantidad.Text);
            Articulo.producto = producto;
            Articulo.sub_total = producto.Precio * Articulo.Cantidad;

            bool validar = new bool();

            if (Session[Session.SessionID + "Lista"] != null) {
                lista = (List<ArticuloXcarrito>)Session[Session.SessionID + "Lista"];
            }

            foreach (var arti in lista) {
                if (arti.producto.Id == Articulo.producto.Id) {

                    arti.Cantidad += Articulo.Cantidad;
                    arti.sub_total += Articulo.sub_total;
                    lista.Remove(arti);

                    lista.Add(arti);
                    Session[Session.SessionID + "Lista"] = lista;
                    Response.Redirect("Carrito.aspx");

                    validar = true;
                }
                else {
                    validar = false;
                }


            }

            if (validar == false) {
                lista.Add(Articulo);
                Session[Session.SessionID + "Lista"] = lista ;
                Response.Redirect("Carrito.aspx");

            }


        }


    }
}
