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
    public partial class AMBL_MARCA : System.Web.UI.Page
    {
        public List<Marca> marcas;
        public MarcaNegocio nego = new MarcaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                marcas = nego.listar_marca();
                REPETIDOR.DataSource = marcas;
                REPETIDOR.DataBind();


                var ID1 = Request.QueryString["ELIMINAR"];
                if(ID1 != null) {
                    nego.eliminar_marca("delete from Marcas where ID =" + ID1);
                    marcas = nego.listar_marca();


                }



            }
            catch (Exception) {

                throw;
            }


        }

        protected void AgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio MAR = new MarcaNegocio();

            Marca NewMarca = new Marca();

            NewMarca.Nombre = txtnombre.Text;

            MAR.agregar_Marca(NewMarca);

        }
    }
}