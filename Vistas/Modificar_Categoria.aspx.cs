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
    public partial class Modificar_Categoria : System.Web.UI.Page
    {
        public List<Categoria> categoria;
        public CategoriaNegocio cate = new CategoriaNegocio();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
            if (!IsPostBack) {
                int indexcatego;
                int Id = int.Parse(Request.QueryString["id"]);

                categoria = cate.listar_Categoria();
                indexcatego = categoria.FindIndex(x => x.IDcategoria == Id);
                Modificar_nombre.DataSource = categoria;
                Modificar_nombre.SelectedIndex = indexcatego;
                Modificar_nombre.DataBind();
            }

            }

            catch (Exception) {

                throw;
            }



        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            Categoria categoriaAux = new Categoria();
            int Id = int.Parse(Request.QueryString["id"]);

            categoria = cate.listar_Categoria();

            categoriaAux.IDcategoria = Id;
            categoriaAux.Nombre = Modificar_nombre.SelectedValue;

            cate.modificar_Categoria(categoriaAux);


            Response.Redirect("ABML_CATEGORIA");


        }
    }
}