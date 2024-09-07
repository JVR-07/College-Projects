using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa39_PracticaGeneral_U5
{
    internal class Program
    {
        //Excepciones personalizadas
        class ParametroFueraDeRango : ApplicationException
        {
            public ParametroFueraDeRango() : base("El número ingresado está fuera del rango establecido")
            {
            }
        }

        class ParametroInvalido : ApplicationException
        {
            public ParametroInvalido() : base("Número inválido para esta operación")
            {
            }
        }

        class ParametroNulo : ApplicationException
        {
            public ParametroNulo() : base("El valor del número debe ser diferente de cero")
            {
            }
        }
        static void Main(string[] args)
        {
            //Declaración de variables auxiliares
            int Base;
            short opcion = 0;
            double coseno_resultante, tangente_resultante;

            //ciclo do while para controlar el menú
            do
            {
                //Bloque try donde se lanzarán las excepciones
                try
                {   //Captura de datos
                    Console.WriteLine("\n\t\t|:. Menú Funciones .:|");
                    Console.WriteLine("\n\t1.- Calcular Coseno y Tangente" +
                                      "\n\t2.- Salir del Programa");
                    Console.Write("\n\n\tIngrese el número de la opción deseada: ");
                    opcion = short.Parse(Console.ReadLine());
                    Console.Write("\n\n\tDato capturado correctamente" +
                                  "\n\tPresione la tecla <Enter> para salir...");
                    Console.ReadKey();
                    Console.Clear();

                    //Switch case para controlar opciones del menú
                    switch (opcion)
                    {
                        case 1:
                            {   //Captura de datos
                                Console.WriteLine("\n\t\t|:. Captura de Datos .:|");
                                Console.WriteLine("\n\t|Ingrese los datos necesarios|");
                                Console.Write("\n\n\tIngrese un valor para la base: ");
                                Base = int.Parse(Console.ReadLine());
                                Console.Write("\n\n\tDato capturado correctamente" +
                                              "\n\tPresione la tecla <Enter> para continuar...");
                                Console.ReadKey(); Console.Clear();

                                //Secuencia de if's para comprobar el dato
                                if (Base > 500000)
                                {
                                    throw new ParametroFueraDeRango();
                                }
                                else if (Base < 0)
                                {
                                    throw new ParametroInvalido();
                                }
                                else if (Base == 0)
                                {
                                    throw new ParametroInvalido();
                                }

                                //Realización de cálculos
                                coseno_resultante = Math.Cos(Base);
                                tangente_resultante = Math.Tan(Base);

                                //Despliegue de resultados
                                Console.WriteLine("\n\t\t|:. Resultados obtenidos .:|");
                                Console.WriteLine("\n\tEl coseno de \"{0}\" es : {1:f4}" +
                                                  "\n\n\tLa tangente de \"{0}\" es: {2:f4}",
                                                 Base, coseno_resultante, tangente_resultante);

                                Console.WriteLine("\n\tCálculos finalizados");
                            }
                            break;

                        case 2:
                            {
                                Console.WriteLine("\n\t\t|:. Salida .:|");
                                Console.WriteLine("\n\tGracias por utilizar nuestro software");
                            }
                            break;

                        default:
                            {
                                Console.WriteLine("\n\t\t|:. Algo Ha Salido Mal .:|");
                                Console.WriteLine("\n\tIngrese un dato válido por favor");
                            }
                            break;
                    }
                }

                //Bloques catch para atrapar las excepciones
                catch (FormatException e)
                {
                    Console.WriteLine("\n\t\t|:. Algo Ha Salido Mal .:|");
                    Console.WriteLine("\n\n\tMensaje del error: {0}" +
                                      "\n\n\tRuta del error: {1}", e.Message, e.StackTrace);
                }

                catch (OverflowException e)
                {
                    Console.WriteLine("\n\t\t|:. Algo Ha Salido Mal .:|");
                    Console.WriteLine("\n\n\tMensaje del error: {0}" +
                                      "\n\n\tRuta del error: {1}", e.Message, e.StackTrace);
                }
                catch (ParametroFueraDeRango e)
                {
                    Console.WriteLine("\n\t\t|:. Algo Ha Salido Mal .:|");
                    Console.WriteLine("\n\n\tMensaje del error: {0}" +
                                      "\n\n\tRuta del error: {1}", e.Message, e.StackTrace);
                }

                catch (ParametroInvalido e)
                {
                    Console.WriteLine("\n\t\t|:. Algo Ha Salido Mal .:|");
                    Console.WriteLine("\n\n\tMensaje del error: {0}" +
                                      "\n\n\tRuta del error: {1}", e.Message, e.StackTrace);
                }

                catch (ParametroNulo e)
                {
                    Console.WriteLine("\n\t\t|:. Algo Ha Salido Mal .:|");
                    Console.WriteLine("\n\n\tMensaje del error: {0}" +
                                      "\n\n\tRuta del error: {1}", e.Message, e.StackTrace);
                }

                //Bloque finally que se ejecutará al final
                finally
                {
                    if (opcion == 2)
                    {
                        Console.Write("\n\tPresione la tecla <Esc> para salir del programa..."); Console.ReadKey();
                    }
                    else Console.Write("\n\tPresione la tecla <Enter> para regresar al menú..."); Console.ReadKey(); Console.Clear();
                }
            }
            while (opcion != 2);
        }
    }
}