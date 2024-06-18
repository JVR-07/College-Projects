using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1___Condición_simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machado Sanchez Javier. 22211600.
            int age; // Declaración de variables
            Random random = new Random();
            Console.BackgroundColor = ConsoleColor.Yellow; // Cambia color de fondo 
            Console.Clear(); // Limpia color default de consola
            Console.Title = "Practica uno de selectivida simple"; // Cambia título de la consola
            Console.ForegroundColor = ConsoleColor.Black; // Cambia color de fuente 
            age = random.Next(1,100); // Convierte a tipo int y lee datos del usuario
            Console.WriteLine("\t\tIngrese su edad:"); // Muestra mensaje en pantalla 
            Console.ForegroundColor = ConsoleColor.Magenta; // Cambia color de fuente  // Muestra mensaje en pantalla 
            //Selectiva simple
            if (age >= 18)
            { // Condicion para llevar a cabo el bloque de instrucciones
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\tEres mayor de edad, tienes {0} años.",age);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPresione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            } // Permite seleccionar una tecla especifica para cerrar la consola
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t No eres mayor de edad, tienes {0} años.", age);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\n\tPresione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
        }
    }
}