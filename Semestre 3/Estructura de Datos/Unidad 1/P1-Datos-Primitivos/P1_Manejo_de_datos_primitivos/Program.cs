using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Manejo_de_datos_primitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MACHADO SANCHEZ JAVIER - 22211600
            //Este programa realiza operaciones aritméticas con datos primitivos

            //Declaración de variables
            int primer_entero, segundo_entero;
            float primer_flotante, segundo_flotante;

            Console.Title = "Manejo de Datos Primitivos";

            //Inicio en la captura de datos
            Console.WriteLine("\n\t\t.: CAPTURA DE DATOS PRIMITIVOS :.");
            Console.Write("\n\tIngrese el primer número entero: ");
            primer_entero = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese el segundo número entero: ");
            segundo_entero = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese el primer número real: ");
            primer_flotante = float.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese el segundo número real: ");
            segundo_flotante = float.Parse(Console.ReadLine());
            Console.Write("\n\tLos datos han sido capturados correctamente." +
                          "\n\tPresione una tecla para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter );
            Console.Clear();
            //Operaciones aritméticas e impresión de resultados
            Console.WriteLine("\n\t\t.: RESULTADO ENTEROS :.");
            Console.WriteLine("\n\t1. | {0} + {1} = {2}", primer_entero , segundo_entero , primer_entero + segundo_entero);
            Console.WriteLine("\n\t2. | {0} - {1} = {2}", primer_entero , segundo_entero , primer_entero - segundo_entero);
            Console.WriteLine("\n\t3. | {0} * {1} = {2}", primer_entero, segundo_entero, primer_entero * segundo_entero);
            Console.WriteLine("\n\t4. | {0} / {1} = {2}", primer_entero, segundo_entero, primer_entero / segundo_entero);
            Console.WriteLine("\n\t4.1. | Residuo de {0} / {1} = {2}", primer_entero, segundo_entero, primer_entero % segundo_entero);

            Console.WriteLine("\n\t\t.: RESULTADO REALES :.");
            Console.WriteLine("\n\t1. | {0} + {1} = {2}", primer_flotante, segundo_flotante, primer_flotante + segundo_flotante);
            Console.WriteLine("\n\t2. | {0} - {1} = {2}", primer_flotante, segundo_flotante, primer_flotante - segundo_flotante);
            Console.WriteLine("\n\t3. | {0} * {1} = {2}", primer_flotante, segundo_flotante, primer_flotante * segundo_flotante);
            Console.WriteLine("\n\t4. | {0} / {1} = {2}", primer_flotante, segundo_flotante, primer_flotante / segundo_flotante);
            Console.WriteLine("\n\t4.1. | Residuo de {0} / {1} = {2}", primer_flotante, segundo_flotante, primer_flotante % segundo_flotante);

            //Mensaje final
            Console.Write("\n\tOperaciones mostradas correctamente." +
                          "\n\tEl programa ha finalizado, presione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}