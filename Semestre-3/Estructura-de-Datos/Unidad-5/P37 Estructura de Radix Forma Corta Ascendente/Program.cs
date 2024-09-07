using System;

namespace P37_Estructura_de_Radix_Forma_Corta_Ascendente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "P37 Estructura de Radix Forma Corta Ascendente";
            //Declaración de variables locales
            int[] NumeroEmpleados = new int[15];

            //Capturando datos
            Console.WriteLine("\n\t\t.: CAPTURA DE DATOS");
            for (int i = 0; i < NumeroEmpleados.Length; i++)
            {
                Console.Write($"\n\t[{i + 1}] - Ingrese un número entero: ");
                NumeroEmpleados[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"\n\tSe ha capturado el número {NumeroEmpleados[i]} correctamente");
            }
            Console.Write("\n\tSe han capturado los números correctamente, presione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();

            //Mostrando arreglo original
            Console.WriteLine("\n\t\t.: MOSTRANDO ARREGLO ORIGINAL :.");
            Console.Write("\n\n\t");
            for (int i = 0; i < NumeroEmpleados.Length; i++)
            {
                Console.Write($"[{NumeroEmpleados[i]}]");
            }
            Console.Write("\n\n\tArreglo mostrado, presione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter);

            //Llamada a método radix
            RadixSort(ref NumeroEmpleados);

            //Mostrando arreglo ordenado
            Console.WriteLine("\n\n\t\t.: MOSTRANDO ARREGLO ORIGINAL :.");
            Console.Write("\n\n\t");
            for (int i = 0; i < NumeroEmpleados.Length; i++)
            {
                Console.Write($"[{NumeroEmpleados[i]}]");
            }
            Console.Write("\n\n\tArreglo mostrado, presione la tecla <ESC> para salir del programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }

        public static void RadixSort(ref int[] Numero)
        {
            //Declarando contadores
            int i,j;

            //Arreglo temporal
            int[] temp = new int[Numero.Length];

            //Ciclos para ordenamiento
            for(int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for(i = 0; i < Numero.Length; ++i)
                {
                    bool move = (Numero[i] << shift) >= 0;

                    if(shift == 0 ? !move : move)
                    {
                        Numero[i - j] = Numero[i];
                    }
                    else
                    {
                        temp[j++] = Numero[i];
                    }
                }
                Array.Copy(temp, 0, Numero, Numero.Length - j, j);
            }
        }
    }
}
