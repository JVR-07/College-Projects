using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2___Condición_Compuesta
{
    internal class Program
    {
        static void Main(string[] args) 
        {
        //Machado Sanchez Javier 22211600
        //Declaración de variables
            int p1, p2, p3, promP;
            Random random = new Random();
            Console.Title = "Actividad B";
            Console.BackgroundColor = ConsoleColor.White; Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            //Despliegue de mensajes para captura
            Console.WriteLine("\n\t\t\tVERIFICADOR DE PARTICIPANTES PARA LA CARRERA"); Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\t\tHISTORIAL DE PRUEBAS:"); Console.ForegroundColor = ConsoleColor.Green;
            p1 = random.Next(05, 35);  Console.WriteLine("\tTiempo de la primer prueba(minutos): " + p1);
            p2 = random.Next(15, 45);  Console.WriteLine("\tTiempo de la segunda prueba(minutos): " + p2);
            p3 = random.Next(25, 60);  Console.WriteLine("\tTiempo de la tercer prueba(minutos: " + p3); 
            promP = (p1 + p2 + p3) / 3;
            // Selectiva compuesta
            if (promP >= 25 && promP <= 35){ // Condicion compuesta de dos condiciones
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\tFelicidades, has sido seleccionado para la carrera de 100 km. Tu promedio de las tres pruebas es: " + promP + " minutos.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t Presione la tecla <ESC> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Escape);}
            else{Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\t\tLo sentimos, no quedaste seleccionado para la carrera de 100 km. Tu promedio de las tres pruebas es: " + promP + " minutos.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t Presione la tecla <ESC> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
        }
    }
}