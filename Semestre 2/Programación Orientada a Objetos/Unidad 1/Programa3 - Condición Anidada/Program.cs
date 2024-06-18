using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3___Condición_Anidada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machado Sanchez Javier. 22211600
            // Mostrar mes del año ingresando su número
            //Declaración de variables
            Random random = new Random();
            int numeroDelMes = 0;
            numeroDelMes = random.Next(1, 12);
            //Procedimiento
            if (numeroDelMes == 1)
            {
                Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Enero");
            }
            else if (numeroDelMes == 2) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Febrero"); }
            else if (numeroDelMes == 3) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Marzo"); }
            else if (numeroDelMes == 4) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Abril"); }
            else if (numeroDelMes == 5) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Mayo"); }
            else if (numeroDelMes == 6) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Junio"); }
            else if (numeroDelMes == 7) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Julio"); }
            else if (numeroDelMes == 8) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Agosto"); }
            else if (numeroDelMes == 9) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Septiembre"); }
            else if (numeroDelMes == 10) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Octubre"); }
            else if (numeroDelMes == 11) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Noviembre"); }
            else if (numeroDelMes == 12) { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " es: Diciembre"); }
            else { Console.WriteLine("El mes correspondiente a " + numeroDelMes + " no existe."); }

            Console.Write("El proceso ha finalizado, presione <ESC> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}