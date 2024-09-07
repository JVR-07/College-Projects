using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Machado Sanchez Javier 22211600
            double A; // Declaración de variable 
            Console.BackgroundColor = ConsoleColor.White; // Cambia color de fondo
            Console.Clear(); // Limpia color default de consola 
            Console.ForegroundColor = ConsoleColor.DarkBlue; // Cambia color de fuente
            Console.Title = "Verificador de ángulos rectos"; // Cambia titulo de consola
            Console.ForegroundColor = ConsoleColor.DarkRed; // Cambia color de fuente 
            Console.WriteLine("\t\t***VERIFICADOR DE ÁNGULOS RECTOS***\n"); // Muestra mensaje en pantalla 
            Console.ForegroundColor = ConsoleColor.DarkGreen; // Cambia color de fuente
            Console.WriteLine("\tPor favor, ingrese el ángulo del triángulo:"); // Muestra mensaje en pantalla
            A = Convert.ToDouble(Console.ReadLine()); // Convierte y lee el dato del usuario
            // Selectiva simple
            if (A == 90){ // Condición para inicializar bloque de instrucciones
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\tEn efecto, es un ángulo recto de 90 grados\n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\tPresione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }} // Permite seleccionar una tecla especifica para cerrar la consola
            else{Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\tDefinitivamente, no es un ángulo recto de 90 grados\n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\tPresione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }}}}} // Permite seleccionar una tecla especifica para cerrar la consola