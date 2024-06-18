using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args){ // Machado Sanchez Javier 22211600
            double f; // Declaración de variables 
            Console.Title="Medidor de Intensidad de Frecuencias"; // Título de la consola
            Console.BackgroundColor=ConsoleColor.Black; // Cambiar color de fondo
            Console.Clear(); // Limpiar color default de la consola
            Console.ForegroundColor=ConsoleColor.Yellow; // Cambiar color de fuente
            Console.WriteLine("\t\t*****MEDIDOR DE INTENSIDAD DE FRECUENCIAS*****\n"); // Muestra mensaje en pantalla 
            Console.ForegroundColor=ConsoleColor.Cyan; // Cambia color de fuente
            Console.WriteLine("\tPor favor, ingrese la frecuencia alcanzada:"); // Muestra mensaje en pantalla 
            f=Convert.ToDouble(Console.ReadLine()); // Lee datos del usuario 
            // Selectiva simple
            if(f>60){ // Condición para inicializar bloque de instrucciones
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\tLa frecuencia es peligrosamente alta. Disminuyala, por favor.\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\tPresione la tecla <INTRO> para salir...");
          while(Console.ReadKey().Key!=ConsoleKey.Enter) { }} // Permite seleccionar una tecla especifica para cerrar la consola
            else{Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("\tLa frecuencia se encuntra en el rango aceptable. No se considera peligrosa.\n");
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine("\tPresione la tecla <INTRO> para salir...");
          while(Console.ReadKey().Key!=ConsoleKey.Enter){}}}}} // Permite seleccionar una tecla especifica para cerrar la consola