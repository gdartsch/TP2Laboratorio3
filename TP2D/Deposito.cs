using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2D.D6
{
    class Deposito
    {
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public List<Articulo> Articulos { get; set; }

        public List<Articulo> ArticulosBajoStock()
        {
            List<Articulo> articulosBajoStock = new List<Articulo>();

            foreach (Articulo articulo in Articulos)
            {
                if (articulo.StockTotal <= articulo.StockMinimo)
                {
                    articulosBajoStock.Add(articulo);
                }
            }

            return articulosBajoStock;
        }
    }
}
