using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_Manejando_Inversa_Procedimientos_Recursivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string cadena_entrante; char[] char_array; int c;
            //Captura de datos
            Console.Write("\n\t\t.: CAPTURA DE DATOS :." +
                          "\n\n\tIngrese una cadena de texto: "); cadena_entrante = Console.ReadLine();
            Console.Write($"\n\n\tLa cadena \"{cadena_entrante}\" fue registrada." +
                            $"\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Código para convertir la cadena en un arreglo de tipo char
            char_array = cadena_entrante.ToCharArray();
            c = char_array.Length - 1;
            //Llamada al procedimiento recursivo
            Console.Write("\n\t\t.: IMPRESIÓN DE RESULTADO :." +
                          "\n\n\tLa cadena invertida queda de la siguiente manera:" +
                          "\n\t");
            InvertirCadena(char_array, c);
        }
        //Declaración de procedimiento recursivo
        static public void InvertirCadena(char[] char_array, int c)
        {
            if(c >= 0)
            {
                char caracter_auxiliar = char_array[c];
                Console.Write(caracter_auxiliar);
                c--;
                InvertirCadena(char_array, c);
            }
            else
            {
                Console.Write(".\n\n\tProcedimimento terminado exitosamente" +
                                "\n\tPresione la tecla <Esc> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Escape) ;
            }
        }
    }
}
