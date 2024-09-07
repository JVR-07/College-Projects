using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_Conjuntos_Colores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machado Sanchez Javier - 22211600

            Console.Title = "Conjunto Colores";

            //Declaración de variables para los conjuntos
            HashSet<string> Conjunto_A = new HashSet<string>();
            HashSet<string> Conjunto_B = new HashSet<string>();

            //Captura de datos del conjunto A
            Console.WriteLine("\n\t\t.: CONJUNTO A :." +
                                "\n\t| Ingrese los colores del conjunto |");
            for(int i = 0; i < 7; i++)
            {
                Console.Write("\n\tColor {0}: ",i + 1);
                Conjunto_A.Add(Console.ReadLine());
            }
            Console.Write("\n\n\tLos datos del conjunto han sido capturados correctamente." +
                            "\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Captura de datos del conjunto B
            Console.WriteLine("\n\t\t.: CONJUNTO B :." +
                                "\n\t| Ingrese los colores del conjunto |");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\n\tColor {0}: ", i + 1);
                Conjunto_B.Add(Console.ReadLine());
            }
            Console.Write("\n\n\tLos datos del conjunto han sido capturados correctamente." +
                            "\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Declaración de conjuntos para resultados y cálculos.
            HashSet<string> Union = new HashSet<string>(Conjunto_A);
            Union.UnionWith(Conjunto_B);
            HashSet<string> Interseccion = new HashSet<string>(Conjunto_B);
            Interseccion.IntersectWith(Conjunto_A);
            HashSet<string> Diferencia = new HashSet<string>(Conjunto_A);
            Diferencia.ExceptWith(Conjunto_B);
            HashSet<string> Diferencia_Simetrica = new HashSet<string>(Conjunto_B);
            Diferencia_Simetrica.SymmetricExceptWith(Conjunto_A);

            //Impresión de resultados
            Console.WriteLine("\n\t\t.: IMPRESIÓN DE RESULTADOS :.");
            Console.Write("\n  Conjunto A:");
            Mostrar(Conjunto_A);
            Console.Write("\n  Conjunto B:");
            Mostrar(Conjunto_B);
            Console.Write("\n  Unión A con B:");
            Mostrar(Union);
            Console.Write("\n  Intersección B con A:");
            Mostrar(Interseccion);
            Console.Write("\n  Diferencia A con B:");
            Mostrar(Diferencia);
            Console.Write("\n  Diferencia Simétrica B con A:");
            Mostrar(Diferencia_Simetrica);

            Console.Write("\n\n\tCálculos mostrados correctamente." +
                            "\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        //Función estática para mostrar los conjuntos con un formato estándar
        static void Mostrar(HashSet<string> conjunto)
        {
            Console.Write(" {");
            foreach (string i in conjunto)
            {
                Console.Write(" {0},", i);
            }
            Console.Write("\b }");
        }
    }
}
