using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args){ //Machado Sanchez Javier 22211600
            Console.Title = "Ejercicio 2 While";
            Console.BackgroundColor = ConsoleColor.Black;Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            int menu = 0, C = 2;double Num;bool primo = true;
            Console.Write("\t\tPROGRAMA PARA DETERMINAR NUMEROS PRIMOS\n\n\t\tMENÚ\n\tVerificar (1)\n\tSalir (2)");
            try{ // Ciclo While, corre el bloque de instrucciones si y solo si la condición es verdadera.
                while (menu != 2){ // Condición
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\tIngrese el número de la operación que desea realizar: ");
                    menu = Convert.ToInt16(Console.ReadLine());
                    switch (menu){
                        case 1:primo = true;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("\n\tIngrese el número que desea comprobar: ");
                            Num = Convert.ToDouble(Console.ReadLine());
                       while ((C < Num) && (primo)){ // Ciclo While, corre el bloque de instrucciones si y solo si la condición es verdadera.
                            if ((Num % C) == 0){primo = false;}
                            else{C++;}}
                       if (primo){Console.ForegroundColor = ConsoleColor.Yellow;
                           Console.WriteLine("\t" + Num + ", es un número primo.");
                           Console.WriteLine("\tIngrese 2 si desea salir, ingrese 1 si desea comprobar otro número");}
                       else{Console.ForegroundColor = ConsoleColor.Yellow;
                           Console.WriteLine("\t" + Num + ", no es un número primo.");
                           Console.WriteLine("\tIngrese 2 si desea salir, ingrese 1 si desea comprobar otro número");}
                       break;
                        case 2:Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\tEl proceso ha terminado.\n\tPresione la tecla <INTRO> para salir...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter);break;}}}
            catch (FormatException){
                Console.WriteLine("Se ha detectado un número inválido.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\tEl proceso ha terminado.\n\tPresione la tecla <INTRO> para salir...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);}}}}