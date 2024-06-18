using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa6_Ciclo_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Machado Sanchez Javier. 22211600
            Calcular y sumar números pares entre el número 200 y el número 300.
             */
            //Declaración de variables
            short numero = 198, suma = 0;
            //Ciclo Do While 
            do { // Bloque de instrucciones
                numero += 2;
                suma += numero;
                Console.Write("{0}, ",numero);
            } // Condición
            while (numero < 300);
            Console.WriteLine("la suma de los números es de: {0}.", suma);
            Console.Write("Presione la tecla <ESC> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}