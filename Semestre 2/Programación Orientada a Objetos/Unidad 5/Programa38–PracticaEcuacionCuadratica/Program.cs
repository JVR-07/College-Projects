using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa38_PracticaEcuacionCuadratica
{
    internal class Program
    {
        //Declaración de excepcion
        class EcuacionCuadraticaException : ApplicationException
        {
            public EcuacionCuadraticaException() : base("La ecuación cuadrática no tiene solución")
            {
            }
        }

        static void Main(string[] args)
        {
            //Declaración de variables auxiliares
            int x, x2, a, b, c, D;
            bool ejecucion = true;
            char opcion;

            //Inicio ciclo do while
            do
            {
                //Inicio bloque try
                try
                {
                    Console.WriteLine("\n\t\t.: MENÚ ECUACIÓN CUADRÁTICA :." +
                                      "\n\n\t| Opciones disponibles |" +
                                      "\n\n\n\ta) Calcular Función" +
                                      "\n\tb) Salir del programa");
                    Console.Write("\n\n\n\tIngrese la letra de la opción deseada: "); opcion = char.Parse(Console.ReadLine());
                    Console.Write("\n\n\tDato capturado correctamente" +
                                  "\n\tPresione la tecla <Enter> para continuar...");
                    Console.ReadKey(); Console.Clear();

                    //Inicio switch case
                    switch (char.ToLower(opcion))
                    {
                        //inicio caso a
                        case 'a':
                            {
                                Console.WriteLine("\n\t\t.: CAPTURA DE DATOS :.");
                                //Caputura de datos
                                Console.Write("\n\n\n\tIngrese el coeficiente de x2: "); a = int.Parse(Console.ReadLine());
                                Console.Write("\n\n\n\tIngrese el coeficiente de x: "); b = int.Parse(Console.ReadLine());
                                Console.Write("\n\n\n\tIngrese el valor independiente: "); c = int.Parse(Console.ReadLine());
                                Console.Write("\n\n\n\tLos datos han sido capturados correctamente" +
                                              "\n\tPresione la tecla <Enter> para continuar...");
                                Console.ReadKey(); Console.Clear();

                                //Comprobación de discriminante
                                D = Convert.ToInt32(Math.Pow(b, 2) - 4 * a * c);

                                //Condicional para determinmar existencia de discriminante
                                if (D < 0)
                                {
                                    //Lanzamiento de excepcion
                                    throw new EcuacionCuadraticaException();
                                }
                                else
                                {
                                    //Calculo de resultados
                                    x = Convert.ToInt32((-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a);
                                    x2 = Convert.ToInt32((-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a);

                                    //Despliegue de resultados
                                    Console.WriteLine("\n\t\t.: RESULTADOS :.");
                                    Console.WriteLine("\n\tEl valor resultante de x es: {0}" +
                                                      "\n\tEl valor resultante de x2 es: {1}", x, x2);
                                    Console.WriteLine("\n\n\tResultados desplegados correctamente");
                                }
                                //Fin condicional 
                            }
                            break;
                        //Fin caso a

                        //Inicio caso b
                        case 'b':
                            {
                                Console.WriteLine("\n\t\t.: SALIDA :.");
                                Console.WriteLine("\n\n\tGracias por usar el software");
                                ejecucion = false;
                            }
                            break;
                            //Fin caso b
                    }
                    //Fin switch case
                }
                //Fin bloque try

                //Inicio bloques catch
                catch (FormatException e)
                {
                    Console.WriteLine("\n\t\t.: ALGO SALIÓ MAL :.");
                    Console.WriteLine("\n\n\tError: {0}" +
                                      "\n\n\tRuta del error: {1}",e.Message, e.StackTrace);
                }
                catch (EcuacionCuadraticaException e)
                {
                    Console.WriteLine("\n\t\t.: ALGO SALIÓ MAL :.");
                    Console.WriteLine("\n\n\tError: {0}" +
                                      "\n\n\tRuta del error: {1}", e.Message, e.StackTrace);
                }
                //Fin bloques catch

                //Inicio bloque finally
                finally
                {
                    Console.WriteLine("\n\tPROGRAMA DESARROLADO POR: Javier Machado Sanchez 22211600");
                    Console.WriteLine("\tMateria: Programación Orientada a Objetos 2A");
                    Console.Write("\n\tPresione la tecla <Enter> para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                //Fin bloque finally
            }
            while (ejecucion);
            //Final ciclo do while

        }
    }
}
