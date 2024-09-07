using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa7___Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Machado Sanchez Javier 22211600
            // Personalización de consola e impresión del menú
            Console.Title = "Selectividad Swithc Case";
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string cod; // Declaración de variable
            Console.WriteLine("\t\tMostrar características de artículo por su código\n\n\t**Menú**\n\t- 100\n\t- 200\n\t- 300. \n\t- Ingrese <salir> para salir.");
            //  Inicialización de selectiva múltiple 
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\n\tIngrese el código del artículo deseado: ");
                Console.ForegroundColor = ConsoleColor.Green;
                cod = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                switch (cod)
                { // Se evalua el contenido de la variable
                  // Diferentes casos posibles
                    case "100": Console.WriteLine("\n\tArtículo seleccionado: Aceite 1 L. Departamento: Abarrotes. Código: {0}", cod); break;
                    case "200": Console.WriteLine("\n\tArtículo seleccionado: Manzana Roja. Departamento: Frutas y Verduras. Código: {0}", cod); break;
                    case "300": Console.WriteLine("\n\tArtículo seleccionado: Carne Res 1 Kg. Departamento: Carnes. Código: {0}", cod); break;
                    case "salir": break;
                    default: // No se cumple ningún caso
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\tNo se encontró el código, aseguresé de escribirlo bien."); break;
                }
            }
            while (cod != "salir");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\tPresione la tecla <ESC> para cerrar la consola...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}