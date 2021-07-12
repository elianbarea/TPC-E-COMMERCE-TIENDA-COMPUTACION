using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
namespace Dominio
{
    public class Producto
    {

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripion { get; set; }
        public Marca  Marca { get; set; }
        public Categoria Categoria { get; set; }
        public bool estado { get; set; }
        public int stock { get; set; }
        public  string UrlImagen { get; set; }
        public SqlMoney Precio { get; set; }

    }

}
