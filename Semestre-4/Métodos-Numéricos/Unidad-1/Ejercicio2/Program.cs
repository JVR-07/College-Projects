using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iteraciones;
            double resultado, porcentaje_error;
            Console.WriteLine("\n\t\t╔          Error Absoluto           ╗" +
                                                "\n\t\t╚  Valor de Euler Real y Calculado  ╝");
            Console.Write("\n\t¿Con cuántas iteraciones desea calcular el valor de Euler? "); iteraciones = int.Parse(Console.ReadLine());
            Console.Write($"\n\n\tEl valor \" {iteraciones} \" ha sido capturado correctamente. Presione <Enter> para realizar el cálculo... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            
            resultado = CalcularE(iteraciones);
            porcentaje_error = Math.E - resultado;

            Console.WriteLine("\n\t\t╔          Error Absoluto           ╗" +
                                                "\n\t\t╚  Valor de Euler Real y Calculado  ╝");
            Console.WriteLine($"\n\tValor de Math.E = {Math.E}" +
                                               $"\n\tValor Calculado = {resultado}" +
                                               "\n\n\tEl error absoluto es: {0}", porcentaje_error);
            Console.Write("\n\tPresione la tecla <Esc> para salir del programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
        public static double CalcularE(int iteraciones)
        {
            double valorPi = 0;
            for (int i = 0; i <= iteraciones; i++)
            {
                valorPi += 1 / CalcularFactorial(i);
            }
            return valorPi;
        }

        public static double CalcularFactorial(double numero)
        {
            if (numero != 0)
            {
                for (int i = Convert.ToInt32(numero); i > 1; i--)
                {
                    numero *= i - 1;
                }
            }
            else numero = 1;
            return numero;
        }
    }
}