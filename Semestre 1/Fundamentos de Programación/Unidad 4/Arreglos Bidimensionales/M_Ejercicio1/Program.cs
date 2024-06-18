using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Ejercicio1
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
            Console.WriteLine("\t\t\tIngrese los números enteros");
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\t\tColumna {0}: ", (i + 1));     // Doble bucle, para asignar una variable diferente a las filas
                    for (int j = 0; j < 4; j++)                         // y a las columnas. Se llena primero la fila y luego se brinca
                    {                                                    // a la siguiente columna.
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\tFila {0}: ", (j + 1));
                        numeros[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\tLa diagonal principal de la matriz es: ");
                for (int k = 0; k < 4; k++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t" + numeros[k, k]); // Mismo valor para fila y columna para mostrar la diagonal principal
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\tPresione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\tAtención, se ha detectado un dato inválido, el programa se cerrará");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}