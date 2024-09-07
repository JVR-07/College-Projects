using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A
{
    internal class Program
    {
        static void Main(string[] args){ // Machado Sanchez Javier 22211600
            // Personalización de consola e impresión del menú
            Console.Title = "Selectividad Múltiple_Ejercicio A";
            Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            string cod;
            Console.WriteLine("\t\tMostrar características de artículo por su código\n\n\t**Menú**\n\t- 100\n\t- 200\n\t- 300\n\n\tIngrese el código del artículo deseado:");
            Console.ForegroundColor = ConsoleColor.Black; cod = Console.ReadLine();
            Console.ForegroundColor= ConsoleColor.Cyan;
            //  Inicialización de selectiva múltiple 
            switch (cod){ // Se evalua el contenido de la variable
                // Diferentes casos posibles
                case "100":Console.WriteLine("Artículo seleccionado: Aceite 1 L. Departamento: Abarrotes. Código: " + cod); break;
                case "200":Console.WriteLine("Artículo seleccionado: Manzana Roja. Departamento: Frutas y Verduras. Código: " + cod); break;
                case "300":Console.WriteLine("Artículo seleccionado: Carne Res 1 Kg. Departamento: Carnes. Código: " + cod); break;
                default: // No se cumple ningún caso
                Console.WriteLine("No se encontró el código, aseguresé de escribirlo bien."); break;}
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\tPresione la tecla <INTRO> para cerrar la consola...");
            while (Console.ReadKey().Key != ConsoleKey.Enter);}}}