using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CarritoNegocio
    {

        public  AccesoDatos datos = new AccesoDatos();

        public List<ArticuloXcarrito> listar_CarritoxArticulo()
        {
                List<ArticuloXcarrito> art = new List<ArticuloXcarrito>();

                try
                {
                    datos.setearConsulta("Select * From ProductoXcarrito");
                    datos.EjecutarLectura();

                    while (datos.lector.Read())
                    {
                        ArticuloXcarrito articulo = new ArticuloXcarrito();
                    articulo.IDcarrito = (int)datos.lector["IDcarrito"];

                    articulo.producto = new Producto();
                    articulo.producto.Nombre = (string)datos.lector["ARTICULO"];
                    articulo.producto.Id = (int)datos.lector["IdArticulo"];
                    articulo.producto.UrlImagen = (string)datos.lector["Imagen"];

                    articulo.sub_total = datos.lector.GetSqlMoney(3);
                    articulo.Cantidad = (int)datos.lector["cantidad"];


                    art.Add(articulo);

                    }
                    return art;
                }
                catch (Exception ex)
                {

                    throw ex;
                }


            }
        public List<Carrito> listar_Carrito()
        {
            List<Carrito> art = new List<Carrito>();

            try
            {
                datos.setearConsulta("Select * ProductoXcarrito");
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Carrito articulo = new Carrito();
                    articulo.ID = (int)datos.lector["ID"];
                    articulo.DniPersona = (string)datos.lector["DNIpersona"];
                    articulo.Total = datos.lector.GetSqlMoney(3);

                    art.Add(articulo);

                }
                return art;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        


    }
}
