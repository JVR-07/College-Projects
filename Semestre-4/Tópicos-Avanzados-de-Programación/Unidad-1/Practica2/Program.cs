using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Clase_31_01_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programa clase 31-01-24";
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;

            string nombre, apellido, NoControl;
            short edad;

            Console.Write("\n\tCaptura tu número de control: ");
            NoControl = Console.ReadLine();
            Console.Write("\n\tCaptura tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("\n\tCaptura tu apellido: ");
            apellido = Console.ReadLine();
            Console.Write("\n\tCaptura tu edad: ");
            edad = short.Parse(Console.ReadLine());

            if (edad > 18) Console.WriteLine($"\n\tTu nombre es {nombre}" +
                                             $"\n\tTu apellido es {apellido}" +   
                                             $"\n\tTu número de control es {NoControl}" +
                                             $"\n\tTu edad es {edad} y en efecto, eres mayor de edad");
            else Console.WriteLine($"\n\tTu nombre es {nombre}" +
                                             $"\n\tTu apellido es {apellido}" +
                                             $"\n\tTu número de control es {NoControl}" +
                                             $"\n\tTu edad es {edad} y no eres mayor de edad");

            Console.Write("\n\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
