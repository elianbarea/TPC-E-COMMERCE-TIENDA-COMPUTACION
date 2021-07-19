using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class MarcaNegocio
    {
        public AccesoDatos ace = new AccesoDatos();
        public List<Marca> listar_marca()
        {
            ///crea una lista de tipo producto
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * from Marcas");
                datos.EjecutarLectura();

                ///realiza una lectura de la tablita(que es lector)
                while (datos.lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IDmarca = (int)datos.lector["ID"];
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

        public void agregar_Marca(Marca mar)
        {
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("insert into Marcas (Nombre) values (@nombre) ");
            datos.AgregarParametro("@nombre", mar.Nombre);
            datos.EjecutarLectura();
        }

        public void eliminar_marca(string consulta)
        {
            ace.setearConsulta(consulta);
            ace.EjecutarLectura();
        }
        public void modificar_Marca(Marca cat)
        {

            ace.setearConsulta("update Marcas set Nombre = @nombre where id= @id");
            ace.AgregarParametro("@nombre", cat.Nombre);
            ace.AgregarParametro("@id", Convert.ToString(cat.IDmarca));
            ace.EjecutarLectura();


        }




    }
}
