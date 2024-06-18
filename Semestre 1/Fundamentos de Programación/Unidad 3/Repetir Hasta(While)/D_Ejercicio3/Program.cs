using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args){ // Machado Sanchez Javier 22211600
            int TarjetaRegalo = 1000, Total = 0, NumCompra = 1;
            Console.Title = "Ejercicio 3 While";
            Console.BackgroundColor = ConsoleColor.White;Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\t\tMERCADO ONLINE\r\n\n\tTú sueldo actual es de $1000\r\n\n\t**MENÚ DE COMPRA**\r\n\t1.  Juego1:  $500\r\n\t2.  Juego2:  $1\r\n\t3.  Juego3:  $1000\r\n\t4.  Juego4:  $150\r\n\t5.  Juego5:  $890\r\n\t6.  Juego6:  $10\r\n\t7.  Juego7:  $300\r\n\t8.  Juego8:  $25\r\n\t9.  Juego9:  $700\r\n\t10. Juego10: $1500\r\n\t11. Salir\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            try{ // Ciclo While, corre el bloque de instrucciones si y solo si la condición es verdadera.
                while (NumCompra != 11 && TarjetaRegalo >= 1){ // Condiciones
                    Console.Write("\tIngrese el número del juego que desea: ");
                    NumCompra = Convert.ToInt16(Console.ReadLine());
                    switch (NumCompra){
                        case 1:TarjetaRegalo -= 500;Total += 500;
                            Console.WriteLine("\n\tHas gastado $500, tu sualdo actual es de ${0}.\n\tEl total de la compra es ${1}.", TarjetaRegalo, Total);break;
                        case 2:TarjetaRegalo -= 1;Total += 1;
                            Console.WriteLine("\n\tHas gastado $1, tu sualdo actual es de ${0}.\n\tEl total de la compra es ${1}.", TarjetaRegalo, Total);break;
                        case 3:TarjetaRegalo -= 1000;Total += 1000;
                            Console.WriteLine("\n\tHas gastado $1000, tu sualdo actual es de ${0}.\n\tEl total de la compra es ${1}.", TarjetaRegalo, Total);break;
                        case 4:TarjetaRegalo -= 150;Total += 150;
                            Console.WriteLine("\n\tHas gastado $150, tu sualdo actual es de ${0}.\n\tEl total de la compra es ${1}.", TarjetaRegalo, Total);break;
                        case 5:TarjetaRegalo -= 890;Total += 890;
                            Console.WriteLine("\n\tHas gastado $890, tu sualdo actual es de ${0}.\n\tEl total de la compra es ${1}.", TarjetaRegalo, Total);break;
                        case 6:TarjetaRegalo -= 10;Total += 10;
                            Console.WriteLine("\n\tHas gastado $10, tu sualdo actual es de ${0}.\n\tEl total de la compra es ${1}.", TarjetaRegalo, Total);break;
                        case 7:TarjetaRegalo -= 300;Total += 300;
                            Console.WriteLine("\n\tHas gastado $300, tu sualdo actual es de ${0}.\n\tEl total de la compra es ${1}.", TarjetaRegalo, Total);break;
                        case 8:TarjetaRegalo -= 25;Total += 25;
                            Console.WriteLine("\n\tHas gastado $25, tu sualdo actual es de ${0}.\n\tEl total de la compra es ${1}.", TarjetaRegalo, Total);break;
                        case 9:TarjetaRegalo -= 700;Total += 700;
                            Console.WriteLine("\n\tHas gastado $700, tu sualdo actual es de ${0}.\n\tEl total de la compra es ${1}.", TarjetaRegalo, Total);break;
                        case 10:TarjetaRegalo -= 1500;Total += 1500;
                            Console.WriteLine("\n\tHas gastado $1500, tu sualdo actual es de ${0}.\n\tEl total de la compra es ${1}.", TarjetaRegalo, Total);break;}
                    if(TarjetaRegalo <= 0){Console.WriteLine("\r\n\tATENCION. Te quedaste sin saldo.");}
                    if(NumCompra == 0 || NumCompra > 11){Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r\n\tEl número de la operación no se ha encontrado, intentelo de nuevo.");}}}
            catch (FormatException)
            {Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Por favor, ingrese un número válido");}
            catch (OverflowException)
            {Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Se han sobrepasado los limites. Por favor, revise el tamaño del número ingresado");}
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tEl proceso ha finalizado.\n\tPresione la tecla <INTRO> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Enter);}}}