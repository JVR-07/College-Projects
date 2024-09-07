using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        { // Machado Sanchez Javier
            int edad; // Declaración de variables
            string nombre; // Declaración de variables 
            Console.BackgroundColor = ConsoleColor.Black; // Cambiar color de fondo de consola
            Console.Clear(); // Limpiar color default de consola.
            Console.ForegroundColor = ConsoleColor.Magenta; // Cambiar color de fuente
            Console.Title = "Practica selectiva simple"; // Titulo de la ventana de consola
            Console.WriteLine("\n\t\tVerifica si eres mayor de edad."); // Muestra mensaje en pantalla
            Console.ForegroundColor = ConsoleColor.Green; // Cambia color de fuente
            Console.WriteLine("\tCaptura tu nombre"); // Muestra mensaje en pantalla
            nombre = Console.ReadLine(); // Lectura de datos del usuario
            Console.WriteLine("\tCaptura tu edad"); // Mostrar mensaje en pantalla
            edad = Convert.ToInt16(Console.ReadLine()); // Proceso
            // Selectiva simple
            if (edad >= 18){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Felicidades, eres mayor de edad");
                Console.ReadKey();}}}}