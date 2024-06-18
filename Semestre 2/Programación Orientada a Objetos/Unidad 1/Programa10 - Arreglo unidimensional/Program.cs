using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa10___Arreglo_unidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10]; // Declaración de array, con una capacidad para almacenar 20 datos de tipo int
            // Declaración de varialbes
            int temp = 0, contador = 10;
            double mediana;
            Random random = new Random();
            //Bucles para iterar
            for (int i = 0; i < numeros.Length; i++)
            {  // Captura de datos 
                numeros[i] = random.Next(0, 100);
                Console.Write("\tIngrese un valor positivo para el número {0}: {1}\n", i + 1, numeros[i]);
            }
            for (int j = 1; j < contador; j++)
            {
                for (int k = contador - 1; k >= j; k--)
                {
                    if (numeros[k - 1] > numeros[k]) // El segundo bucle se encarga de comparar la posicion de la variable k, con el valor
                    {                                // que esté en la posición anterior(k - 1), si la posición k es más pequeña, se intercambian los
                        temp = numeros[k - 1];       // valores. Por otra parte, el primer bucle se encarga de realizar el proceso anterior durante
                        numeros[k - 1] = numeros[k]; // la cantiadad de ciclos necesarios para asegurarnos de comparar todas las posiciones del array.
                        numeros[k] = temp;
                    }
                }
            }
            mediana = numeros[5] + numeros[6]; mediana = mediana / 2;
            Console.WriteLine("\n\tLa mediana de los datos es: {0}", mediana);
            Console.Write("\tPresione <ESC> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}