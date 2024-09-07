using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_Manejo_de_funcion_recursiva_directa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables
            int numero, potencia, numero_base, resultado;

            //Captura de datos
            Console.WriteLine("\n\t\t.: CAPTURA DE DATOS :.");
            Console.Write("\n\tIngrese el número entero que desea elevar: "); numero = int.Parse(Console.ReadLine());
            numero_base = numero;
            Console.Write("\n\tIngrese el número de la potencia: "); potencia = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Impresión de resultados
            Console.WriteLine("\n\t\t.: IMPRESIÓN DE RESULTADOS :.");
            //Llamada a función recursiva
            resultado = calcularPotencia(numero, potencia, numero_base);
            Console.WriteLine($"\n\tEl resultado de elevar {numero} a la potencia {potencia} es: {resultado}");
            Console.Write("\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
        //Declaración de función recursiva
        static int calcularPotencia(int numero, int potencia, int numero_base)
        {
            if (potencia > 1)
            {
                numero *= numero_base;
                potencia--;
                return calcularPotencia(numero, potencia, numero_base);
            }
            else if (potencia == 0)
            {
                return 1;
            }
            else
            {
                return numero;
            }
        }
    }
}
