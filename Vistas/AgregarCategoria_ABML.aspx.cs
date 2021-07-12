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
    public partial class AgregarMarca_ABML : System.Web.UI.Page
    {
        CategoriaNegocio nego = new CategoriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txTagregar_Click(object sender, EventArgs e)
        {
            nego.eliminar_Categoria("INSERT INTO Categorias (Nombre) VALUES ('" + txtNombre.Text + "');");
            Response.Redirect("ABML_CATEGORIA.aspx");
        }
    }
}