using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2B
{
    public class Fraccion
    {
        public int Numerador { get; set; }
        public int Denominador { get; set; }

        public Fraccion(int Numerador, int Denominador)
        {
            this.Numerador = Numerador;
            this.Denominador = Denominador;
        }

        
        public Fraccion Suma(Fraccion f1, Fraccion f2)
        {      
            if(f1.Denominador == 0 || f2.Denominador == 0) { FraccionExcepcion.LanzarExcepcion(); }

            Fraccion fraccion = new Fraccion(((f1.Numerador * f2.Denominador) +
                                              (f1.Denominador * f2.Numerador)), 
                                              (f1.Denominador * f2.Denominador));

            return fraccion;
        }

        public Fraccion Resta(Fraccion f1, Fraccion f2)
        {
            if (f1.Denominador == 0 || f2.Denominador == 0) { FraccionExcepcion.LanzarExcepcion(); }

            Fraccion fraccion = new Fraccion(((f1.Numerador * f2.Denominador) - 
                                              (f2.Numerador * f1.Denominador)), 
                                              (f1.Denominador * f2.Denominador));

            return fraccion;
        }

        public Fraccion Multiplicacion(Fraccion f1, Fraccion f2)
        {
            if (f1.Denominador == 0 || f2.Denominador == 0) { FraccionExcepcion.LanzarExcepcion(); }

            Fraccion fraccion = new Fraccion((f1.Numerador * f2.Numerador), 
                                             (f1.Denominador * f2.Denominador));

            return fraccion;
        }

        public Fraccion Division(Fraccion f1, Fraccion f2)
        {
            if (f1.Denominador == 0 || f2.Denominador == 0) { FraccionExcepcion.LanzarExcepcion(); }

            Fraccion fraccion = new Fraccion((f1.Numerador * f2.Denominador), 
                                             (f1.Denominador * f2.Numerador));

            return fraccion;
        }
    }
}
