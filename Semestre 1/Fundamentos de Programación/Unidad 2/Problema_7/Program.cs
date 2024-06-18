using System; // Referencia a librerias 
using System.Collections.Generic; // Referencia a librerias 
using System.Linq; // Referencia a librerias 
using System.Text; // Referencia a librerias 
using System.Threading.Tasks; // Referencia a librerias 

// Machado Sanchez Javier 22211600
// Problema #7 a código C#
// ~Convertir libras a kilogramos y muestre el resultado de la conversión.~

namespace Problema_7 // Nombre del proyecto
{
    internal class Program
    {
        static void Main(string[] args) // Método de arranque del programa
        { 
            Console.BackgroundColor = ConsoleColor.DarkGreen; // Cambiar color de fondo
            Console.Clear(); // Limpiar color de fondo y permite cambiarlo
            Console.ForegroundColor = ConsoleColor.Magenta; // Color de fuente
            Console.WriteLine(" ~Conversión de libras a kilogramos~ \n"); // Muestra mensaje en pantalla
            Console.ForegroundColor = ConsoleColor.DarkRed; // Cambiar color de fuente
            double L, kg; // Declaración de variables
            Console.WriteLine("Ingrese la cantidad de libras: "); // Muestra texto en pantalla
            L = Convert.ToDouble(Console.ReadLine()); // Toma el dato del usuario y lo convierte a double
            kg = L / 2.205; // Proceso
            kg = Math.Round(kg, 3); // Redonde decimales
            Console.WriteLine("La cantidad es de: " + kg + "kg"); // Muestra mensaje y variable en pantalla
            Console.ReadKey(); // Permite mantener abiera la consola hasta presionar una tecla
        }
    }
}
