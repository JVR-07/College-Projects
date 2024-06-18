using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_Manejando_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machado Sanchez Javier - 22211600

            Console.Title = "Manejando HashSet";

            bool error;
            //Declaración de variables para los conjuntos
            HashSet<int> Conjunto_A = new HashSet<int>();
            HashSet<int> Conjunto_B = new HashSet<int>();
            HashSet<int> Conjunto_C = new HashSet<int>();
            HashSet<int> Conjunto_D = new HashSet<int>();

            //Captura de datos del conjunto A
            do
            {
                try
                {
                    Console.WriteLine("\n\t\t.: CONJUNTO A :." +
                                        "\n\t| Ingrese los promedios del conjunto |");
                    Capturar(Conjunto_A, 5);
                    error = false;
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: ALGO HA SALIDO MAL :.");
                    Console.Write("\n\tMensaje de error: {0}" +
                                "\n\n\tSe reiniciará la captura de datos." +
                                  "\n\tPresione la tecla <INTRO> para continuar...", e.Message);
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    Console.Clear();
                    error = true;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: ALGO HA SALIDO MAL :.");
                    Console.Write("\n\tMensaje de error: {0}" +
                                "\n\n\tSe reiniciará la captura de datos." +
                                  "\n\tPresione la tecla <INTRO> para continuar...", e.Message);
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    Console.Clear();
                    error = true;
                }
            } while (error == true);
            Console.Write("\n\n\tLos datos del conjunto han sido capturados correctamente." +
                            "\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Captura de datos del conjunto B
            do
            {
                try
                {
                    Console.WriteLine("\n\t\t.: CONJUNTO B :." +
                                        "\n\t| Ingrese los promedios del conjunto |");
                    Capturar(Conjunto_B, 3);
                    error = false;
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: ALGO HA SALIDO MAL :.");
                    Console.Write("\n\tMensaje de error: {0}" +
                                "\n\n\tSe reiniciará la captura de datos." +
                                  "\n\tPresione la tecla <INTRO> para continuar...", e.Message);
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    Console.Clear();
                    error = true;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: ALGO HA SALIDO MAL :.");
                    Console.Write("\n\tMensaje de error: {0}" +
                                "\n\n\tSe reiniciará la captura de datos." +
                                  "\n\tPresione la tecla <INTRO> para continuar...", e.Message);
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    Console.Clear();
                    error = true;
                }
            } while (error == true);
            Console.Write("\n\n\tLos datos del conjunto han sido capturados correctamente." +
                            "\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Captura de datos del conjunto C
            do
            {
                try
                {
                    Console.WriteLine("\n\t\t.: CONJUNTO C :." +
                                        "\n\t| Ingrese los promedios del conjunto |");
                    Capturar(Conjunto_C, 6);
                    error = false;
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: ALGO HA SALIDO MAL :.");
                    Console.Write("\n\tMensaje de error: {0}" +
                                "\n\n\tSe reiniciará la captura de datos." +
                                  "\n\tPresione la tecla <INTRO> para continuar...", e.Message);
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    Console.Clear();
                    error = true;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: ALGO HA SALIDO MAL :.");
                    Console.Write("\n\tMensaje de error: {0}" +
                                "\n\n\tSe reiniciará la captura de datos." +
                                  "\n\tPresione la tecla <INTRO> para continuar...", e.Message);
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    Console.Clear();
                    error = true;
                }
            } while (error == true);
            Console.Write("\n\n\tLos datos del conjunto han sido capturados correctamente." +
                            "\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Captura de datos del conjunto D
            do
            {
                try
                {
                    Console.WriteLine("\n\t\t.: CONJUNTO D :." +
                                        "\n\t| Ingrese los promedios del conjunto |");
                    Capturar(Conjunto_D, 7);
                    error = false;
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: ALGO HA SALIDO MAL :.");
                    Console.Write("\n\tMensaje de error: {0}" +
                                "\n\n\tSe reiniciará la captura de datos." +
                                  "\n\tPresione la tecla <INTRO> para continuar...", e.Message);
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    Console.Clear();
                    error = true;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: ALGO HA SALIDO MAL :.");
                    Console.Write("\n\tMensaje de error: {0}" +
                                "\n\n\tSe reiniciará la captura de datos." +
                                  "\n\tPresione la tecla <INTRO> para continuar...", e.Message);
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    Console.Clear();
                    error = true;
                }
            } while (error == true);
            Console.Write("\n\n\tLos datos del conjunto han sido capturados correctamente." +
                            "\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();


            //Declaración de conjuntos para resultados y cálculos
            HashSet<int> Union = new HashSet<int>(Conjunto_A);
            Union.UnionWith(Conjunto_C);
            HashSet<int> Interseccion = new HashSet<int>(Conjunto_B);
            Interseccion.IntersectWith(Conjunto_D);
            HashSet<int> Diferencia = new HashSet<int>(Conjunto_C);
            Diferencia.ExceptWith(Conjunto_B);
            HashSet<int> Diferencia_Simetrica = new HashSet<int>(Conjunto_D);
            Diferencia_Simetrica.SymmetricExceptWith(Conjunto_A);

            //Impresión de resultados
            Console.WriteLine("\n\t\t.: IMPRESIÓN DE RESULTADOS :.");
            Console.Write("\n  Conjunto A:");
            Mostrar(Conjunto_A);
            Console.Write("\n  Conjunto B:");
            Mostrar(Conjunto_B);
            Console.Write("\n  Conjunto C:");
            Mostrar(Conjunto_C);
            Console.Write("\n  Conjunto D:");
            Mostrar(Conjunto_D);
            Console.Write("\n  Unión A con C:");
            Mostrar(Union);
            Console.Write("\n  Intersección B con D:");
            Mostrar(Interseccion);
            Console.Write("\n  Diferencia C con B:");
            Mostrar(Diferencia);
            Console.Write("\n  Diferencia Simétrica D con A:");
            Mostrar(Diferencia_Simetrica);

            Console.Write("\n\n\tCálculos mostrados correctamente." +
                            "\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
        //Función estática para mostrar los conjuntos con un formato estándar
        static void Mostrar(HashSet<int> conjunto)
        {
            Console.Write(" {");
            foreach (int i in conjunto)
            {
                Console.Write(" {0},", i);
            }
            Console.Write("\b }");
        }
        //Función estática para capturar los elementos de los conjuntos
        static void Capturar(HashSet<int> conjunto, int j) 
        {
            int aux = 0;
            for (int i = 0; i < j; i++)
            {
                Console.Write("\n\tPromedio {0}: ", i + 1);
                aux = int.Parse(Console.ReadLine());
                if (aux >= 0 && aux <= 100)
                {
                    conjunto.Add(aux);
                }
                else { throw new ArgumentOutOfRangeException(); }
            }
        }
    }
}
