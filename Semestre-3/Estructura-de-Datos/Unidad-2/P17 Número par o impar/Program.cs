using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_Número_par_o_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int numero_base;
            //Captura de datos
            Console.Write("\n\t\t.: Capturando el valor :." +
                          "\n\n\tIngrese un número entero: "); numero_base = int.Parse(Console.ReadLine());
            Console.Write($"\n\tSe ha capturado el número {numero_base} correctamente" +
                          $"\n\tPresione la tecla <INTRO> para continuar..."); while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Llamada a método recursivo
            Console.Write("\n\t\t.: IMPRESIÓN DE DATOS :.");
            VerificarPar(numero_base);
            Console.Write("\n\tLos cálculos han finalizado correctamente" +
                          "\n\tPresione la tecla <Esc> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
        //Declaración de primer método recursivo
        static public void VerificarPar(int numero_base)
        {
            if(numero_base % 2 == 0)
            {
                Console.WriteLine($"\n\n\tEL número {numero_base} es par.");
            }
            else
            {   //Lamada a segundo método recursivo en caso de no cumplirse la condición
                VerificarImpar(numero_base);
            }
        }
        //Declaración de segundo método recursivo
        static public void VerificarImpar(int numero_base)
        {
            if (numero_base % 2 != 0)
            {
                Console.WriteLine($"\n\n\tEL número {numero_base} es impar.");
            }
            else
            {   //Llamada a primer método recursivo en caso de no cumplirse la condición
                VerificarPar(numero_base);
            }
        }
    }
}
