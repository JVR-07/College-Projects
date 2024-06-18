using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Manejando_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machado Sanchez Javier - 22211600
            string[] pet_names = new string[10];

            //Captura de datos
            Console.WriteLine("\n\t\t.: CAPTURA DE DATOS :.");
            for (int i = 0; i < pet_names.Length; i++)
            {
                Console.Write("\n\t{0}.- Ingrese el nombre de la mascota: ",i + 1);
                pet_names[i] = Console.ReadLine();
            }
            Console.Write("\n\tDatos capturados correctamente." +
                          "\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Impresión de datos
            Console.WriteLine("\n\t\t.: IMPRESIÓN DE DATOS :.");
            for (int i = pet_names.Length; i > 0; i--)
            {
                Console.WriteLine("\n\tNombre de la mascota {0}: {1}",i, pet_names[i - 1]);
            }
            Console.Write("\n\tDatos mostrados correctamente." +
                          "\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
