using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa34_PracticaExcepción_IndiceFueraRango
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables auxiliares
            int[] arreglo = new int[10];
            Random random = new Random();

            // Bloque try para controlar las excepciones
            try
            {   //Asignación de valores con random
                for(int i = 0; i < arreglo.Length; i++) 
                {
                    arreglo[i] = random.Next(10,99);
                }  
                
                //Reordenamiento de arreglo
                Array.Sort(arreglo);

                //Despliegue de arreglo
                Console.WriteLine("\n\t\t.: Arreglo Ordenado :.");
                for(int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine("\t{0}.- : |{1}|", i + 1,arreglo[i]);
                }
                Console.WriteLine("\n\tEl array ha sido mostrado correctamente");
                Console.Write("\n\tPresione la tecla <Enter> para continuar...");
                Console.ReadKey();
                Console.Clear();
                
                //Excepción forzada
                arreglo[15] = 12345;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("\n\tSe ha excedido del rango, por favor seleccione una posición existente");
                Console.WriteLine("\n\tMensaje del Error: " + e.Message);
                Console.WriteLine("\n\tRuta del Error: " + e.StackTrace);
                Console.Write("\n\tPresione la tecla <Enter> para continuar..."); Console.ReadKey();
                Console.Clear();
            }
            finally
            {
                Console.WriteLine("\n\n\n\tEl bloque finally siempre se ejecuta.");
                Console.Write("\n\tPresione <enter> para Salir del Programa..."); Console.ReadKey();
            }
        }
    }
}