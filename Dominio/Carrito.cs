using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Dominio
{
   public class Carrito
    {
        public int ID { get; set; }
        public string DniPersona { get; set; }
        public SqlMoney Total { get; set; }

    }
}
