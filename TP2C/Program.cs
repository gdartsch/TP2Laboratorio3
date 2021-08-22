using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2C
{
    class Program
    {
        static void Main(string[] args)
        {
            EjercicioC1();
            EjercicioC2();
        }

        private static void EjercicioC1()
        {
            Console.WriteLine("Ejercicio C.1:\n\n");

            int n1, n2;

            Console.WriteLine("Ingrese el primer valor para la matriz:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor para la matriz:");
            n2 = int.Parse(Console.ReadLine());

            string[,] arreglo = new string[n1, n2];

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo.GetLength(1); j++)
                {
                    if (i + 1 + j + 1 == n1 + n2) { arreglo[i, j] = "X"; }
                    else { arreglo[i, j] = "O"; }
                }
            }

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo.GetLength(1); j++)
                {
                    Console.Write(arreglo[i, j] + " ");
                }
                Console.Write("\n");
            }
        }

        private static void EjercicioC2()
        {
            Console.WriteLine("Ejercicio C.2:\n\n");

            Console.WriteLine("Ingrese una serie de números separados por coma:");

            string cadena = Console.ReadLine();
            string[] cadenaSeparada = cadena.Split(',');

            int resultado = 0;

            foreach (string elemento in cadenaSeparada)
            {
                resultado += int.Parse(elemento);
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
