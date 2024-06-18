using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Creación de objetos
            clsBMX Mongoose = new clsBMX("Mongoose L40","Negro",52.07f,20,359.99f,false);
            clsCiclismo Gravel = new clsCiclismo("Asphalt R700","Blanca",51,18.50f,331.99f,1,14);
            clsMontaña Trek = new clsMontaña("Marlin 4", "Magenta", 55.30f, 29, 699.99f, 1, 21, 52);

            //Objeto BMX
            //Primera llamada a métodos
            Console.WriteLine("\n\t\t\t*** BMX ***");
            Mongoose.Acelerar();
            Console.WriteLine("\n");
            Mongoose.Frenar();
            Console.WriteLine("\n");
            Mongoose.Girar();
            Console.WriteLine("\n");
            Mongoose.Saltar();
            Console.WriteLine("\n");
            Console.WriteLine("\n\tPROCESO TERMINADO");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Segunda llamada a métodos
            Console.WriteLine("\n\t\t\t*** BMX ***");
            Console.WriteLine("\n");
            Mongoose.GetInfo();
            Console.WriteLine("\n\tPROCESO TERMINADO");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Objeto Bicicleta de Ciclismo
            //Primera llamada a métodos
            Console.WriteLine("\n\t\t\t*** Ciclismo ***");
            Gravel.Acelerar();
            Console.WriteLine("\n");
            Gravel.Frenar();
            Console.WriteLine("\n");
            Gravel.Girar();
            Console.WriteLine("\n");
            Console.WriteLine("\n\tPROCESO TERMINADO");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Segunda llamada a métodos
            Console.WriteLine("\n\t\t\t*** Ciclismo ***");
            Console.WriteLine("\n");
            Gravel.GetInfo();
            Console.WriteLine("\n\tPROCESO TERMINADO");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Objeto Bicicleta de Montaña
            //Primera llamada a métodos
            Console.WriteLine("\n\t\t\t*** Montaña ***");
            Trek.Acelerar();
            Console.WriteLine("\n");
            Trek.Frenar();
            Console.WriteLine("\n");
            Trek.Girar();
            Console.WriteLine("\n");
            Trek.Saltar();
            Console.WriteLine("\n");
            Console.WriteLine("\n\tPROCESO TERMINADO");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Segunda llamada a métodos
            Console.WriteLine("\n\t\t\t*** Montaña ***");
            Console.WriteLine("\n");
            Trek.GetInfo();
            Console.WriteLine("\n\tPROCESO TERMINADO");
            Console.Write("Presione la tecla <Esc> para salir del programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}