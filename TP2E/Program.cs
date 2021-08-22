using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP2E
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(EjecutarHiloCincoSeg);
            t1.Start();
            Thread t2 = new Thread(EjecutarHiloDiezSeg);
            t2.Start();
        }

        private static void EjecutarHiloCincoSeg()
        {
            while (true)
            {
                Console.WriteLine("HILO EJECUTADO 5");
                Thread.Sleep(TimeSpan.FromSeconds(5));
            }
            
        }

        private static void EjecutarHiloDiezSeg()
        {
            while (true)
            {
                Console.WriteLine("HILO EJECUTADO 10");
                Thread.Sleep(TimeSpan.FromSeconds(10));
            }
        }
    }
}
