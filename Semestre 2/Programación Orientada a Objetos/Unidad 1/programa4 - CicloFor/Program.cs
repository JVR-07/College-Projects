using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa4___CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machado Sanchez Javier. 22211600
            // Calculadora de tablas de multiplicar hasta el 10
            //Declaración de variables.
            Random random = new Random();
            int NumeroDeTabla = 0, resultado = 0;
            NumeroDeTabla = random.Next(1, 50);
            Console.WriteLine("\tIngrese el número de la tabla de múltiplicar que desea calcular: {0}", NumeroDeTabla);
            //Procedimiento
            for (int i = 1; i <= 10; i++)
            {
                resultado = NumeroDeTabla * i;
                Console.WriteLine("\t{0} x {1} = {2}", NumeroDeTabla, i, resultado);
            }
            Console.Write("\tEl proceso ha finalizado exitosamente.\n\tPresione la tecla <ESC> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}