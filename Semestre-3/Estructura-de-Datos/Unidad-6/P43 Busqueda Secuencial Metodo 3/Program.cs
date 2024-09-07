using System;

namespace P43_Busqueda_Secuencial_Metodo_3
{
    internal class Program
    {
        //*********************************************************************************************************************************************************

        //Inicio Método Buscar
        public static bool Buscar(int[] Arreglo, int elemento, ref int position)
        {
            int i = 0;
            bool flag = false, stop = false; 

            while(i < Arreglo.Length && flag != true && stop != true)
            {
                if (Arreglo[i] == elemento) { flag = true; position = i; }
                else if (Arreglo[i] < elemento) { i++; }
                else { stop = true; }
            }
            return flag;
        }
        //Fin Método Buscar

        //*********************************************************************************************************************************************************

        //Inicio Método Mostrar
        public static void Mostrar(int[] Arreglo)
        {
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.Write("\n\t{0} - {1}.", i + 1, Arreglo[i]);
            }
        }
        //Fin Método Mostrar

        //*********************************************************************************************************************************************************

        //Inicio Método ordenar
        public static int[] OrdenamientoShell(int[] Arreglo)
        {
            //Inicio variables locales
            bool flag = false;
            int salto = 0;
            int t;
            //Fin variables locales

            //Encontrando la mitad del arreglo
            salto = Arreglo.Length / 2;
            //Ciclos anidados para hacer el ordenamiento
            while (salto > 0)
            {
                flag = true;
                while (flag != false)
                {
                    flag = false;
                    for (int i = 1; i <= Arreglo.Length - salto; i++)
                    {
                        if (Arreglo[i - 1] > Arreglo[i - 1 + salto])
                        {
                            t = Arreglo[i - 1 + salto];
                            Arreglo[i - 1 + salto] = Arreglo[i - 1];
                            Arreglo[i - 1] = t;
                            flag = true;
                        }
                    }
                }
                salto = salto / 2;
            }
            return Arreglo;
        }
        //Fin Método ordenar

        //*********************************************************************************************************************************************************

        static void Main(string[] args)
        {
            Console.Title = "P43 Búsqueda Secuencial Método 3";

            //*********************************************************************************************************************************************************
            //Declaración de variables
            char opcion_menu;
            int numero;
            int[] NumerosArreglo = new int[30];
            int PositionElement = 0;
            Random random = new Random();
            //Fin Declaración de variables

            //*********************************************************************************************************************************************************


            //Despliegue de menú
            do
            {
                Console.Write("\n\t\t.: MENÚ OPCIONES :." +
                                  "\n\n\t[1] - Insertar Números." +
                                  "\n\n\t[2] - Buscar Números." +
                                  "\n\n\t[3] - Mostrar Números." +
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
                                Console.Write("\n\t\t.: INSERTAR NÚMEROS :." +
                                              $"\n\n\tA continuación se insertarán los {NumerosArreglo.Length} números aleatorios en el arreglo: ");

                                for (int i = 0; i < NumerosArreglo.Length; i++)
                                {
                                    numero = random.Next(0, 100);
                                    Console.Write($"\n\n\t{i + 1}.- Ingrese el número: {numero}");
                                    NumerosArreglo[i] = numero;
                                    Console.Write("\n\tSe ha ingresado el número {0:} correctamente", NumerosArreglo[i]);
                                }

                                NumerosArreglo = OrdenamientoShell(NumerosArreglo);

                                Console.Write("\n\n\tSe han ingresado los números correctamente" +
                                                                "\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case '2':
                            {
                                //Captura de datos
                                Console.Write("\n\t\t.: BUSCAR NÚMEROS :." +
                                              "\n\n\tIngrese el número del empleado a buscar: ");
                                numero = int.Parse(Console.ReadLine());

                                //Procedimiento de búsqueda
                                if (Buscar(NumerosArreglo, numero, ref PositionElement)) Console.WriteLine("\n\n\tEl número {0} se encuentra en la posición {1} de la lista", numero, PositionElement + 1);
                                else Console.WriteLine("\n\n\tEl número {0} no se encuentra en la lista", numero);

                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case '3':
                            {
                                //Captura de datos
                                Console.Write("\n\t\t.: MOSTRAR NÚMEROS :." +
                                              $"\n\n\tA continuación se mostrarán los {NumerosArreglo.Length} número del arreglo: \n");

                                Mostrar(NumerosArreglo);

                                Console.Write("\n\n\tSe han mostrado los sueldos correctamente" +
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
