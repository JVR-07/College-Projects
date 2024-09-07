using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_B
{
    internal class Program
    {
        static void Main(string[] args){ // Machado Sanchez Javier 22211600
            Console.Title = "Selectiva Múltiple_Ejercicio B";
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string num;
            Console.WriteLine("\t\tMostrar día de la semana con número\n\n\t**MENÚ**\n\t- 01\n\t- 02\n\t- 03\n\t- 04\n\t- 05\n\t- 06\n\t- 07\n\n\tIngrese el número del día de la semana:");
            Console.ForegroundColor = ConsoleColor.Green; num = Console.ReadLine();
            //  Inicialización de selectiva múltiple
            switch (num){ // Se evalua el contenido de la variable
                // Diferentes casos posibles
                case "01":Console.WriteLine("\tEl día " + num + " corresponde a Domingo.");break;
                case "02":Console.WriteLine("\n\tEl día " + num + " corresponde a Lunes.");break;
                case "03":Console.WriteLine("\tEl día " + num + " corresponde a Martes.");break;
                case "04":Console.WriteLine("\tEl día " + num + " corresponde a Miércoles.");break;
                case "05":Console.WriteLine("\tEl día " + num + " corresponde a Jueves.");break;
                case "06":Console.WriteLine("\tEl día " + num + " corresponde a Viernes.");break;
                case "07":Console.WriteLine("\tEl día " + num + " corresponde a Sábado.");break;
                default: // no se cumple ningún caso
                Console.WriteLine("\tEl día " + num + " no corresponde a nigún día de la semana. Aseguresé de escribir bien el número.");break;}
            Console.WriteLine("\n\tPresione la tecla <INTRO> para cerrar la consola...");
            while (Console.ReadKey().Key != ConsoleKey.Enter);}}}