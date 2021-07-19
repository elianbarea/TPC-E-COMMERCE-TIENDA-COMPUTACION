using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
   public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        public SqlDataReader lector;
        string conectar = "data source=.\\SQLEXPRESS; initial catalog=TIENDA; integrated security=sspi";
     
       /// el constructor se encarga de crear la conexion con la db
        public AccesoDatos()
    {
            conexion = new SqlConnection(conectar);
            comando = new SqlCommand();
    }

        /// se encarga de cargar la consulta
        public void setearConsulta(string consulta)
        {

            ///elije el tipo de comando que va ser,en este caso es comando tipo text
            comando.CommandType = System.Data.CommandType.Text;
            ///se le introduce el comando que solicitamos
            comando.CommandText = consulta;
        }
        // ejecuta el comando y le pasa la la conexion ya establecida 
        public void EjecutarLectura()
        {

                ///se le agrega la conexion con la base de datos a la consulta
                comando.Connection = conexion;
                ///abre la conexion
                conexion.Open();
                ///EJECUTA LA LECTURA DEL COMANDO Y LO GUARDA EN LECTOR YA EJECUTADO
                lector = comando.ExecuteReader();


        }

         public void AgregarParametro (string nombre, string valor)
        {

            comando.Parameters.AddWithValue(nombre, valor);
        }

        //se encarga de cerrar la conexion
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
/*
        public SqlDataReader lector
        {
            get { return lector; }
        }*/

    }
}
