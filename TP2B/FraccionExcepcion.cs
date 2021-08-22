using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2B
{
    public abstract class FraccionExcepcion: Exception
    {
        public static void LanzarExcepcion()
        {
            throw new Exception("El numerador no puede ser cero");
        }
    }
}
