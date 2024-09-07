using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Machado Sanchez Javier. 22211600
            try
            {
                Console.Title = "Matriz de calificaciones";
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                string[] NC = new string[20], Name = new string[20]; // Declaracion de vector tipo string
                int[,] Calificaciones = new int[20, 3]; // Declaracion de matriz tipo int
                int[] Prom = new int[20]; // Declaracion de vector tipo int
                int j, alumno, parcial, SumaCal = 0, numcal = 3;
                Console.WriteLine("\t\t\t PROMEDIO DE 20 ALUMNOS\n");
                for (int i = 0; i < Name.Length; i++){
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\tIngrese el nombre del alumno {0}: ", (i + 1)); Name[i] = Console.ReadLine();
                    Console.Write("\tIngrese el número de control del alumno {0}: ", (i + 1)); NC[i] = Console.ReadLine();
                    for (j = 0; j < numcal; j++) // Doble bucle para poder iterar en las distintas posiciones de los vectores y matrices
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\tIngrese la calificación del alumno {0} en el parcial {1}: ", (i + 1), (j + 1));
                        Calificaciones[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\tDatos capturados correctamente.");

                for (alumno = 0; alumno < Name.Length; alumno++)
                {
                    for (parcial = 0; parcial < numcal; parcial++) // Doble bucle para poder acceder a los datos de la matriz
                    {
                        SumaCal = SumaCal + Calificaciones[alumno, parcial]; // proceso
                    }
                    Prom[alumno] = SumaCal / numcal;
                    SumaCal = 0;
                }

                for (int k = 0; k < Name.Length; k++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\n\tEl promedio final del alumno: {0}, con número de control: {1}, es de: {2}", Name[k], NC[k], Prom[k] + ".\n\tSus calificaciones en las tres unidades son: ");
                    for (int c = 0; c < numcal; c++) // Doble bucle para poder mostrar los datos de la matriz y los vectores
                        Console.Write(Calificaciones[k, c] + ". ");
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\tPresione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Se ha producido un error en la captura de los datos.\n\tPresione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            }
        }
    }
}