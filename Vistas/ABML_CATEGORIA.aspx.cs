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
    public partial class ABML_CATEGORIA : System.Web.UI.Page
    {
        public List<Categoria> arti;
        CategoriaNegocio nego = new CategoriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {

            arti = nego.listar_Categoria();
        }
        
        
    }
}