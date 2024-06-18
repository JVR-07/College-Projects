using System;

namespace P41_Busqueda_Secuencial_Metodo_1
{
    internal class Program
    {
        //*********************************************************************************************************************************************************

        //Inicio Método Buscar
        public static bool Buscar(string[] Arreglo, string elemento, ref int position)
        {
            bool flag = false;
            int i;

            for (i = 0; i < Arreglo.Length; i++)
            {
                if (Arreglo[i] == elemento) { flag = true; position = i; }
            }
            return flag;
        }
        //Fin Método Buscar

        //*********************************************************************************************************************************************************

        //Inicio Método Mostrar
        public static void Mostrar(string[] Arreglo)
        {
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.Write($"\n\t[{i + 1}] - {Arreglo[i]}.");
            }
        }
        //Fin Método Mostrar

        //*********************************************************************************************************************************************************

        static void Main(string[] args)
        {
            Console.Title = "P41 Búsqueda Secuencial Método 1";

            //*********************************************************************************************************************************************************
            //Declaración de variables
            char opcion_menu;
            string nombre_mascota;
            string[] MascotasArreglo = new string[15];
            int PositionElement = 0;
            //Fin Declaración de variables

            //*********************************************************************************************************************************************************


            //Despliegue de menú
            do
            {
                Console.Write("\n\t\t.: MENÚ OPCIONES :." +
                                  "\n\n\t[1] - Insertar Mascotas." +
                                  "\n\n\t[2] - Buscar Mascotas." +
                                  "\n\n\t[3] - Mostrar Mascotas." +
                                  "\n\n\t[4] - Salida del Programa." +
                                  "\n\n\tIngrese el número de la opción deseada: ");

                if (char.TryParse(Console.ReadLine(), out opcion_menu))
                {
                    opcion_menu = char.ToUpper(opcion_menu);
                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                    //Control de opciones del menú
                    switch (opcion_menu)
                    {
                        case '1':
                            {
                                //Captura de datos
                                Console.Write("\n\t\t.: INSERTAR MASCOTAS :." +
                                              "\n\n\tA continuación se insertarán las 15 mascotas en el arreglo: ");

                                for (int i = 0; i < MascotasArreglo.Length; i++)
                                {
                                    Console.Write($"\n\n\t{i + 1}.- Ingrese el nombre de la mascota: ");
                                    MascotasArreglo[i] = Console.ReadLine();
                                    Console.Write($"\n\tSe ha ingresado el nombre \"{MascotasArreglo[i]}\" correctamente");
                                }

                                Console.Write("\n\n\tSe han ingresado los nombres correctamente" +
                                                                "\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case '2':
                            {
                                //Captura de datos
                                Console.Write("\n\t\t.: BUSCAR MASCOTAS :." +
                                              "\n\n\tIngrese el nombre de la mascota a buscar: ");
                                nombre_mascota = Console.ReadLine();

                                //Procedimiento de búsqueda
                                if (Buscar(MascotasArreglo, nombre_mascota, ref PositionElement)) Console.WriteLine($"\n\n\tLa mascota \"{nombre_mascota}\" se encuentra en la posición {PositionElement + 1} de la lista");
                                else Console.WriteLine($"\n\n\tLa mascota \"{nombre_mascota}\" no se encuentra en la lista");

                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case '3':
                            {
                                //Captura de datos
                                Console.Write("\n\t\t.: MOSTRAR MASCOTAS :." +
                                              "\n\n\tA continuación se mostrarán las 15 mascotas del arreglo: \n");

                                Mostrar(MascotasArreglo);

                                Console.Write("\n\n\tSe han mostrado las mascotas correctamente" +
                                                                "\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case '4':
                            {
                                //Caso 4. Salida del programa
                                Console.Write("\n\t\t:. SALIDA :." +
                                                        "\n\n\tGracias por utilizar nuestro programa" +
                                                        "\n\n\tPresione la tecla <Esc> para salir...");
                                while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                            }
                            break;
                        default:
                            {
                                //En caso de ingresar una opción inválida
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
                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                    Console.Write("\n\t\t.: OPCIÓN INVALIDA :." +
                                                                   "\n\n\tPor favor ingrese una opción existente" +
                                                                   "\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                }
            } while (opcion_menu != '4');
        }
    }
}
