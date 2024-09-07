using System; // Referencia a librerias 
using System.Collections.Generic; // Referencia a librerias 
using System.Linq; // Referencia a librerias 
using System.Text; // Referencia a librerias 
using System.Threading.Tasks; // Referencia a librerias 

// Machado Sanchez Javier 22211600
// Problema #5 a código C#
// ~El propietario de una casa de cambio desea un programa para convertir pesos a dólares.~

namespace Problema_5 // Nombte del proyecto
{
    internal class Program
    {
        static void Main(string[] args) // Método en donde inicia el arranque del programa
        {
            Console.BackgroundColor = ConsoleColor.Black; // Cambia el color de fondo
            Console.Clear(); // Limpia color de fondo y permite añadir nuevo color
            double tipo_cambio, pesos, dolares; // Declaracion de variables
            Console.ForegroundColor = ConsoleColor.Red; // Color de fuente
            Console.WriteLine(" ~ Conversión de Pesos a Dólares ~ \n"); // Muestra mensajes en pantalla
            Console.ForegroundColor = ConsoleColor.Green; // Cambio color de fuente
            Console.WriteLine("Ingrese el tipo de cambio:"); // Muestra mensaje en pantalla
            tipo_cambio = Convert.ToDouble(Console.ReadLine()); // Toma el dato del usario y lo convierte a double
            tipo_cambio = Math.Round(tipo_cambio, 2); // Redondea dos decimales después del punto
            Console.WriteLine("Ingrese la cantidad de pesos a convertir:"); // Muestra mensaje en pantalla
            pesos = Convert.ToDouble(Console.ReadLine()); // Toma el dato del usuario y lo convierte a double 
            pesos = Math.Round(pesos, 2); // Redondea los decimales
            dolares = pesos / tipo_cambio; // Proceso
            dolares = Math.Round(dolares, 2); // Redondea los decimales 
            Console.WriteLine("La cantidad en dólares es: $" + dolares); // Muestra el resultado en pantalla
            Console.ReadKey(); // Permite mantener la consola abierta hasta que se presione una tecla
        }
    }
}
