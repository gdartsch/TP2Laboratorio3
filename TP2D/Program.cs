using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2D
{
    class Program
    {
        static void Main(string[] args)
        {
            PuntoUno();
            PuntoDos();
            PuntoTres();
            PuntoCuatro();
            PuntoSiete();
        }

        private static void CabeceraPunto(string punto)
        {
            Console.Write("\n\n" +
                          $"Punto {punto}" +
                          "\n\n");
        }

        private static void Separador()
        {
            Console.Write("\n\n" +
                          "----------------------------------" +
                          "\n\n");
        }

        private static void PuntoUno()
        {
            CabeceraPunto("D.1");
            Console.WriteLine("Las clases son los tipos más fundamentales de C#. Una clase es una estructura " +
                "\nde datos que combina estados (campos) y acciones (métodos y otros miembros de función) en " +
                "\nuna sola unidad." +
                "\nUna clase es un elemento que actúa como una plantilla que define las características y " +
                "\ncomportamientos de una entidad. En C# podemos decir que todo es una clase");


            Separador();
        }

        private static void PuntoDos()
        {
            CabeceraPunto("D.2");
            Console.WriteLine("Una clase es básicamente un plano para un tipo de datos personalizado." +
                "\nCuando se define una clase, se utiliza cargándola en la memoria.Una clase que se ha " +
                "\ncargado en la memoria se denomina objeto o instancia.Se crea una instancia de una clase " +
                "\nutilizando la palabra clave de C# new.");


            Separador();
        }

        private static void PuntoTres()
        {
            CabeceraPunto("D.3");
            Console.WriteLine("Un objeto se caracteriza por contener: " +
                "\n\tMétodos: Acciones que puede realizar" +
                "\n\tPropiedades: Características que se pueden leer y, a veces, modificar" +
                "\n\tEventos: Notificaciones(eventos) que produce cuando se realiza una acción concreta" +
                "\n\tAtributos: Variables internas y constantes");


            Separador();
        }

        private static void PuntoCuatro()
        {
            CabeceraPunto("D.4");
            Console.WriteLine("En breves palabras la abstracción es resumir o disminuir un elemento a lo " +
                "\nque lo define sin incluir otros elementos, en este caso los objetos de la Programación " +
                "\nOrientada a Objetos. Para explicar esto se puede recurrir al triangulo y al círculo, " +
                "\nlos dos son figuras geométricas, un triángulo tiene 3 lados y siempre tendrá 3 lados aquí " +
                "\ny al otro lado del universo, y un circulo siempre será una línea conectada, " +
                "\nesto es abstracción, se definen las figuras en una o dos líneas de descripción sin " +
                "\nllegar a meternos en más detalle. En el caso de un sistema que gestiona personas involucradas en una empresa, " +
                "\nestos pueden ser clientes , miembros, acreedores o prestadores. Todos son personas, por lo que se define una clase " +
                "\npadre que contiene a los anteriores. Asimismo, los miembros pueden ser gerentes, directivos, empleados. Los empleados " +
                "\npueden ser de ventas, de atención al cliente. Etc. La abstracción puede manejarse a través de la herencia y el " +
                "\npolimorfismo.");


            Separador();
        }

        private static void PuntoSiete()
        {
            CabeceraPunto("D.7");
            List<D7.Figura> figuras = new List<D7.Figura>();
            figuras.Add(new D7.Rectangulo());
            figuras.Add(new D7.Circulo());
            figuras.Add(new D7.Triangulo());

            foreach (D7.Figura figura in figuras)
            {
                figura.Dibujar();
            }

            Separador();
        }
    }
}
