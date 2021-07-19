using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;


namespace Dominio
{
    public class ArticuloXcarrito
    {
        public int IDcarrito { get; set; }
        public Producto producto { get; set; }
        public SqlMoney sub_total { get; set; }
        public int Cantidad { get; set; }


    }
}
