using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A
{
    internal class Program
    {
        static void Main(string[] args){ //Machado Sanchez Javier 22211600
            double Sueldo_Nt, Sueldo; string cod, nombre, dep, CodP;
            Console.Title = "Actividad A";
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\t\t\tSELECCIÓN DE AUMENTO PARA TRABAJADORES"); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\tDATOS PERSONALES:"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tCódigo de empleado:"); cod = Console.ReadLine();
            Console.WriteLine("\tNombre:"); nombre = Console.ReadLine();
            Console.WriteLine("\tDepartamento:"); dep = Console.ReadLine();
            Console.WriteLine("\tSueldo:"); Sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\tIngrese el código del proyecto:"); CodP = Console.ReadLine();
            //Condición compuesta de dos o más condiciones
            if (CodP == "P" || CodP == "p"){ 
                Sueldo_Nt = (Sueldo * 0.3) + Sueldo; 
                Sueldo_Nt = Math.Round(Sueldo_Nt, 2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\tFelicidades " + nombre + ", del departamento de " + dep + " con código " + cod + " recibió un aumento de sueldo del 30% por participar en el proyecto. Su nuevo sueldo neto es: " + Sueldo_Nt);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t Presione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);}
            else{Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tLo sentimos, no formaste parte del proyecto; por tanto, no podemos darte ningún aumento.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t Presione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);}}}}