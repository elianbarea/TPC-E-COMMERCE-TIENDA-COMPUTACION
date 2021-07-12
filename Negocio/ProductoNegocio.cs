using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Dominio;

namespace Negocio
{
   public class ProductoNegocio
    {
        AccesoDatos ace = new AccesoDatos();
        public List<Producto> listar()
        {
             ///crea una lista de tipo producto
                List<Producto> lista = new List<Producto>();
                   AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * from listar_articulo");
                datos.EjecutarLectura();


                ///realiza una lectura de la tablita(que es lector)
                while (datos.lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = (int)datos.lector["ID"];
                    aux.UrlImagen = (string)datos.lector["Imagen"];
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Descripion = (string)datos.lector["Descripcion"];
                    aux.Precio = datos.lector.GetSqlMoney(7);
                    aux.estado = (bool)datos.lector["Estado"];
                    aux.stock = (int)datos.lector["Stock"];  

                    aux.Marca = new Marca();
                    aux.Marca.Nombre = (string)datos.lector["MARCA"];
                    aux.Marca.IDmarca = (int)datos.lector["idmarca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Nombre = (string)datos.lector["CATEGORIA"];
                    aux.Categoria.IDcategoria = (int)datos.lector["idcategoria"];
                  
                  

                    lista.Add(aux);

                }
                    return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       public void Registrar_Usuario(string consulta)
        {
           
            ace.setearConsulta(consulta);
            ace.EjecutarLectura();
        }



        public void modificar_producto(Producto pr)
        {
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("update Articulos set Nombre = @nombre, Imagen = @IMG, Descripcion = @descrip, Idmarca = @marca, Precio = @precio, Stock = @stock, Estado = @estado, Idcategoria = @categoria where Id = @id");
            datos.AgregarParametro("@id", Convert.ToString( pr.Id) );
            datos.AgregarParametro("@nombre", pr.Nombre);
            datos.AgregarParametro("@descrip", pr.Descripion);
            datos.AgregarParametro("@stock", Convert.ToString(pr.stock) );
            datos.AgregarParametro("@precio", Convert.ToString (pr.Precio) );
            datos.AgregarParametro("@marca", Convert.ToString( pr.Marca.IDmarca));
            datos.AgregarParametro("@categoria", Convert.ToString(pr.Categoria.IDcategoria));
            datos.AgregarParametro("@estado", Convert.ToString( pr.estado));
            datos.AgregarParametro("@IMG", pr.UrlImagen) ;
            datos.EjecutarLectura();
            



        }

        public void agregar_producto(Producto pr)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("insert into Articulos ( Nombre , Imagen  , Descripcion , Idmarca , Precio , Stock , Estado, Idcategoria) values (@nombre, @IMG, @descrip, @marca, @precio, @stock, @estado, @categoria ) ");
            datos.AgregarParametro("@id", Convert.ToString(pr.Id));
            datos.AgregarParametro("@nombre", pr.Nombre);
            datos.AgregarParametro("@descrip", pr.Descripion);
            datos.AgregarParametro("@stock", Convert.ToString(pr.stock));
            datos.AgregarParametro("@precio", Convert.ToString(pr.Precio));
            datos.AgregarParametro("@marca", Convert.ToString(pr.Marca.IDmarca));
            datos.AgregarParametro("@categoria", Convert.ToString(pr.Categoria.IDcategoria));
            datos.AgregarParametro("@estado", Convert.ToString(pr.estado));
            datos.AgregarParametro("@IMG", pr.UrlImagen);
            datos.EjecutarLectura();




        }


        public void eliminar_producto(string consulta)
        {
            ace.setearConsulta(consulta);
            ace.EjecutarLectura();
        }
        public void suspender_producto()
        {

        }
        
    }

}
