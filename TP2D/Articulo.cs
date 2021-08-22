using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2D.D6
{
    class Articulo
    {
        public string Codigo { get; set; }
        public double StockTotal { get; set; }
        public double StockMinimo { get; set; }
        public Deposito Deposito { get; set; }
    }
}
