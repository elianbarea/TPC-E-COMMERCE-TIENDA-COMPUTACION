using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class CategoriaNegocio
    {
       public AccesoDatos ace = new AccesoDatos();
        public List<Categoria> listar_Categoria()
        {
            ///crea una lista de tipo producto
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * from Categorias");
                datos.EjecutarLectura();

                ///realiza una lectura de la tablita(que es lector)
                while (datos.lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IDcategoria = (int)datos.lector["ID"];
                    aux.Nombre = (string)datos.lector["Nombre"];




                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void eliminar_Categoria(string consulta)
        {
            ace.setearConsulta(consulta);
            ace.EjecutarLectura();
        }

        public void agregar_categoria(Categoria cat)
        {
            AccesoDatos datos = new AccesoDatos();
            
            datos.setearConsulta("insert into Categorias (Nombre) values (@nombre) ");
            datos.AgregarParametro("@nombre",cat.Nombre);
            datos.EjecutarLectura();
        }

        public void modificar_Categoria(Categoria cat)
        {

            ace.setearConsulta("update Categorias set Nombre = @nombre where id= @id");
            ace.AgregarParametro("@nombre", cat.Nombre);
            ace.AgregarParametro("@id", Convert.ToString( cat.IDcategoria));
            ace.EjecutarLectura();


        }
        public void suspender_Categoria(Categoria cat)
        {

            ace.setearConsulta("update Categorias set Nombre = @nombre where id= @id");
            ace.AgregarParametro("@nombre", cat.Nombre);
            ace.AgregarParametro("@id", Convert.ToString(cat.IDcategoria));
            ace.EjecutarLectura();


        }


    }
}

