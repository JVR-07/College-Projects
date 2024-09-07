using System; // Referencia a librerias 
using System.Collections.Generic; // Referencia a librerias
using System.Linq; // Referencia a librerias 
using System.Text; // Referencia a librerias 
using System.Threading.Tasks; // Referencia a librerias 

// Machado Sanchez Javier 22211600 
// Problema #1 a código C#
// ~ Calcular la velocidad de un automóvil en base a distancia y el tiempo en recorrer dicha distancia. ~

namespace Problema_1 // Nombre de proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v, d, t; // Declaracion de variables 
            Console.BackgroundColor = ConsoleColor.White; //Color de fondo de consola
            Console.Clear(); //Limpiar color. Permite añadir nuevo color de fondo
            Console.ForegroundColor = ConsoleColor.Cyan; //Color de la fuente
            Console.WriteLine("   ~Calcular la velocidad de un automóvil~ \n"  ); // "\n" sirve para hacer saltos de linea
                              // Console.WriteLine(); sirve para mostrar texto en pantalla
            Console.ForegroundColor = ConsoleColor.Black; // Cambia el color de la fuente
            Console.WriteLine(" Ingrese la distancia recorrida en kilometros: "); // Muestra texto en pantalla
            d = Convert.ToDouble(Console.ReadLine()); // Console.ReadLine(); toma el dato del usuario. Convert.toDouble(); covierte a double el dato de la variable
            Console.WriteLine(" Ingrese el tiempo tomado en horas"); // Muestra tiempo en pantalla
            t = Convert.ToDouble(Console.ReadLine()); // Convierte a Double
            v = d / t; // Proceso
            v = Math.Round(v, 2); // Math.Round(); redondea el punto decimal a los digitos deseados.
            Console.ForegroundColor = ConsoleColor.Green; // Cambia color de fuente
            Console.WriteLine(" La velocidad del automóvil es de: " + v + " km/h"); // Muestra texto y la variable
            Console.ReadKey(); // Permite mantener abierta la consola hasta presionar una tecla
        }
    }
}
