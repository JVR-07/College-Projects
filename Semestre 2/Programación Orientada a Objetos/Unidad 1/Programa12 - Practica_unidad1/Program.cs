using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa12___Practica_unidad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machado Sanchez Javier. 22211600.
            //Declaración de varialbes.
            double area = 0; ;
            string opcion = "";
            int[] multiplos = new int[50]; int[,] arregloBidimensional = new int[4, 4];
            int j = 49, k = 0, contador = 0, sumatoria = 0, promedio = 0;
            Random random = new Random();
            do
            {  // Despliegue de menú
                Console.WriteLine("\tMENÚ DE OPCIONES\n\n\t a) - Calcular Área de un cubo. \n\t b) - Desplegar múltiplos de 3 entre 1 y 50.\n\t c) - Calcular suma y promedio de arreglo.\n\t d) - Salir del programa.");
                Console.Write("\tEliga la opcion deseada (ingrese el inciso en minúscula): ");
                opcion = Console.ReadLine();
                switch (opcion)
                {  // Operaciones realizadas 
                    case "a":
                        {
                            Console.Write("\tIngrese el lado del cubo: "); area = Convert.ToDouble(Console.ReadLine());
                            area = CalcularAreaCubo(area);
                            ImprimirAreaCubo(area);
                        }
                        break;
                    case "b":
                        {
                            for (int i = 0; i < multiplos.Length; i++)
                            {
                                multiplos[i] = 3 * (i + 1);
                            }
                            do
                            {

                                Console.Write("\tMúltiplo {0}: {1}\n", k + 1, multiplos[k]);
                                k++;
                            } while (k < multiplos.Length);
                            Console.WriteLine("\n\t\tMúltiplos de manera descendiente.\n");
                            while (j > -1)
                            {
                                Console.Write("\tMúltiplo {0}: {1}\n", j + 1, multiplos[j]);
                                j--;
                            }
                            Console.Write("\n\tEl proceso ha finalizado. Presione una tecla para continuar(los datos se borrarán)...");
                            Console.ReadLine();
                        }
                        break;
                    case "c":
                        {
                            for (int columnas = 0; columnas < 4; columnas++)
                            {
                                Console.Write("\n\tColumna {0}:", columnas + 1);
                                for (int filas = 0; filas < 4; filas++)
                                {
                                    arregloBidimensional[filas, columnas] = random.Next(0, 50);
                                    Console.Write("\tFila {0}: {1}", filas + 1, arregloBidimensional[filas, columnas]);
                                    sumatoria += arregloBidimensional[filas, columnas];
                                    contador++;
                                }
                            }
                            promedio = sumatoria / contador;
                            Console.Write("\n\tLa sumatoria del arreglo es: {0}\n\tEl promedio del arreglo es: {1}.\n\tProceso terminado, presione cualquier tecla para continuar(los datos se borrarán)...", sumatoria, promedio);
                            Console.ReadLine();
                        }
                        break;
                    case "d":
                        {
                            Console.Write("\n\tGracias por usar nuestro Software, presione <ESC> para salir...");
                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                        }
                        break;
                    default:
                        {
                            Console.Write("\tEl dato ingresado no es válido, asegurese de escribirlo bien.\n\tPresione cualquier tecla para regresar al menú.");
                            Console.ReadKey();
                        }
                        break;
                }
                Console.Clear();
            }
            while (opcion != "d");
        }
        //Función para calcular area
        static double CalcularAreaCubo(double lado)
        {
            double area;
            area = 6 * Math.Pow(lado, 2);
            return area;

        }
        //Procedimiento para imprimir información
        static void ImprimirAreaCubo(double area)
        {
            Console.WriteLine("\tEl area del cubo es de: {0}", area);
            Console.Write("\tEl procceso ha finalizado, presione cualquier tecla para continuar(los datos se borrarán)...");
            Console.ReadLine();
        }
    }
}