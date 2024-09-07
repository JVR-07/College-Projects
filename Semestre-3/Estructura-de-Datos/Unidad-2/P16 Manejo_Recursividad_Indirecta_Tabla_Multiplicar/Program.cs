using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_Manejo_Recursividad_Indirecta_Tabla_Multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int numero_base, resultado = 0, multiplicador_maximo, c = 1;
            //Captura de datos
            Console.Write("\n\t\t.: CAPTURA DE DATOS :." +
                          "\n\t | Ingrese los números enteros que se le pidan |" +
                          "\n\n\tTabla de multiplicar: "); numero_base = int.Parse(Console.ReadLine());
            Console.Write("\n\tMultiplicador máximo: "); multiplicador_maximo = int.Parse(Console.ReadLine());
            Console.Write($"\n\n\tSe calculara la tabla de multiplicar del número {numero_base} hasta el {multiplicador_maximo}" +
                          $"\n\tPresione la tecla <INTRO> para continuar..."); while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Llamada a método recursivo
            Console.WriteLine("\n\t\t.: IMPRESIÓN DE RESULTADOS :.\n");
            CalcularTabla(numero_base, resultado, multiplicador_maximo, c);
            Console.Write("\n\tResultado calculados correctamente" +
                          "\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
        //Definición de método recursivo para calcular tabla
        static public void CalcularTabla(int numero_base, int resultado, int multiplicador_maximo, int c)
        {
            if (c <= multiplicador_maximo) 
            {
                resultado = numero_base * c;
                MostrarTabla(numero_base, resultado, multiplicador_maximo, c);
            }
        }

        //Definición de método recursivo para mostrar la tabla
        static public void MostrarTabla(int numero_base, int resultado, int multiplicador_maximo, int c)
        {
            Console.WriteLine($"\t{numero_base} x {c} = {resultado}");
            c++;
            CalcularTabla(numero_base, resultado, multiplicador_maximo, c);
        }
    }
}
