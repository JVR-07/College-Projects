using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Manejo_de_Procedimiento_Recursivo_Directo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int numero_base, numero_acumulador, resultado = 0, c = 0;

            //Captura de datos
            Console.Write("\n\t\t:.:. CAPTURA DE DATOS .:.:" +
                                "\n\t|.:| Este programa realiza la tabla de dividir |:.|" +
                                "\n\t|.:|        hasta el duodécimo divisor         |:.|" +
                                
                              "\n\n\tIngrese el número entero deseado para realizar la tabla: ");
            numero_base = int.Parse(Console.ReadLine()); numero_acumulador = numero_base;
            Console.Write($"\n\n\tEl Dato \"{numero_base}\" ha sido capturado correctamente." +
                            "\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Llamada a método
            Console.WriteLine("\n\t\t:.:. IMPRESIÓN DE RESULTADOS .:.:");
            calcularTablaDividir(numero_base, numero_acumulador, resultado, c);
            Console.Write("\n\tCálculos finalizados, presione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
        //Declaración de procedimiento recursivo directo
        static public void calcularTablaDividir(int numero_base, int numero_acumulador,int resultado, int c)
        {
            if (c < 12)
            {   //Se multiplica el acumulador entre el número base
                resultado = numero_acumulador / numero_base;
                Console.WriteLine($"\n\t{c + 1}.- {numero_acumulador} / {numero_base} = {resultado}");
                numero_acumulador += numero_base; c++; //Se le suma el número base al acumulador y el contador suma una unidad
                calcularTablaDividir(numero_base, numero_acumulador, resultado, c);
            }
        }
    }
}
