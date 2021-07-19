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
    public partial class Modificar_Marca : System.Web.UI.Page
    {
        public MarcaNegocio nego = new MarcaNegocio();
        public List<Marca> marcas;
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if (!IsPostBack) {
                    int IndexMarca;
                    int Id = int.Parse(Request.QueryString["id"]);

                    marcas = nego.listar_marca();
                    IndexMarca = marcas.FindIndex(x => x.IDmarca == Id);
                    Modificar_nombre.DataSource = marcas;
                    Modificar_nombre.SelectedIndex = IndexMarca;
                    Modificar_nombre.DataBind();
                }

            }

            catch (Exception) {

                throw;
            }

        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            Marca MarcaAux = new Marca();
            int Id = int.Parse(Request.QueryString["id"]);

            marcas = nego.listar_marca();

            MarcaAux.IDmarca = Id;
            MarcaAux.Nombre = Modificar_nombre.SelectedValue;

            nego.modificar_Marca(MarcaAux);


            Response.Redirect("ABML_MARCA");

        }
    }
}