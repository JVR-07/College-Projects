using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa36_PracticaExcepción_ArgumentoFueradeRango
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Declaración de variables auxiliares
            char opcion;
            int Base;
            double Resultado;
            bool ejecucion = true;
            //Bloque try
            try
            {   //Do while para controlar menú
                do
                {   //Despliegue de menú
                    Console.WriteLine("\n\t.: MENÚ NÚMERO A LA 5ta POTENCIA :.");
                    Console.WriteLine("\n\t| Este es el menú de opciones |" +
                                      "\n\n\ta) Capturar y Realizar función" +
                                      "\n\tb) Salir del programa");

                    //Captura de dato
                    Console.Write("\n\n\n\tIngrese la letra de la opción deseada: ");
                    opcion = char.Parse(Console.ReadLine());
                    Console.Write("\n\n\tDato capturado correctamente" +
                                  "\n\tPresione la tecla <Enter> para continuar...");
                    Console.ReadKey();
                    Console.Clear();

                    //Switch case para controlar las opciones
                    switch (char.ToLower(opcion))
                    {
                        case 'a':
                            {   //Captura de dato
                                Console.WriteLine("\n\t.: CAPTURA DE DATO :.");
                                Console.Write("\n\tIngrese un número para la base: ");
                                Base = int.Parse(Console.ReadLine());
                                Console.Write("\n\n\tDato capturado correctamente" +
                                  "\n\tPresione la tecla <Enter> para continuar...");
                                Console.ReadKey();
                                Console.Clear();

                                //Condición
                                if (Base <= 999)
                                {
                                    Console.WriteLine("\n\t.: RESULTADO :.");
                                    Resultado = Math.Pow(Base, 5);
                                    Console.WriteLine("\n\tEL resultado de la operación es: " + Resultado);
                                    Console.WriteLine("\n\tResultado calculado correctamente");
                                    Console.Write("\n\n\tPresione la tecla <Enter> para continuar...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                else
                                {
                                    throw new ArgumentOutOfRangeException();
                                }
                            }
                            break;
                        case 'b':
                            {
                                Console.WriteLine("\n\t\t.: SALIDA :.");
                                Console.WriteLine("\n\t|Gracias por usar nuestro software|");
                                ejecucion = false;
                            }
                            break;
                    }
                }
                while (ejecucion);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("\n\tError: {0}" +
                                  "\n\tRuta del error: {1}",
                                  e.Message, e.StackTrace);
            }
            finally
            {
                Console.WriteLine("\n\tEl bloque finally siempre se ejecuta.");
                Console.Write("\n\n\tPresione la tecla <Enter> para salir...");
                Console.ReadKey();
            }
        }
    }
}