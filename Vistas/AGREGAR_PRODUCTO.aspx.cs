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
    public partial class AGREGAR_PRODUCTO : System.Web.UI.Page
    {
        public Producto producto;
        public List<Marca> marca;
        public List<Categoria> categorias;
        public MarcaNegocio marcanegocio = new MarcaNegocio();
        public CategoriaNegocio catego = new CategoriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                ProductoNegocio nego = new ProductoNegocio();



                if (!IsPostBack) {




                    marca = marcanegocio.listar_marca();
                    DropDownList3.DataSource = marca;
                    DropDownList3.DataBind();

                    categorias = catego.listar_Categoria();
                    DropDownList4.DataSource = categorias;
                    DropDownList4.DataBind();
                }

            }
            catch (Exception) {

                Response.Redirect("ERROR-aspx");
            }



        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ProductoNegocio productomodificado = new ProductoNegocio();


            Producto AGREGAR = new Producto();
            marca = marcanegocio.listar_marca();
            categorias = catego.listar_Categoria();




            var id = Request.QueryString["id"];


            if (id != null) {
                AGREGAR.Id = Convert.ToInt32(id);
                AGREGAR.Nombre = txtnombre.Text;
                AGREGAR.Descripion = txtDesc.Text;
                AGREGAR.estado = true;                
                AGREGAR.Precio = Convert.ToDecimal(txtPrecio.Text);
                AGREGAR.stock = int.Parse(txtStock.Text);
                AGREGAR.Marca = marca.Find(c => c.Nombre == DropDownList3.SelectedValue);
                AGREGAR.Categoria = categorias.Find(h => h.Nombre == DropDownList4.SelectedValue);
                AGREGAR.UrlImagen = txtURL.Text;

                productomodificado.agregar_producto(AGREGAR);
            }
            Response.Redirect("ABML_PRODUCTO");
        }
    }
}