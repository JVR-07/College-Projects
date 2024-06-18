using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Manejo_Funciones_Matematicas_Estructuras_Primitivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machado Sanchez Javier - 22211600
            //Práctica 2 - Manejo de Funciones Matemáticas con Estructuras Primitivas

            Console.Title = "Funciones Matemáticas con Estructuras Primitivas";
            //Declaración de variables
            int primer_entero, segundo_entero, exponente;
            float primer_flotante, segundo_flotante;

            //Captura de datos
            Console.WriteLine("\n\t\t.: CAPTURA DE ENTEROS :.");
            Console.Write("\n\tIngrese el valor del primer entero: ");
            primer_entero = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese el valor del segundo entero: ");
            segundo_entero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\t\t.: CAPTURA DE FLOTANTES :.");
            Console.Write("\n\tIngrese el valor del primer flotante: ");
            primer_flotante = float.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese el valor del segundo flotante: ");
            segundo_flotante = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\t\t.: CAPTURA DEL EXPONENTE :.");
            Console.Write("\n\tIngrese el valor al que desea elevar los números: ");
            exponente = int.Parse(Console.ReadLine());
            Console.Write("\n\n\tLos valores han sido capturados correctamente." +
                                "\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Realización de cálculos e impresión de resultados
            Console.WriteLine("\n\t\t.: RESULTADO ENTEROS :.");
            Console.WriteLine("\t1 - |{0}| = {1}  ..::..  1.1 - |{2}| = {3} ",primer_entero,Math.Abs(primer_entero),segundo_entero,Math.Abs(segundo_entero));
            //Inicio if's anidados para encontrar raíces negativas
            if(primer_entero > 0 && segundo_entero > 0)
            {
                Console.WriteLine("\t2 - V¯{0} = {1}  ..::..  2.1 - V¯{2} = {3}", primer_entero, Math.Sqrt(primer_entero), segundo_entero, Math.Sqrt(segundo_entero));
            }
            else if (primer_entero < 0 && segundo_entero < 0)
            {
                Console.WriteLine("\t2 - V¯{0} = No existen raíces negativas  ..::..  2.1 - V¯{1} = No existen raíces negativas", primer_entero, segundo_entero);
            }
            else if(primer_entero < 0)
            {
                Console.WriteLine("\t2 - V¯{0} = No existen raíces negativas  ..::..  2.1 - V¯{1} = {2}", primer_entero, segundo_entero, Math.Sqrt(segundo_entero));
            }
            else if(segundo_entero < 0)
            {
                Console.WriteLine("\t2 - V¯{0} = {1}  ..::..  2.1 - V¯{2} = No existen raíces negativas", primer_entero, Math.Sqrt(primer_entero), segundo_entero);
            }
            //Final if's anidados
            Console.WriteLine("\t3 - {0}^{1} = {2}  ..::..  3.1 - {3}^{4} = {5}",primer_entero,exponente,Math.Pow(primer_entero,exponente),segundo_entero, exponente,Math.Pow(segundo_entero,exponente));
            //Inicio if's anidados para encontrar los números mayores y menores
            if(primer_entero == segundo_entero)
            {
                Console.WriteLine("\t4 - Ningún número es mayor porque son iguales.");
                Console.WriteLine("\t5 - Ningún número es menor porque son iguales.");
            }
            else if(primer_entero > segundo_entero)
            {
                Console.WriteLine("\t4 - {0} > {1}",primer_entero,segundo_entero);
                Console.WriteLine("\t5 - {0} < {1}", segundo_entero, primer_entero);
            }
            else
            {
                Console.WriteLine("\t4 - {0} > {1}", segundo_entero, primer_entero);
                Console.WriteLine("\t5 - {0} < {1}", primer_entero, segundo_entero);
            }
            //Final if's anidados
            Console.WriteLine("\n\t\t.: RESULTADO FLOTANTES :.");
            Console.WriteLine("\t1 - |{0}| = {1}  ..::..  1.1 - |{2}| = {3} ", primer_flotante, Math.Abs(primer_flotante), segundo_flotante, Math.Abs(segundo_flotante));
            //Inicio if's anidados para encontrar raíces negativas
            if (primer_flotante > 0 && segundo_flotante > 0)
            {
                Console.WriteLine("\t2 - V¯{0} = {1}  ..::..  2.1 - V¯{2} = {3}", primer_flotante, Math.Sqrt(primer_flotante), segundo_flotante, Math.Sqrt(segundo_flotante));
            }
            else if (primer_flotante < 0 && segundo_flotante < 0)
            {
                Console.WriteLine("\t2 - V¯{0} = No existen raíces negativas  ..::..  2.1 - V¯{1} = No existen raíces negativas", primer_flotante, segundo_flotante);
            }
            else if (primer_flotante < 0)
            {
                Console.WriteLine("\t2 - V¯{0} = No existen raíces negativas  ..::..  2.1 - V¯{1} = {2}", primer_flotante, segundo_flotante, Math.Sqrt(segundo_flotante));
            }
            else if (segundo_flotante < 0)
            {
                Console.WriteLine("\t2 - V¯{0} = {1}  ..::..  2.1 - V¯{2} = No existen raíces negativas", primer_flotante, Math.Sqrt(primer_flotante), segundo_flotante);
            }
            //Final if's anidados
            Console.WriteLine("\t3 - {0}^{1} = {2}  ..::..  3.1 - {3}^{4} = {5}", primer_flotante, exponente, Math.Pow(primer_flotante, exponente), segundo_flotante, exponente, Math.Pow(segundo_flotante, exponente));
            //Inicio if's anidados para encontrar los números mayores y menores
            if (primer_flotante == segundo_flotante)
            {
                Console.WriteLine("\t4 - Ningún número es mayor porque son iguales.");
                Console.WriteLine("\t5 - Ningún número es menor porque son iguales.");
            }
            else if (primer_flotante > segundo_flotante)
            {
                Console.WriteLine("\t4 - {0} > {1}", primer_flotante, segundo_flotante);
                Console.WriteLine("\t5 - {0} < {1}", segundo_flotante, primer_flotante);
            }
            else
            {
                Console.WriteLine("\t4 - {0} > {1}", segundo_flotante, primer_flotante);
                Console.WriteLine("\t5 - {0} < {1}", primer_flotante, segundo_flotante);
            }
            //Final if's anidados
            //Mensaje final
            Console.Write("\n\tLos cálculos han sido realizados correctamente." +
                          "\n\tPresione la tecla <Esc> para cerrar el programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}