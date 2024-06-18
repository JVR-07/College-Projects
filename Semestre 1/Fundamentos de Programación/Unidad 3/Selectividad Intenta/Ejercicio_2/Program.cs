using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args){ // Machado Sanchez Javier 22211600
            double num1, resultado;
            Console.Title = "Selectividad Intenta_Ejercicio 2";
            Console.BackgroundColor = ConsoleColor.DarkGreen; Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\tCalculadora de raíz cuadrada");
            Console.Write("\n\t\tIngrese el número al que desea sacarle raíz: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue; num1 = Convert.ToDouble(Console.ReadLine());
            // Inicialización de selectiva intenta
            try{ // Operación que se desea realizar
                comprobar(num1); resultado = Math.Sqrt(num1); resultado = Math.Round(resultado, 4);
                Console.WriteLine("\tLa raíz cuadrada de " + num1 + " es: " + resultado);}
            catch (ArgumentException){ // Mensaje en caso de no poder ejercutarse la acción
                Console.WriteLine("\tOperación inválida. No puede obtener una raíz cuadrada de un número negativo.");}
            catch (FormatException){ // Mensaje en caso de no poder ejercutarse la acción
                Console.WriteLine("\tOperación inválida. Ingrese un número por favor.");}
            finally{// Mensaje final. Se muestra siempre
                Console.WriteLine("\n\t\tPresione la tecla <INTRO> para cerrar el programa...");}
            while (Console.ReadKey().Key != ConsoleKey.Enter);}
        static void comprobar(double num1){// Funcion para comprobar que el número ingreaso sea positivo o neutro
            if (num1 < 0){throw new ArgumentException();}}}}