using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Obtener_Traspuesta_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machado Sanchez Javier - 22211600

            Console.Title = "P5 Obtener la matriz traspuesta";

            int[,] matriz_3_2 = new int[3, 2];
            int[,] matriz_2_3 = new int[2, 3];
            int temp = 0;

            //Captura de datos
            Console.WriteLine("\n\t\t .: CAPTURA DE MATRIZ 2 X 3 :." +
                                "\n\t| Ingrese los números de la matriz |");
            //for anidado para iterar entre las dimensiones de la matriz
            for(int fila = 0; fila < 2; fila++)
            {
                for(int columna = 0; columna < 3; columna++)
                {
                    Console.Write("\n\tFila {0}, Columna {1}: ",fila + 1, columna + 1);
                    matriz_2_3[fila, columna] = int.Parse(Console.ReadLine());
                }
            }
            //Impresión de matriz capturada para visualizarla gráficamente
            Console.Write("\n\n\t .: REPRESENTACIÓN GRÁFICA DE LA MATRIZ :." +
                          "\n\n\t\t\t| {0} {1} {2} |" +
                            "\n\t\t\t| {3} {4} {5} |" +
                          "\n\n\tMatriz capturada correctamente." +
                            "\n\tPresione la tecla <INTRO> para continuar...",
                          matriz_2_3[0,0], matriz_2_3[0,1], matriz_2_3[0,2],
                          matriz_2_3[1,0], matriz_2_3[1,1], matriz_2_3[1,2]);
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //for anidado para realizar el algoritmo
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {   //uso de variable auxiliar para hacer más comprensible el algoritmo
                    temp = matriz_2_3[j, i];
                    matriz_3_2[i, j] = temp;
                }
            }
            //Impresión de matriz capturada para visualizarla gráficamente
            Console.Write(  "\n\t .: REPRESENTACIÓN GRÁFICA DE LA MATRIZ TRASPUESTA :." +
                          "\n\n\t\t\t| {0} {1} |" +
                            "\n\t\t\t| {2} {3} |" +
                            "\n\t\t\t| {4} {5} |" +
                          "\n\n\tMatriz traspuesta correctamente." +
                            "\n\tPresione la tecla <ESC> para salir...",
                          matriz_3_2[0, 0], matriz_3_2[0, 1], matriz_3_2[1, 0],
                          matriz_3_2[1, 1], matriz_3_2[2, 0], matriz_3_2[2, 1]);
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
