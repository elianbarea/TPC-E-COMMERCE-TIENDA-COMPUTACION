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
    public partial class ABML_eliminar : System.Web.UI.Page
    {
        CategoriaNegocio nego = new CategoriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["Modificar"].ToString());
            nego.eliminar_Categoria("DELETE FROM Categorias WHERE ID=" + id.ToString());
            Response.Redirect("ABML_CATEGORIA.aspx");
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABML_CATEGORIA.aspx");
        }
    }
}