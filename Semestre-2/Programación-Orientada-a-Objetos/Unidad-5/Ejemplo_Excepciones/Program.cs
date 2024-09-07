using Ejemplo_Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1___Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Declaración de variables
            int espacioDisco = 0, GB = 0;
            short opcion = 0;

            //Bloque try
            try
            {
                Console.Write("\tPara iniciar, seleccione la capacidad de su disco(en GB): ");
                espacioDisco = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }

            //Bloques catch
            catch (FormatException e)
            {
                Console.WriteLine("\n\tError: {0}" +
                                  "\n\tRuta del error: {1}", e.Message, e.StackTrace);
            }
            catch (OverflowException e) //Bloque catch
            {
                Console.WriteLine("\n\tError: {0}" +
                                  "\n\tRuta del error: {1}", e.Message, e.StackTrace);
            }
            Console.Write("\tPresione la tecla <ENTER> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            Console.WriteLine("\n\tSe ha utilizado el almacenamiento por defecto");
            Console.Write("\tPresione la tecla <ENTER> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            // Declaración de nuevo objeto

            Computadora BismuthMachine = new Computadora(espacioDisco);
            do
            {
                // Bloque de instrucciones a ejecutar
                try
                {
                    Console.WriteLine("\t\t***Funciones a realizar***\n\t1 - Encender / apagar computadora.\n\t2 - Añadir archivos al disco.\n\t3 - Eliminar archivos al disco.\n\t4 - Llenar disco\n\t5 - Vaciar disco.\n\t6 - Salir.");
                    if (BismuthMachine.PpowerButton)
                    {
                        Console.WriteLine("\tEstado de la computadora: Encendida.");
                    }
                    else
                    {
                        Console.WriteLine("\tEstado de la computadora: Apagada.");
                    }
                    Console.WriteLine("\tEspacio utilizado: {0} GB.\n\tCapacidad máxima: {1} GB.", BismuthMachine.GetTamañoGB(), BismuthMachine.GetTamañoMaxGB());
                    Console.Write("\tIngrese el número de la operación que desea realizar: ");
                    opcion = Convert.ToInt16(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            {
                                if (BismuthMachine.PpowerButton)
                                {   // Llamada al metodo de la clase
                                    BismuthMachine.apagar();
                                    Console.Write("\tLa computadora ha sido apagada, presione la tecla <ENTER> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                    Console.Clear();
                                }
                                else
                                {   // Llamada al metodo de la clase
                                    BismuthMachine.encender();
                                    Console.Write("\tLa computadora ha sido encendida, presione la tecla <ENTER> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                    Console.Clear();
                                }
                            }
                            break;
                        case 2:
                            {   // Función para capturar los datos del usuario
                                GB = capturarGB();
                                // Llamada al metodo de la clase
                                BismuthMachine.añadirDatos(GB);
                                Console.Write("\tOperación finalizada, presione la tecla <ENTER> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                Console.Clear();
                            }
                            break;
                        case 3:
                            {   // Función para capturar los datos del usuario
                                GB = capturarGB();
                                // Llamada al metodo de la clase
                                BismuthMachine.eliminarDatos(GB);
                                Console.Write("\tOperación finalizada, presione la tecla <ENTER> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                Console.Clear();
                            }
                            break;
                        case 4:
                            {   // Llamada al metodo de la clase
                                BismuthMachine.añadirDatos(BismuthMachine.GetTamañoMaxGB());
                                Console.Write("\tOperación finalizada, presione la tecla <ENTER> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                Console.Clear();
                            }
                            break;
                        case 5:
                            {   // Llamada al metodo de la clase
                                BismuthMachine.eliminarDatos(BismuthMachine.GetTamañoMaxGB());
                                Console.Write("\tOperación finalizada, presione la tecla <ENTER> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                Console.Clear();
                            }
                            break;
                        case 6:
                            {
                                Console.Write("\tGracias por usar nuestro software.\n\tPresione la tecla <ESC> para cerrar el programa...");
                                while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                                Console.Clear();
                            }
                            break;
                        default:
                            {
                                Console.Write("\n\tEl dato ingresado es inválido. Asegurese de escribirlo bien");
                                Console.Write("\tPresione la tecla <ENTER> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                Console.Clear();
                            }
                            break;
                    }
                }

                //Bloques catch
                catch (FormatException e)
                {
                    Console.WriteLine("\n\tError: {0}" +
                                      "\n\tRuta del error: {1}", e.Message, e.StackTrace);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("\n\tError: {0}" +
                                      "\n\tRuta del error: {1}", e.Message, e.StackTrace);
                }
            } while (opcion != 6);
        }
        // Declaración de funciones
        static int capturarGB()
        {
            int GB = 0;
            Console.Write("\tIngrese los GB: ");
            GB = Convert.ToInt16(Console.ReadLine());
            return GB;
        }
    }
}
