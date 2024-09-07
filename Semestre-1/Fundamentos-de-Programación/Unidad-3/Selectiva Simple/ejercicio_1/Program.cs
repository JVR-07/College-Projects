using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args){   // Machado Sanchez Javier 22211600
            int age; // Declaración de variables 
            string name; // Declaración de variables 
            Console.BackgroundColor=ConsoleColor.Yellow; // Cambia color de fondo 
            Console.Clear(); // Limpia color default de consola
            Console.Title="Practica uno de selectivida simple"; // Cambia título de la consola
            Console.ForegroundColor=ConsoleColor.Black; // Cambia color de fuente 
            Console.WriteLine("\t\tIngrese su edad:"); // Muestra mensaje en pantalla 
            age=Convert.ToInt32(Console.ReadLine()); // Convierte a tipo int y lee datos del usuario
            Console.ForegroundColor=ConsoleColor.Magenta; // Cambia color de fuente 
            Console.WriteLine("\t\tIngrese su nombre:"); // Muestra mensaje en pantalla 
            name=Console.ReadLine(); // Lee datos del usuario
            //Selectiva simple
            if(age>=18){ // Condicion para llevar a cabo el bloque de instrucciones
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("\t\t"+name+", Eres mayor de edad, tienes "+age+" años.");
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("\n\tPresione la tecla <INTRO> para salir...");
                while(Console.ReadKey().Key!=ConsoleKey.Enter);} // Permite seleccionar una tecla especifica para cerrar la consola
            else{Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("\n\t"+name +", No eres mayor de edad, tienes "+age+" años.");
                Console.ForegroundColor=ConsoleColor.DarkRed;
                Console.WriteLine("\n\tPresione la tecla <INTRO> para salir...");
                while(Console.ReadKey().Key!=ConsoleKey.Enter);}}}} // Permite seleccionar una tecla especifica para cerrar la consola