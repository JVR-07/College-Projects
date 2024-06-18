using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C
{
    internal class Program
    {
        static void Main(string[] args){ // Machado Sanchez Javier 22211600
            Console.Title = "Selectvidad Múltiple_Ejercicio C";
            Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green; string num;
            Console.WriteLine("\t\tMostrar letras correspondientes a teclado númerico de un teléfono\n\n\t**MENÚ**\n\t- 00\n\t- 01\n\t- 02\n\t- 03\n\t- 04\n\t- 05\n\t- 06\n\t- 07\n\t- 08\n\t- 09\n\n\t\tIngrese el número del teclado teléfonico: ");
            Console.ForegroundColor = ConsoleColor.Red; num = Console.ReadLine();
            //  Inicialización de selectiva múltiple
            switch (num){ // Se evalua el contenido de la variable
                // Diferentes casos posibles
                case "01":Console.WriteLine("\tNo hay ninguna letra correspondiente al número " + num);break; 
                case "02":Console.WriteLine("\tLas letras correspondientes a " + num + " son: A, B, C");break;
                case "03":Console.WriteLine("\tLas letras correspondientes a " + num + " son: D, E, F");break;
                case "04":Console.WriteLine("\tLas letras correspondientes a " + num + " son: G, H, I");break;
                case "05":Console.WriteLine("\tLas letras correspondientes a " + num + " son: J, K, L");break;
                case "06":Console.WriteLine("\tLas letras correspondientes a " + num + " son: M, N, O");break;
                case "07":Console.WriteLine("\tLas letras correspondientes a " + num + " son: P, Q, R, S");break;
                case "08":Console.WriteLine("\tLas letras correspondientes a " + num + " son: T, U, V");break;
                case "09":Console.WriteLine("\tLas letras correspondientes a " + num + " son: W, X, Y, Z");break;
                case "00":Console.WriteLine("\tNo hay ninguna letra correspondiente al número " + num);break;
                default: // No se cumple ningún caso
                Console.WriteLine("\tEl número " + num + " no es válido, ingrese otro por favor."); break;}
            Console.WriteLine("\t\tPresione la tecla <INTRO> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Enter){}}}}