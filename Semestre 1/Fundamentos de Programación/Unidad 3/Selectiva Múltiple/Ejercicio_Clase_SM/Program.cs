using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_SM
{
    internal class Program
    {
        static void Main(string[] args)
        { // Machado Sanchez Javier 22211600
            //Personalización de consola e impresión del menú
            Console.Title = "Selectiva Multiple_Ejemplo";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("\t\tIngrese calificación en literal para retornar valor númerico\n\t******MENÚ******\n\t-Excelente.\n\t-Muy bien.\n\t-Bien.\n\t-Suficiente.\n\t-No aceptado.\n\t\tTu elección es:");
            String cal;
            cal = Console.ReadLine();
            switch (cal) // Selectiva múltiple 
            {   //Proceso
                case "Excelente": // Caso excelente 
                    Console.WriteLine("\tCalificación númerica: 10.");
                    break;
                case "Muy bien": // Caso muy bien
                    Console.WriteLine("\n\tCalificación númerica: 09.");
                    break;
                case "Bien": // Caso bien
                    Console.WriteLine("\n\tCalificación númerica: 08.");
                    break;
                case "Regular": // Caso regular
                    Console.WriteLine("\n\tCalificación númerica: 07.");
                    break;
                case "Suficiente": // Caso suficiente
                    Console.WriteLine("\n\tCalificación númerica: 06.");
                    break;
                case "No aceptado": // Caso no aceptado
                    Console.WriteLine("\n\tCalificación númerica: 05 o menor.");
                    break;
                default: // Ningún caso se cumple
                    Console.WriteLine("Calificación no valida. Aseguresé de escribir correctamente la palabra.");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\tPresione la tecla <INTRO> para cerrar la consola...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}