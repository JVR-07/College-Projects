using System;

namespace P38_Intercalacion_Simple_Metodo_1_Descendente
{
    internal class Program
    {
        //Inicio declaración método IntercalacionSimpleM1

        public static void IntercalacionSimpleM1(ref int[] ArregloOriginal)
        {
            //Inicio declaración de variables locales

            int i, j, izquierda, derecha, mitad, auxiliar;

            //Fin declaración de variables locales

            //Inicio bloque de instrucciones

            for(i = 1; i < ArregloOriginal.Length;i++)
            {
                auxiliar = ArregloOriginal[i];
                izquierda = 0;
                derecha = i - 1;

                while(izquierda <= derecha)
                {
                    mitad = (izquierda + derecha) / 2;

                    if (auxiliar >= ArregloOriginal[mitad]) derecha = mitad - 1;
                    else izquierda = mitad + 1;
                }
               
                j = i - 1;

                while(j >= izquierda)
                {
                    ArregloOriginal[j + 1] = ArregloOriginal[j];
                    j--;
                }
                ArregloOriginal[izquierda] = auxiliar;
            }

            //Fin bloque de instrucciones
        }

        //Fin declaración método IntercalacionSimpleM1


        //Inicio declaración método MostrarArreglo

        public static void MostrarArreglo(int[] Arreglo)
        {
            for(int i = 0; i < Arreglo.Length; i++)
            {
                Console.Write($"[{Arreglo[i]}]");
            }
        }

        //Fin declaración método MostrarArreglo


        static void Main(string[] args)
        {
            Console.Title = "P38 Intercalación Simple Método 1 Descendente";
            //Inicio declaración de variables

            int[] ArregloCalificaciones = new int[25];

            //Fin declaración de variables

            Console.WriteLine("\n\t\t.: CAPTURA DE CALIFICACIONES :.");
            for(int i = 0; i < ArregloCalificaciones.Length; i++)
            {
                Console.Write($"\n\n\t[{i + 1}] - Ingrese una calificación: ");
                ArregloCalificaciones[i] = int.Parse(Console.ReadLine());
                Console.Write($"\n\tLa calificación {ArregloCalificaciones[i]} ha sido capturada correctamente");
            }      

            Console.Write("\n\n\tLas calificaciones han sido capturadas correctamente" +
                          "\n\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();

            Console.Write("\n\n\t\t.: MOSTRANDO ARREGLO ORIGINAL :.\n\n\t");

            //Llamada a método para mostrar arreglo
            MostrarArreglo(ArregloCalificaciones);

            //LLamada a método para ordenar
            IntercalacionSimpleM1(ref ArregloCalificaciones);

            Console.Write("\n\n\t\t.: MOSTRANDO ARREGLO ORDENADO DESCENDENTE :.\n\n\t");
            MostrarArreglo(ArregloCalificaciones);

            Console.Write("\n\n\tLas calificaciones han sido ordenadas correctamente" +
                          "\n\n\tPresione la tecla <ESC> para salir del menú...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ; Console.Clear();
        }
    }
}
