using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa11___Arreglos_Bidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Machado Sanchez Javier. 22211600
            Console.Title = "CALCULADOR DE DIAGONAL";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            int[,] numeros = new int[4, 4]; // Declaración de array bidimensional, con un espacio de 4 x 4
            Random random = new Random();
            Console.WriteLine("\t\t\tIngrese los números enteros");
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n\t\tColumna {0}: ", (i + 1));     // Doble bucle, para asignar una variable diferente a las filas
                    for (int j = 0; j < 4; j++)                         // y a las columnas. Se llena primero la fila y luego se brinca
                    {                                                    // a la siguiente columna.
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        numeros[i, j] = random.Next(0,100);
                        Console.Write("\tFila {0}: {1}",j + 1, numeros[i,j]);
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\t\tLa diagonal principal de la matriz es: ");
                for (int k = 0; k < 4; k++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t" + numeros[k, k]); // Mismo valor para fila y columna para mostrar la diagonal principal
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("\tPresione la tecla <ESC> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Escape) ;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\tAtención, se ha detectado un dato inválido, el programa se cerrará");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\tPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}