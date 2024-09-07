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
            int acumulador = 1, potencia, numero_base, c_potencia = 0;
            //Captura de datos
            Console.WriteLine("\n\t\t.: CAPTURA DE DATOS :.");
            Console.Write("\n\tIngrese el número entero que desea elevar: "); numero_base = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese el número de la potencia: "); potencia = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Impresión de resultados
            Console.WriteLine("\n\t\t.: IMPRESIÓN DE RESULTADOS :.");
            //Llamada a función recursiva indirecta
            calcularPotencia(acumulador, potencia, numero_base, c_potencia);            
            Console.Write("\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
        //Declaración de primera función recursiva indirecta
        static public void calcularPotencia(int resultado, int potencia, int numero_base, int c_potencia)
        {
            if (c_potencia < potencia)
            {
                resultado *= numero_base;
                MostrarPotencia(resultado, potencia, numero_base, c_potencia);
            }
            else if (potencia == 0)
            {
                resultado = 1;
                Console.WriteLine($"\n\t{numero_base}^{c_potencia} = {resultado}");
                Console.WriteLine($"\n\tEl resultado final de elevar {numero_base} a la potencia {potencia} es: {resultado}");
            }
            else
            {
                Console.WriteLine($"\n\tEl resultado final de elevar {numero_base} a la potencia {potencia} es: {resultado}");
            }
        }
        //Declaración de segunda función recursiva indirecta
        static public void MostrarPotencia(int resultado, int potencia, int numero_base, int c_potencia)
        {
            if(c_potencia < potencia)
            {
                Console.WriteLine($"\n\t{numero_base}^{c_potencia + 1} = {resultado}");
                c_potencia++;
                calcularPotencia(resultado, potencia, numero_base, c_potencia);
            }
        }
    }
}