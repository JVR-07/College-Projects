using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args) // Machado Sanchez Javier. 22211600
        {
            try
            {
                Console.Title = "Datos de matriz";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                int[,] matriz = new int[5, 4]; // Declaracion de matriz tipo int
                int[] SumaFila = new int[5], SumaColumna = new int[4]; // Declaracion de vector tipo int
                int SumTotal = 0, NumMayor = 0, FilaNumMayor = 0, ColumnaNumMayor = 0, Filas = 5, Columnas = 4;
                Console.WriteLine("\tPRACTICA CON ARREGLOS BIDIMENSIONALES");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int i = 0; i < Columnas; i++)
                {
                    for (int j = 0; j < Filas; j++) // Doble bucle para poder llenar la matriz y los vectores
                    {
                        Console.Write("\n\tIngrese el número de la fila {0} y la columna {1}: ", j, i);
                        matriz[j, i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n\tDatos almacenados exitosamente\n");
                for (int i = 0; i < Filas; i++)
                {
                    for (int j = 0; j < Columnas; j++) // Ciclo para sumar las filas
                    {
                        SumaFila[i] = SumaFila[i] + matriz[i, j];
                    }
                }
                for (int i = 0; i < Columnas; i++) // Ciclo para sumar las columnas
                {
                    for (int j = 0; j < Filas; j++)
                    {
                        SumaColumna[i] = SumaColumna[i] + matriz[j, i];
                    }
                }
                for (int i = 0; i < Columnas; i++){ // Ciclo para obtener el total de la tabla, sumando todos los totales de las columnas
                    SumTotal = SumTotal + SumaColumna[i];}
                for (int i = 0; i < Columnas; i++)
                {for (int j = 0; j < Filas; j++) // Ciclo para calcular el número mayor
                    {
                        if (matriz[j, i] > NumMayor){
                            NumMayor = matriz[j, i];
                            FilaNumMayor = j;
                            ColumnaNumMayor = i;}}}
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < Filas; i++){Console.WriteLine("\tLa suma de la fila " + i + " es: " + SumaFila[i].ToString());}
                for (int i = 0; i < Columnas; i++){Console.WriteLine("\tLa suma de la columna " + i + " es: " + SumaColumna[i].ToString());}
                Console.Write("\tLa suma total de la matriz es de: {0}\n\tEl número mayor de la matriz es: \"{1}\"; posicionado en la fila \"{2}\" de la columna: \"{3}\"", SumTotal, NumMayor, FilaNumMayor, ColumnaNumMayor);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Presione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;}
            catch(FormatException) {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Algo salio mal.\n\tPresione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;}}}}