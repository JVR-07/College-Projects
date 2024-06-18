using System;

namespace P32.Búrbuja_Simple_descendiente
{
    internal class Program
    {
        //*******************************************************************************************************************************

        //Declaración de método para ordenar
        public static short[] OrdenamientoBurbujaSimple(short[] Edades)
        {
            short t;
            for(int i = 0; i < Edades.Length; i++)
            {
                for (int j = 0; j < Edades.Length - 1; j++)
                {
                    if (Edades[j] < Edades[j + 1])
                    {
                        t = Edades[j];
                        Edades[j] = Edades[j + 1];
                        Edades[j + 1] = t;
                    }
                }
            }
            return Edades;
        }
        //Fin declaración de método para ordenar

        //*******************************************************************************************************************************

        //Inicio declaración método para mostrar
        public static void Mostrar(short[] Edades)
        {
            for (int i = 1; i <= Edades.Length; i++)
            {
                Console.Write($"[{Edades[i - 1]}] ");
            }
        }
        //Fin declaración de método mostrar


        //*******************************************************************************************************************************

        static void Main(string[] args)
        {
            Console.Title = "P32 Búrbuja simple descendiente";
            //*******************************************************************************************************************************

            //Declaración de variables locales
            short[] Edades = new short[20];
            short Edad; char opcion;

            //*******************************************************************************************************************************

            do //Do while para controlar menú
            {
                //Despliegue de menú
                Console.Write("\n\t\t.: MENÚ DE OPCIONES :." +
                              "\n\n\t[ 1 ] - Capturar Edades" +
                                "\n\t[ 2 ] - Ordenar Edades Descendientemente" +
                                "\n\t[ 3 ] - Salir del Programa" +
                              "\n\n\tIngrese el número de la opción deseada: ");
                if (char.TryParse(Console.ReadLine(), out opcion) != false) //Try catch para controlar errores de formato
                {
                    Console.Write($"\n\n\tLa opción {opcion} se ha capturado correctamente" +
                                  $"\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                    //Switch case para controlar opciones
                    switch (opcion)
                    {
                        case '1':
                            {
                                Console.WriteLine("\n\t.: CAPTURA DE DATOS :.");
                                for (int i = 1; i <= Edades.Length; i++) //Ciclo para capturar todas las edades
                                {
                                    Console.Write($"\n\t{i}.- Ingrese un edad: ");
                                    if (short.TryParse(Console.ReadLine(), out Edad) == true && Edad <= 100 && Edad >= 0)
                                    {
                                        Console.WriteLine($"\n\tSe ha capturado la edad {Edad} correctamente.");
                                        Edades[i - 1] = Edad;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n\tLa edad debe ser un valor entero entre 1 y 100");
                                        i--;
                                    }
                                }
                                Console.Write("\n\tCaptura de datos terminada, presione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case '2':
                            {
                                Console.WriteLine("\n\t\t.: ORDENANDO DATOS DESCENDIENTEMENTE :." +
                                      "\n\n\t| Este es el arreglo original sin ordenar |\n\t");
                                Mostrar(Edades); //Llamada a método para mostrar
                                Console.WriteLine("\n\n\t| Este es el arreglo ordenado descendientemente |\n\t");
                                Edades = OrdenamientoBurbujaSimple(Edades);//llamada a método para ordenar 
                                Mostrar(Edades);
                                Console.Write("\n\tOrdenamiento terminado, presione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case '3':
                            {
                                Console.Write("\n\t\t:. SALIDA :." +
                                                          "\n\n\tGracias por utilizar nuestro programa" +
                                                          "\n\n\tPresione la tecla <Esc> para salir...");
                                while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                            }
                            break;
                        default:
                            {
                                Console.Write("\n\t\t.: OPCIÓN INVALIDA :." +
                                                           "\n\n\tPor favor ingrese una opción existente" +
                                                           "\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                    }
                }
                else
                {
                    Console.Write("\n\n\tLa opción no se ha podido capturar, asegúrese de escribirla correctamente" +
                                  "\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                }
            } while (opcion != '3');
        }
    }
}
