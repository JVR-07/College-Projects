using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa37_PracticaExcepciónNegativosException
{
    internal class Program
    {
        //Declaración de subclase para la excepción
        class NegativosException : ApplicationException
        {   //Constructor de la clase
            NegativosException() : base("| NO se puede calcular el seno de un Angulo Negativo |")
            {

            }
        }
        static void Main(string[] args)
        {   //Declaración de variables
            short angulo, opcion;
            double resultado;
            bool ejecucion = true;

              //Ciclo do while para controlar el menú
                do
                {
                //Inicio bloque try donde se lanzarán excepciones
                    try
                    {
                        //Despliegue de menú
                        Console.WriteLine("\n\t\t\t.: MENÚ Seno del Ángulo :." +
                                          "\n\t----------------------------------------------" +
                                          "\n\t\t\t .: Opciones :." +
                                          "\n\n\t1) Calcular función" +
                                          "\n\t2) Salir del programa");

                        //Captura de datos
                        Console.Write("\n\n\n\tIngrese el número de la opción deseada: ");
                        opcion = short.Parse(Console.ReadLine());
                        Console.Write("\n\n\tDato capturado correctamente" +
                                      "\n\tPresione la tecla <Enter> para continuar...");
                        Console.ReadKey();
                        Console.Clear();

                        //Switch case para controlar las opciones
                        switch (opcion)
                        {
                            case 1:
                                {   //Captura de datos
                                    Console.WriteLine("\n\t\t\t.: Calcular Seno :.");
                                    Console.Write("\n\n\tIngrese el valor del ángulo: ");
                                    angulo = short.Parse(Console.ReadLine());
                                    Console.Write("\n\n\tDato capturado correctamente");
                                    Console.Write("\n\n\tPresione la tecla <Enter> para regresar al menú...");
                                    Console.ReadKey();
                                    Console.Clear();

                                //Condición para validar dato
                                if (angulo < 0)
                                    {
                                        //Lanzamiento de excepcion
                                        throw new ApplicationException();
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n\t\t\t.: Resultado Seno :.");

                                        //Calculo del resultado
                                        resultado = Math.Sin(angulo);

                                        //Despliegue de resultado
                                        Console.WriteLine("\n\n\tEl seno resultante del ángulo {0} es: {1}", angulo, resultado);
                                        Console.Write("\n\n\tResultado mostrado correctamente");
                                    }
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("\n\t\t\t.: Salida del Programa :.");
                                    Console.WriteLine("\n\n\tGracias por usar nuestro software");
                                    ejecucion = false;
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("\n\t\t\t.: ERROR :.");
                                    Console.WriteLine("\n\n\tDato no válido" +
                                                  "\n\tAsegúrese de escribirlo correctamente");
                                }
                                break;
                        }
                        //Fin bloque switch case
                    }
                    //Inicio bloques catch
                    catch (NegativosException e)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\t\t\t.: ALGO SALIÓ MAL :.");
                        Console.WriteLine("\n\tMensaje del error: {0}" +
                                        "\n\n\tRuta del error: {1}", e.Message, e.StackTrace);
                    }
                    catch (FormatException e)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\t\t\t.: ALGO SALIÓ MAL :.");
                        Console.WriteLine("\n\tMensaje del error: {0}" +
                                          "\n\n\tRuta del error: {1}", e.Message, e.StackTrace);
                    }
                    //Fin de bloque catch

                    //Inicio bloque finally
                    finally
                    {
                        if (ejecucion)
                        {
                            Console.WriteLine("\n\tEl finally siempre se ejecuta");
                            Console.Write("\n\n\tPresione la tecla <Enter> para regresar al menú...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\n\tEl finally siempre se ejecuta");
                            Console.Write("\n\n\tPresione la tecla <Esc> para salir del programa...");
                            Console.ReadKey();
                        }
                    }
                    //Fin bloque finally
                }
                while (ejecucion);
                //Fin ciclo do while
        }
    }
}