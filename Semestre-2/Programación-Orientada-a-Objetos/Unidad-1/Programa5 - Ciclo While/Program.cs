using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa5___Ciclo_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Machado Sanchez Javier
            // Declaración de variables
            float NumUser, NumMayor = 0; int c = 0;
            Random random = new Random();
            Console.Title = "Ejercicio 1 While";
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\r\t\t CÁLCULA EL NÚMERO MAYOR \n\n\t Ingrese 15 números para determinar el mayor.\n\n"); //instrucciones 
            try
            { // Ciclo While, corre el bloque de instrucciones si y solo si la condición es verdadera. 
                while (c < 15)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    c++;
                    NumUser = random.Next(0,100);
                    Console.Write("\tNúmero {0}: {1}\n", c, NumUser);
                    Console.ForegroundColor = ConsoleColor.Green;
                    // Comprobación del número mayor
                    if (NumUser >= NumMayor) { NumMayor = NumUser; }
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n\tEl número mayor es: {0}\n\tPresione la tecla <ESC> para salir...", NumMayor);
                while (Console.ReadKey().Key != ConsoleKey.Escape) ;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\r\tSe ha ingresado uno o más datos inválidos. El programa se detendrá.\n\tPresione la tecla <ESC> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Escape) ;
            }
        }
    }
}