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
    public partial class ABML_Modificar : System.Web.UI.Page
    {
        public Producto producto ;
        public List<Marca> marca;
        public List<Categoria> categorias;
        public MarcaNegocio marcanegocio = new MarcaNegocio();
        public CategoriaNegocio catego = new CategoriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                ProductoNegocio nego = new ProductoNegocio();
                
               
                int indexcatego;
                int indexmarca;

                int id = int.Parse (Request.QueryString["id"]);

                ///cargamos lista
                List<Producto> lista = new List<Producto>();
                lista = nego.listar();
                producto = lista.Find( i=> i.Id == id);
                ///

                if(!IsPostBack) { 

                // rellena los campos de txt
                txtnombre.Text = producto.Nombre;
                txtDesc.Text = producto.Descripion;
                txtPrecio.Text = Convert.ToString(producto.Precio);
                txtStock.Text = Convert.ToString(producto.stock);
                txtURL.Text = producto.UrlImagen;
                    ///

                 

                marca = marcanegocio.listar_marca();
                 indexmarca= marca.FindIndex(x => x.IDmarca == producto.Marca.IDmarca );
                DropDownList1.DataSource = marca;
                DropDownList1.SelectedIndex = indexmarca;
                DropDownList1.DataBind();

                categorias = catego.listar_Categoria();
                indexcatego = categorias.FindIndex(d => d.IDcategoria == producto.Categoria.IDcategoria);
                DropDownList2.DataSource = categorias;
                DropDownList2.SelectedIndex = indexcatego;
                DropDownList2.DataBind();
  }

            }
            catch (Exception) {

                Response.Redirect("ERROR-aspx");
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ProductoNegocio productomodificado = new ProductoNegocio();

        
                Producto auxmodificar = new Producto();
                marca = marcanegocio.listar_marca();
                categorias = catego.listar_Categoria();
            

                

            var id = Request.QueryString["id"];


            if (id != null) { 
                auxmodificar.Id = Convert.ToInt32( id);
                auxmodificar.Nombre = txtnombre.Text;
                auxmodificar.Descripion = txtDesc.Text;
                if (txtEstado.Text == "1") {
                    auxmodificar.estado = true;
                }
                else { auxmodificar.estado = false; }
                auxmodificar.Precio = Convert.ToDecimal(txtPrecio.Text);
                auxmodificar.stock = int.Parse(txtStock.Text);
                auxmodificar.Marca = marca.Find(c => c.Nombre == DropDownList1.SelectedValue);
                auxmodificar.Categoria = categorias.Find(h=> h.Nombre == DropDownList2.SelectedValue);
                auxmodificar.UrlImagen = txtURL.Text;

                productomodificado.modificar_producto(auxmodificar);
}


            Response.Redirect("ABML_PRODUCTO");
        }
    }
}