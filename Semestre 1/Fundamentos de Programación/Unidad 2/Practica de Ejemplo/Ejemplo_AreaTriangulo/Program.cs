using System; // Referencia a librerias
using System.Collections.Generic; // Referencia a librerias
using System.Linq; // Referencia a librerias 
using System.Text; // Referencia a librerias
using System.Threading.Tasks; // Referencia a librerias

// Practica de laboratorio. Calcular area de un triangulo
// Machado Sanchez Javier 22211600
// Uso de variables, Convert.ToDouble

namespace Ejemplo_AreaTriangulo // Nombre de proyecto
{    
    internal class Example
    {
        static void Main(string[] args) // Metodo en donde inicia el arranque del programa
        {           
            double b, h, r;
            Console.BackgroundColor = ConsoleColor.DarkBlue; // Cambio de color de fondo de consola
            Console.Clear(); // Limpia el color de fondo y acepta nuevo color
            Console.ForegroundColor = ConsoleColor.White; // Cambio de color de fuente
            Console.WriteLine("   Calcula el área de un triángulo   "); // Titulo

            Console.ForegroundColor = ConsoleColor.Yellow; // Cambio de color de fuente

            Console.WriteLine("--> Capture base:"); // Muestra mensaje 
            b = Convert.ToDouble(Console.ReadLine()); // Captura base y convierte en tipo double el dato
            Console.WriteLine("--> Capture altura:"); // Muestra mensaje
            h = Convert.ToDouble(Console.ReadLine()); // Captura altura y convierte en tipo double el dato
            // Proceso resultado
            r = b * h / 2;
            // Salida de resultado
            Console.ForegroundColor = ConsoleColor.White; // Cambio de color de fuente
            Console.WriteLine("El área del triángulo es: " + r); // Muestra mensaje para mostrar r
            Console.WriteLine(r); // Muestra r
            Console.ReadKey(); // Permite que la consola no se cierre hasta presionar una tecla
        }
    }
}
