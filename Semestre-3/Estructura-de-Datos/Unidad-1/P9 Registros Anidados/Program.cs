using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P9_Registros_Anidados
{
    internal class Program
    {   //Estructura principal
        struct structLibro
        {
            public string codigo;
            public string nombre;
            public string autor;
            public structAreaLibro area_conocimiento;
        }
        //Estructura que estará anidada
        struct structAreaLibro
        {
            public string area;
            public int ejemplares;
        }
        static void Main(string[] args)
        {
            //Declaración de variables auxiliares
            int c = 0;
            char reset = ' ';
            //Declaración de objeto para la estructura
            structLibro[] Libro = new structLibro[100];

            //Captura de datos
            do
            {
                Console.WriteLine("\n\t\t.: CAPTURA DE DATOS DEL LIBRO {0} :." +
                                    "\n\t| Ingrese los datos que se le pidan |", c + 1);
                Console.Write("\n\tNombre del libro: "); Libro[c].nombre = Console.ReadLine();
                Console.Write("\n\tCódigo del libro: "); Libro[c].codigo = Console.ReadLine();
                Console.Write("\n\tAutor del libro: "); Libro[c].autor = Console.ReadLine();
                Console.Write("\n\tÁrea del libro: "); Libro[c].area_conocimiento.area = Console.ReadLine();
                Console.Write("\n\tCantidad de ejemplares: "); 
                Libro[c].area_conocimiento.ejemplares = int.Parse(Console.ReadLine());

                Console.Write("\n\n\tDatos capturados correctamente." +
                                "\n\t¿Desea realiza otro registro? S | N" +
                                "\n\tIngrese la letra de la opción deseada: ");
                reset = char.Parse(Console.ReadLine().ToUpper());
                if (reset == 'S')
                {
                    Console.Write("\n\tPresione la tecla <INTRO> para ingresar otra persona...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                }
                else if (reset == 'N')
                {
                    Console.Write("\n\tPresione la tecla <Esc> para terminar la captura...");
                    while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                }
                Console.Clear();
                c++;
            }while(reset == 'S') ;

            //Impresión de datos
            Console.WriteLine("\n\t\t.: IMPRESIÓN DE DATOS DEL LIBRO :.");
            Console.WriteLine("\n\tNombre\t\t\t\tCódigo\tAutor\t\tÁrea\t\tEjemplares");
            for (int i = 0; i < c; i++) 
            {
                Console.Write("\n\t{0}\t{1}\t\t{2}\t\t{3}\t\t{4}", Libro[i].nombre, Libro[i].codigo, Libro[i].autor,
                              Libro[i].area_conocimiento.area, Libro[i].area_conocimiento.ejemplares);
            }
            Console.Write("\n\n\tDatos mostrados correctamente." +
                            "\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}