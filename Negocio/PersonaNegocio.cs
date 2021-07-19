using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{

    public class PersonaNegocio
    {
         AccesoDatos datos = new AccesoDatos();

        public List<Usuario> listar_usuarios()
        {
            List<Usuario> usu = new List<Usuario>();

            try
            {
                datos.setearConsulta("Select * Usuario");
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.Mail = (string)datos.lector["Mail"];
                    aux.Contraseña = (string)datos.lector["Contraseña"];
                    aux.Tipo = (int)datos.lector["tipo"];


                    usu.Add(aux);

                }
                return usu;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void agregar_Persona(Usuario usu)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("insert into Usuario  (Mail, Contraseña, tipo ) values (@mail, @contra, 1) ");
            datos.AgregarParametro("@mail", usu.Mail);
            datos.AgregarParametro("@contra", usu.Contraseña);
            datos.EjecutarLectura();


        }

        public void eliminar_marca(string consulta)
        {
            datos.setearConsulta(consulta);
            datos.EjecutarLectura();
        }
        public void modificar_Marca(Marca cat)
        {


        }

        public Usuario Verificar_Cuenta (Usuario usu)
        {
            AccesoDatos datos = new AccesoDatos();
            Usuario usu2 = new Usuario();   
            try
            {
            datos.setearConsulta("select Mail, Contraseña, tipo from Usuario where Mail = @mail and Contraseña = @contra");
            datos.AgregarParametro("@mail", usu.Mail);
            datos.AgregarParametro("@contra", usu.Contraseña);
            datos.EjecutarLectura();

           if(datos.lector.Read()){ 

            usu2.Mail = (string)datos.lector["Mail"];
            usu2.Contraseña = (string)datos.lector["Contraseña"];
            usu2.Tipo = (Convert.ToInt32(datos.lector["tipo"]));

                }

            return usu2;

            }

            catch (Exception)
            {

                throw;
            }
            



         }

        public Usuario Verificar_Mail(Usuario usu)
        {
            AccesoDatos datos = new AccesoDatos();
            Usuario usu2 = new Usuario();
            try
            {
                datos.setearConsulta("select Mail from Usuario where Mail = @mail");
                datos.AgregarParametro("@mail", usu.Mail);
                datos.EjecutarLectura();

                if (datos.lector.Read())
                {

                    usu2.Mail = Convert.ToString (datos.lector["Mail"]);

                }

                return usu2;

            }

            catch (Exception)
            {

                throw;
            }




        }

    }


}

