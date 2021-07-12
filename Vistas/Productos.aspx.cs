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
    public partial class Productos : System.Web.UI.Page
    {

        public List<Producto> lista = new List<Producto>();
        protected void Page_Load(object sender, EventArgs e)
        {


            ProductoNegocio nego = new ProductoNegocio();
            try {
                lista = nego.listar();
                repetidor.DataSource = lista;
                repetidor.DataBind();

            }
            catch (Exception) {

                throw;
            }
            



        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            List<Producto> filtro;

            try {
                if (txtbuscar.Text == "") filtro = lista;


                else {
                    filtro = lista.FindAll(PAPA => PAPA.Nombre.ToLower().Contains(txtbuscar.Text.ToLower()));
                    repetidor.DataSource = filtro;
                    repetidor.DataBind();

                }

            }
            catch (Exception) {

                throw;
            }
        }
    }
}