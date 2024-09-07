using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploRecursivdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, potencia, numero_base;
            Console.WriteLine("\n\t.: CAPTURA DE DATOS :.");
            Console.Write("\n\tIngrese el número que desea elevar: "); numero = int.Parse(Console.ReadLine());
            numero_base = numero;
            Console.Write("\n\tIngrese el número de la potencia: "); potencia = int.Parse(Console.ReadLine());
            Console.Write("\n\n\tIngrese la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            Console.WriteLine("\n\t.: IMPRESIÓN DE RESULTADOS :.");
            calcularPotencia(numero, potencia, numero_base);
            Console.Write("\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
        static void calcularPotencia(int numero, int potencia, int numero_base)
        {
            if (potencia > 1)
            {
                numero *= numero_base;
                potencia--;
                calcularPotencia(numero, potencia, numero_base);
            }
            else if (potencia == 0)
            {
                Console.WriteLine($"\n\tEl resultado es: 1");
            }
            else
            {
                Console.WriteLine($"\n\tEl resultado es: {numero}");
            }
        }
    }
}