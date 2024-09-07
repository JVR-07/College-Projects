using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args){ // Machado Sanchez Javier
            Single NumUser,NumMayor = 0;int c = 0;
            Console.Title = "Ejercicio 1 While";
            Console.BackgroundColor = ConsoleColor.White; Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\t\t CÁLCULA EL NÚMERO MAYOR \n\n\t Ingrese 15 números para determinar el mayor.\n\tnúmeros:");
            try{ // Ciclo While, corre el bloque de instrucciones si y solo si la condición es verdadera. 
                while (c < 15){ // Condición
                    Console.ForegroundColor = ConsoleColor.Blue;
                    c++;NumUser = Convert.ToSingle(Console.ReadLine());
                    if (NumUser >= NumMayor){NumMayor = NumUser;}}
                Console.WriteLine("\n\tEl número mayor es: {0}\t\nPresione la tecla <INTRO> para salir...", NumMayor);
                while (Console.ReadKey().Key != ConsoleKey.Enter);}
            catch (FormatException){
              Console.ForegroundColor = ConsoleColor.DarkRed;
              Console.WriteLine("\r\tSe ha ingresado uno o más datos inválidos. El programa se detendrá.\n\tPresione la tecla <INTRO> para salir...");
              while(Console.ReadKey().Key != ConsoleKey.Enter);}}}}