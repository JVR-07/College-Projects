using System; // Referencia a librerias 
using System.Collections.Generic; // Referencia a librerias 
using System.Linq; // Referencia a librerias 
using System.Text; // Referencia a librerias 
using System.Threading.Tasks; // Referencia a librerias 

// Machado Sanchez Javier 22211600 
// Problema #3 a código C#
// ~ Si un automóvil va a 60 millas/hr y desea recorrer una distancia de 80 km, ¿Cuánto tiempo le tomará recorrer dicha distancia? ~

namespace Problema_3 // Nombre del proyecto
{
    internal class Program
    {
        static void Main(string[] args) // Método en donde inicia el arranque del programa
        {
          Console.BackgroundColor = ConsoleColor.DarkCyan; // Color de fondo de consola
          Console.Clear(); // Limpia color de fondo y permite añadir uno nuevo
          Console.ForegroundColor = ConsoleColor.White; // Color de fuente en consola
          double v, t; // Declaración de variables
          v = 60 * 1.6; // Proceso
          t = 80 / v; // Proceso
          t = Math.Round(t, 1); //La función: "Math.Round(,);" sirve para redondear decimales. Redondear, no eliminar.
          Console.WriteLine("El tiempo que le tomó al vehículo recorrer 80 km a una velocidad de 60 mph, es de: " + t + " horas"); // Muestra de mensaje en consola
          Console.ReadKey();
        }
    }
}
