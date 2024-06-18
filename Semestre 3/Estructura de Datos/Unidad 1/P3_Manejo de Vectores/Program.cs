using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracrtica3_Manejo_de_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machado Sanchez Javier - 22211600

            string[] Lista_Alumnos = new string[5];
            int[] Lista_Promedios = new int[5];
            float promedio = 0;

            Console.WriteLine("\n\t\t.: CAPTURA DE PROMEDIOS :.");
            for (int i = 0; i < Lista_Alumnos.Length; i++)
            {
                Console.Write("\n\t{0}.-Ingrese el nombre del alumno: ",i + 1);
                Lista_Alumnos[i] = Console.ReadLine();
                Console.Write("\n\t{0}.-Ingrese el promedio del alumno: ",i + 1);
                Lista_Promedios[i] = int.Parse(Console.ReadLine());
                promedio = promedio + Lista_Promedios[i];
            }
            Console.Write("\n\n\tDatos capturados correctamente." +
                             "\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter);
            Console.Clear();

            Console.WriteLine("\n\t\t.: IMPRESIÓN DE DATOS :.");
            Console.WriteLine("\n\tNombre del Alumno\t\t\tPromedio");
            for (int i = 0; i < Lista_Alumnos.Length; i++) 
            {
                Console.WriteLine("\n\t{0}\t\t\t{1}", Lista_Alumnos[i], Lista_Promedios[i]);

            }
            Console.WriteLine("\n\tPromedio General: " + promedio / Lista_Alumnos.Length);
            Console.Write("\n\t\tDatos mostrados correctamente" +
                             "\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
