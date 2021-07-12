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
    public partial class Registrarse : System.Web.UI.Page
    {
        public string consulta = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Btniniciar_Click(object sender, EventArgs e)
        {
            ProductoNegocio nego = new ProductoNegocio();
            consulta = "INSERT INTO Usuario (Mail,Contraseña,tipo) VALUES('" + txtcorreo.Text + "', '" + txtcontraseña.Text + "', '0');GO INSERT INTO DetalleUsuarios(DNI, Mail, Nombre, Direccion, Telefono)VALUES('12423', '" + txtcorreo.Text + "', '" + txtnombre.Text + "', '" + txtdireccion.Text + "', '" + txttelefono.Text + "'); GO";
            nego.Registrar_Usuario(consulta);
        }
    }
}