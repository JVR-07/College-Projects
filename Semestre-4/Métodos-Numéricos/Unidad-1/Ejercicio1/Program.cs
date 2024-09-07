using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iteraciones;
            double resultado, porcentaje_error;
            Console.WriteLine("\n\t\t╔          Error Absoluto          ╗" +
                                                "\n\t\t╚   Valor de PI Real y Calculado   ╝");
            Console.Write("\n\t¿Con cuántas iteraciones desea calcular el valor de PI? "); iteraciones = int.Parse(Console.ReadLine());
            Console.Write($"\n\n\tEl valor \" {iteraciones} \" ha sido capturado correctamente. Presione <Enter> para realizar el cálculo... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            resultado = CalcularPI(iteraciones);
            porcentaje_error = Math.PI - resultado;

            Console.WriteLine("\n\t\t╔          Error Absoluto          ╗" +
                                                "\n\t\t╚   Valor de PI Real y Calculado   ╝");
            Console.WriteLine($"\n\tValor de Math.E = {Math.PI}" +
                                               $"\n\tValor Calculado = {resultado}" +
                                               "\n\n\tEl error absoluto es: {0}", porcentaje_error);
            Console.Write("\n\tPresione la tecla <Esc> para salir del programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
        public static double CalcularPI(int iteraciones)
        {
            double valorPi = 0;
            for (int i = 1; i <= iteraciones; i++)
            {
                valorPi += (4 * Math.Pow(-1,i+1)) / (2 * i - 1);
            }
            return valorPi;
        }
    }
}
