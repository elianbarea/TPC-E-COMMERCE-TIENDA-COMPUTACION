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
            try {
            arti = nego.listar_Categoria();
            REPETIDOR.DataSource = arti;
            REPETIDOR.DataBind();

                var ID1 =  Request.QueryString["ELIMINAR"];
                if (ID1 != null) {

                    nego.eliminar_Categoria("delete from Categorias where ID =" + ID1);
                    arti = nego.listar_Categoria();
                }



            }
            catch (Exception) {

                throw;
            }

        }



        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            CategoriaNegocio CATE = new CategoriaNegocio();

            Categoria newcatego = new Categoria();

            newcatego.Nombre = txtnombre.Text;

            CATE.agregar_categoria(newcatego);

        }
    }
}