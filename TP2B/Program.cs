using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio B.2");
            LeerCadenas();
        }

        public static void LeerCadenas()
        {
            string c1, c2;

            Console.WriteLine("Ingrese cadena 1");
            c1 = Console.ReadLine();

            Console.WriteLine("Ingrese cadena 2");
            c2 = Console.ReadLine();

            if (ValidarCadena(c1,c2))
            {
                if (EncontrarSubCadena(c1, c2))
                {
                    Console.WriteLine($"\nCadena 1: {c1}" +
                                      $"\nCadena 2: {c2}" +
                                      "\nResultado: ENCONTRADO");
                }
                else 
                { Console.WriteLine("\nResultado: NO ENCONTRADO"); }
            }
            else
            {
                Console.WriteLine("\nIntento fallido: " +
                                  "\nLa cadena 2 no puede contener más caracteres que la cadena 1");
            }
        }

        public static bool ValidarCadena(string c1, string c2)
        {
            return c2.Length < c1.Length;
        }

        public static bool EncontrarSubCadena(string c1, string c2)
        {
            return c1.Contains(c2);
        }
    }
}
