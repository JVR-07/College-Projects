using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_D
{
    internal class Program
    {
        static void Main(string[] args){ // Machado Sanchez Javier 22211600            
            Console.Title = "Selectiviad Múltiple_Ejercicio D";
            Console.BackgroundColor = ConsoleColor.DarkBlue; Console.Clear();
            Console.ForegroundColor = ConsoleColor.White; string num;
            Console.WriteLine("\t\tCONVERSOR DE UNIDADES DE MEDIDA\n\t**MENÚ**\n\t-(1) Convertir grados Centígrados a Fahrenheit\n\t-(2) Convertir Metros a Yardas\n\t-(3) Convertir Pulgadas a Centimetros\n\t-(4) Salir\n\t\tIngrese el número de la operación deseada:");
            Console.ForegroundColor = ConsoleColor.Cyan; num = Console.ReadLine();
            //  Inicialización de selectiva múltiple
            switch (num){ // Se evalua el contenido de la variable
                // Diferentes casos posibles
                case "1":double C, F; 
                    Console.WriteLine("\tIngrese la temperatura en grados centígrados: "); C = Convert.ToDouble(Console.ReadLine());
                    F = (C * 9 / 5) + 32; F = Math.Round(F, 1);
                    Console.WriteLine("\tLa temperatura en grados Fahrenheit es: " + F); break;
                case "2":double M, Y;
                    Console.WriteLine("\tIngrese la longitud en metros: "); M = Convert.ToDouble(Console.ReadLine());
                    Y = M * 1.094; Y = Math.Round(Y, 4);
                    Console.WriteLine("\tLa distancia en Yardas es: " + Y); break;
                case "3":double P, CM;
                    Console.WriteLine("\tIngrese la longitud en pulgadas: "); P = Convert.ToDouble(Console.ReadLine());
                    CM = P * 2.54; CM = Math.Round(CM, 4);
                    Console.WriteLine("\tLa distancia en centimetros es: " + CM); break;
                case "4":Console.WriteLine("\tSe cerrará el programa."); break;
                default: // No se cumple ningún caso
                    Console.WriteLine("\tPor favor, ingrese un código válido"); break;}
            Console.WriteLine("\t\tPresione la tecla <INTRO> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Enter);}}}