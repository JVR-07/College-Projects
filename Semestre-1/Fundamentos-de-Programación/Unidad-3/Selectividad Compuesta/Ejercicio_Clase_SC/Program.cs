using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_SC
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Machado Sanchez Javier 22211600
            // Declaracion de variables 
            double prom, mat, prog, fis;
            string carrera, nombre, numcontrol;
            int semestre;
            // Pedida de datos y personalización de consola
            Console.Title = "Ejemplo de Clase";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\t\tSELECCIÓN DE CONCURSANTES");
            Console.WriteLine("\n\tDATOS PERSONALES:");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Número de control:");
            numcontrol = Console.ReadLine();
            Console.WriteLine("Nombre del estudiante:");
            nombre = Console.ReadLine();
            Console.WriteLine("Carrera:");
            carrera = Console.ReadLine();
            Console.WriteLine("Semestre:");
            semestre = Convert.ToInt16(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\tCALIFICACIONES:");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Calificación de matemáticas:");
            mat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calificación de programación:");
            prog = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calificación de física:");
            //Proceso
            fis = Convert.ToDouble(Console.ReadLine());
            prom = (mat + prog + fis) / 3;
            // Selectiva compuesta
            if (prom >= 90 && semestre == 5)
            {   // Mensaje final
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nFelicidades, fuiste aceptado. Tu promedio es de " + prom + " y eres del semestre " + semestre + ".");
                Console.ForegroundColor = ConsoleColor.Red  ;
                Console.WriteLine("\t Presione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            }
            else
            {   // Mensaje final
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nLo sentimos, no fuiste aceptado. Tu promedio es de " + prom + " y eres del semestre " + semestre + ".");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Presione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            }
        }
    }
}