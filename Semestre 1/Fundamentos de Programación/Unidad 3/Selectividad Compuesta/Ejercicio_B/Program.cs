using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_B
{
    internal class Program
    {
        static void Main(string[] args){ //Machado Sanchez Javier 22211600 
            double p1, p2, p3, promP;
            Console.Title = "Actividad B";
            Console.BackgroundColor = ConsoleColor.White; Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t\t\tVERIFICADOR DE PARTICIPANTES PARA LA CARRERA"); Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\t\tHISTORIAL DE PRUEBAS:"); Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tTiempo de la primer prueba(minutos):"); p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\tTiempo de la segunda prueba(minutos):"); p2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\tTiempo de la tercer prueba(minutos:"); p3 = Convert.ToDouble(Console.ReadLine());
            promP = (p1 + p2 + p3) / 3; promP = Math.Round(promP, 2);
            // Selectiva compuesta
            if (promP >= 25 && promP <= 35){ // Condicion compuesta de dos condiciones
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\tFelicidades, has sido seleccionado para la carrera de 100 km. Tu promedio de las tres pruebas es: " + promP + " minutos.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Presione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);}
            else{Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\tLo sentimos, no quedaste seleccionado para la carrera de 100 km. Tu promedio de las tres pruebas es: " + promP + " minutos.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Presione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);}}}}