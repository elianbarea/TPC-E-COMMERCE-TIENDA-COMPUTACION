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
        AccesoDatos ace = new AccesoDatos();
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

        public void Agregar_marca()
        {

        }

        public void eliminar_marca(string consulta)
        {
            ace.setearConsulta(consulta);
            ace.EjecutarLectura();
        }




    }
}
