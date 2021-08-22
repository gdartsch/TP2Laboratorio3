using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2A
{
    class Program
    {
        static void Main(string[] args)
        {
            PuntoUno();
            PuntoDos();
            PuntoTres();
            PuntoCuatro();
            PuntoCinco();
            PuntoSeis();
            PuntoSiete();
            PuntoOcho();
            PuntoNueve();
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
            CabeceraPunto("A.1");
            Console.WriteLine("Microsoft Visual Studio es un entorno de desarrollo integrado, " +
                              "\ncreado por la compañía Microsoft y disponible para sistemas operativos " +
                              "\nWindows, Linux y macOS, y la vez es compatible con múltiples lenguajes de " +
                              "\nprogramación, tales como C++, C#, Visual Basic .NET, F#, Java, Python, Ruby " +
                              "\ny PHP, al igual que entornos de desarrollo web, como ASP.NET, fue lanzado en " +
                              "\n1997, cuenta con versiones gratis y de venta." +
                              "\nEs una aplicación informática que proporciona servicios integrales para " +
                              "\nfacilitarle al desarrollador o programador la creación de software, " +
                              "\npermitiéndonos desarrollar aplicaciones, sitios y aplicaciones web, así como " +
                              "\nservicios web en cualquier entorno que soporte la plataforma .NET, algunos " +
                              "\nlenguajes que podemos encontrar son: Visual Basic, Visual C# y Visual C++.");


            Separador();
        }

        private static void PuntoDos()
        {
            CabeceraPunto("A.2");
            Console.WriteLine(".NET es un framework de Microsoft que hace un énfasis en la transparencia " +
                "\nde redes, con independencia de plataforma de hardware y que permite un rápido desarrollo " +
                "\nde aplicaciones. Basada en ella, la empresa intenta desarrollar una estrategia horizontal " +
                "\nque integre sus productos, desde el sistema operativo hasta las herramientas de mercado." +
                "\n.NET podría considerarse una respuesta de Microsoft al creciente mercado de los negocios " +
                "\nen entornos Web, como competencia a la plataforma Java de Oracle Corporation y a los " +
                "\ndiversos framework de desarrollo web basados en PHP.Su propuesta es ofrecer una manera " +
                "\nrápida y económica, a la vez que segura y robusta, de desarrollar aplicaciones –o como la " +
                "\nmisma plataforma las denomina, soluciones– permitiendo una integración más rápida y ágil " +
                "\nentre empresas y un acceso más simple y universal a todo tipo de información desde " +
                "\ncualquier tipo de dispositivo." +
                "\nLa plataforma .NET de Microsoft es un componente de software que puede ser añadido al " +
                "\nsistema operativo Windows. Provee un extenso conjunto de soluciones predefinidas para " +
                "\nnecesidades generales de la programación de aplicaciones, y administra la ejecución de " +
                "\nlos programas escritos específicamente con la plataforma. Esta solución es el producto " +
                "\nprincipal en la oferta de Microsoft, y pretende ser utilizada por la mayoría de las " +
                "\naplicaciones creadas para la plataforma Windows.");


            Separador();
        }

        private static void PuntoTres()
        {
            CabeceraPunto("A.3");
            Console.WriteLine("El Common Language Runtime o CLR ('entorno en tiempo de ejecución de " +
                "\nlenguaje común') es un entorno de ejecución para los códigos de los programas que corren " +
                "\nsobre la plataforma Microsoft .NET. El CLR es el encargado de compilar una forma de código " +
                "\nintermedio llamada Common Intermediate Language (CIL, anteriormente conocido como MSIL, " +
                "\npor Microsoft Intermediate Language), al código de máquina nativo, mediante un compilador " +
                "\nen tiempo de ejecución. No debe confundirse el CLR con una máquina virtual, ya que una " +
                "\nvez que el código está compilado, corre nativamente sin intervención de una capa de " +
                "\nabstracción sobre el hardware subyacente. Es una implementación del estándar Common " +
                "\nLanguage Infrastructure (CLI).Los desarrolladores que usan CLR escriben el código fuente " +
                "\nen un lenguaje compatible con.NET, como C# o Visual Basic .NET. En tiempo de compilación, " +
                "\nun compilador .NET convierte el código a CIL. En tiempo de ejecución, el compilador del " +
                "\nCLR convierte el código CIL en código nativo para el sistema operativo. Alternativamente, " +
                "\nel código CIL es compilado a código nativo en un proceso separado anterior a la ejecución. " +
                "\nEsto acelera las posteriores ejecuciones del software debido a que la compilación de MSIL " +
                "\na nativo ya no es necesaria.A pesar de que algunas implementaciones del Common Language " +
                "\nInfrastructure se ejecutan en sistemas operativos que no sean Windows, el CLR se ejecuta " +
                "\nsolo en Microsoft Windows.La manera en que la máquina virtual se relaciona con el CLR " +
                "\npermite a los programadores ignorar muchos detalles específicos del microprocesador que " +
                "\nestará ejecutando el programa.El CLR también permite otros servicios importantes, " +
                "\nincluyendo los siguientes:" +
                "\n\tºAdministración de la memoria" +
                "\n\tºAdministración de hilos" +
                "\n\tºManejo de excepciones" +
                "\n\tºRecolección de basura" +
                "\n\tºSeguridad");


            Separador();
        }

        private static void PuntoCuatro()
        {
            CabeceraPunto("A.4");
            Console.WriteLine("El framework .NET incluye un conjunto de tipos de datos que permiten ofrecer " +
                "\nrápidamente una solución a muchos de los problemas que podemos encontrar a lo largo del " +
                "\ndesarrollo de una aplicación.Estos tipos de datos están organizados de manera jerárquica." +
                "\nCada nivel de la jerarquía está definido por un espacio de nombres(namespace) que " +
                "\nidentifica a un grupo de tipos.Los espacios de nombres se nombran concatenando el nombre " +
                "\ndel padre, el símbolo '.' y su propio nombre y todo ello hace referencia a un conjunto de " +
                "\nfuncionalidades que se proveen de manera conjunta.Por ejemplo, el espacio de nombres " +
                "\nSystem.Xml agrupa un conjunto de clases que permiten procesar flujos de datos en formato XML. " +
                "\nLa BCL (Base Class Library) contiene varios miles de tipos y es muy probable que nunca " +
                "\nutilice gran parte de ellos en sus desarrollos. Algunos son, en efecto, muy específicos y se " +
                "\nutilizan en muy pocos contextos. Así ocurre con todos los tipos definidos en los espacios de " +
                "\nnombres Microsoft.Build o System.CodeDom, que permiten respectivamente interactuar con el " +
                "\nmotor MSBuild y generar código C# o Visual Basic .NET.");


            Separador();
        }

        private static void PuntoCinco()
        {
            CabeceraPunto("A.5");
            Console.WriteLine("Cuando se crea una solución, se definen automáticamente configuraciones de " +
                "\ncompilación de depuración y de versión y sus destinos de plataforma predeterminados para " +
                "\nla solución. Es posible personalizar estas configuraciones o crear sus propias " +
                "\nconfiguraciones. Las configuraciones de compilación especifican el tipo de compilación. " +
                "\nLas plataformas de compilación especifican el sistema operativo de destino de una " +
                "\naplicación para esa configuración." +
                "\n.NET Native es una tecnología de precompilación para crear e implementar aplicaciones para " +
                "\nUWP. .NET Native se incluye con Visual Studio 2015 y versiones posteriores. Compila " +
                "\nautomáticamente la versión de lanzamiento de las aplicaciones para UWP escritas en código " +
                "\nadministrado (C# o Visual Basic) en código nativo. Normalmente, las aplicaciones de.NET se " +
                "\ncompilan en lenguaje intermedio(IL).En tiempo de ejecución, el compilador Just - In - Time(JIT) " +
                "\nconvierte el IL en código nativo.");


            Separador();
        }

        private static void PuntoSeis()
        {
            CabeceraPunto("A.6");
            Console.WriteLine("Los métodos se declaran en una clase, struct o interfaz especificando el nivel " +
                "\nde acceso, como public o private, modificadores opcionales como abstract o sealed, el valor " +
                "\ndevuelto, el nombre del método y cualquier parámetro de método. Todas estas partes forman la " +
                "\nfirma del método. Un tipo de valor devuelto de un método no forma parte de la firma del " +
                "\nmétodo con el objetivo de sobrecargar el método. Sin embargo, forma parte de la firma del " +
                "\nmétodo al determinar la compatibilidad entre un delegado y el método que señala. " +
                "\nLos parámetros de método se encierran entre paréntesis y se separan por comas. " +
                "\nLos paréntesis vacíos indican que el método no requiere parámetros.");


            Separador();
        }

        private static void PuntoSiete()
        {
            CabeceraPunto("A.7");
            Console.WriteLine("Un espacio de nombres (en inglés, namespace) es un contenedor abstracto en " +
                "\nel que un grupo de uno o más identificadores únicos pueden existir. Un identificador " +
                "\ndefinido en un espacio de nombres está asociado con ese espacio de nombres. El mismo " +
                "\nidentificador puede ser definido independientemente en múltiples espacios de nombres, " +
                "\neso es, el sentido asociado con un identificador definido en un espacio de nombres es " +
                "\nindependiente del mismo identificador declarado en otro espacio de nombres. Los lenguajes " +
                "\nque manejan espacio de nombres especifican las reglas que determinan a qué espacio de " +
                "\nnombres pertenece una instancia de un identificador. Un análogo a los namespace en java son los packages");


            Separador();
        }

        private static void PuntoOcho()
        {
            CabeceraPunto("A.8");
            Console.WriteLine("Una librería se agrega a un proyecto concreto. Esto hay que repetirlo por cada " +
                "\nproyecto, pues la librería no queda agregada a Visual Studio, sino que es cada uno de los " +
                "\nproyectos el que conoce sus librerías. Una vez que el proyecto está abierto en Visual Studio, " +
                "\npara usar desde él una librería, se hace click derecho en la rama Referencias que aparece en " +
                "\nel Explorador de Soluciones y se selecciona Agregar Referencia. Entonces aparece una ventana " +
                "\nque permite buscar la librería y agregarla. Esto funciona para librerías de .Net y librerías " +
                "\nCOM. No vale para librerías binarias con puntos de entrada clásicos. Si se necesita usar una " +
                "\nde estas, hay que usar DllImport desde el código. Si la librería no existe y se necesita " +
                "\ncrearla, entonces se debe hacer click derecho sobre la solución (no sobre el proyecto) y " +
                "\nseleccior Agregar nuevo proyecto. En la lista de tipos de proyecto se elige  Librería de " +
                "\nclases. Una vez se crea el proyecto de librería de clases, se debe ir al proyecto principal y " +
                "\nagregar la referencia de la misma manera mencionada anteriormente, no queda agregada " +
                "\nautomáticamente solo por el hecho de que se haya creado desde la misma solución.");


            Separador();
        }

        private static void PuntoNueve()
        {
            CabeceraPunto("A.9");
            Console.WriteLine("La palabra reservada params se usa en la declaración de los parámetros de un " +
                "\nmétodo, se antepone al tipo de dato que vamos a declarar y tiene una peculiaridad, " +
                "\nsolamente se puede anteponer a parámetros que sean arreglos, por ejemplo a string[], Persona[]. " +
                "\nEsto es porque lo que nos ayuda a escribir es un método que recibe una cantidad variable de " +
                "\nargumentos del mismo tipo y los introduce en un arreglo sin tener que declararlo explícitamente");


            Separador();
        }
    }
}
