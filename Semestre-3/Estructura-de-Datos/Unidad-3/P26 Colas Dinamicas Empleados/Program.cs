using System;
using System.Collections.Generic;

namespace P26_Colas_Dinamicas_Empleados
{
    internal class Program
    {
        //Declaración de colas globales
        public static Queue<string> ColaNombresEmpleados = new Queue<string>(30);
        public static Queue<float> ColaSueldosEmpleados = new Queue<float>(30);
        static void Main(string[] args)
        {
            Console.Title = "P26 Colas Dinámicas Empleados";
            //Declaración de variables para control de menú y opciones
            char opcion_menu;
            //Declaración de variables para procedimientos
            string nombre_empleado; float sueldo_empleado;
            //Despliegue de menú
            do
            {
                Console.Write("\n\t\t.: MENÚ DE OPCIONES :." +
                              "\n\n\t1. Altas." +
                                "\n\t2. Bajas." +
                                "\n\t3. Mostrar Empleados." +
                                "\n\t4. Mostrar Empleados con sueldo menor a $1500.00." +
                                "\n\t5. Salida del Programa." +
                                "\n\n\tIngrese el número de la respuesta: ");
                if(char.TryParse(Console.ReadLine(),out opcion_menu))
                {
                    Console.Write($"\n\n\tLa opción {opcion_menu} se ha capturado." +
                                      "\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                    //Control de opciones del menú
                    switch (opcion_menu)
                    {
                        case '1':
                            {
                                do
                                {
                                    if (ColaNombresEmpleados.Count < 30)
                                    {
                                        Console.Clear();
                                        //Captura de datos
                                        Console.Write("\n\t\t.: ALTA EMPLEADO :." +
                                                      "\n\n\tIngrese el nombre del empleado a dar de alta: ");
                                        nombre_empleado = Console.ReadLine();
                                        Console.Write("\n\n\tIngrese el sueldo del empleado a dar de alta: ");
                                        sueldo_empleado = float.Parse(Console.ReadLine());

                                        //Procedimiento para dar de alta al empleado
                                        AltaEmpleado(nombre_empleado, sueldo_empleado);
                                        //Pregunta para ingresar otro nombre
                                        Console.Write($"\n\n\tSe ha dado de alta al empleado {nombre_empleado}" +
                                                                        $"\n\tque cuenta con un sueldo de {sueldo_empleado:c}" +
                                                                    $"\n\n\t¿Desea dar de alta a otro empleado [S: Sí][N: No] ? " +
                                                                    $"\n\n\tIngrese la letra de la opción: ");
                                        opcion_menu = char.ToUpper(char.Parse(Console.ReadLine()));
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                    }
                                    else
                                    {   //Cola llena
                                        Console.WriteLine("\n\n\t.: LA COLA ESTÁ LLENA :.");
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        opcion_menu = 'N';
                                    }
                                } while (opcion_menu == 'S');
                            }
                            break;
                        case '2':
                            {
                                //Condición para validar estado de la cola
                                do
                                {
                                    if (ColaNombresEmpleados.Count > 0)
                                    {
                                        Console.Clear();
                                        //Captura de datos
                                        Console.Write("\n\t\t.: BAJA EMPLEADO :.");
                                        Console.Write("\n\n\t¿Desea dar de baja al primer empleado en la cola [S: Sí] [N: No] ?" +
                                                                    "\n\tIngrese la letra de la opción: ");
                                        opcion_menu = char.ToUpper(char.Parse(Console.ReadLine()));
                                        if (opcion_menu == 'S')
                                        {
                                            //Procedimiento para dar de baja al empleado
                                            BajaEmpleado();

                                            Console.Write("\n\n\t¿Desea dar de baja a otro empleado [S: Sí] [N: No] ?" +
                                                                        "\n\tIngrese la letra de la opción: ");
                                            opcion_menu = char.ToUpper(char.Parse(Console.ReadLine()));
                                        }
                                        else
                                        {
                                            Console.Write("\n\n\tSe ha cancelado el proceso de baja de los empleados");
                                        }
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                    }
                                    else
                                    {   //Cola Vacía
                                        Console.WriteLine("\n\n\t.: LA COLA ESTÁ VACÍA :.");
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        opcion_menu ='N';
                                    }
                                } while (opcion_menu == 'S');

                            }
                            break;
                        case '3':
                            {
                                    if (ColaNombresEmpleados.Count > 0)
                                        {
                                        Console.Clear();
                                        //Captura de datos
                                        Console.Write("\n\t\t.: MOSTRANDO EMPLEADOS :." +
                                                      "\n\t| Se mostrarán todos los empleados registrados en la cola |\n");
                                        //Procedimiento de búsqueda
                                        MostrarEmpleados();

                                        Console.WriteLine("\n\tLos empleados han sido mostrados correctamente.");
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                    }
                                    else
                                    {   //Cola Vacía
                                        Console.WriteLine("\n\n\t.: LA COLA ESTÁ VACÍA :.");
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                    }
                            }
                            break;
                        case '4':
                            {
                                if (ColaNombresEmpleados.Count > 0)
                                {
                                    Console.WriteLine("\n\t\t.: MOSTRANDO EMPLEADOS :." +
                                                  "\n\n\t| Se mostrarán los empleados con sueldo menor o igual a $1500.00 |");

                                    //Procedimiento para mostrarlos
                                    MostrarEmpleadosSueldoMenor();

                                    Console.Write("\n\tPresione la tecla <INTRO> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                }
                                else
                                {   //Cola Vacía
                                    Console.WriteLine("\n\n\t.: LA COLA ESTÁ VACÍA :.");
                                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                }
                            }
                            break;
                        case '5':
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
                    Console.Write($"\n\n\tLa opción {opcion_menu} no se ha podido capturar" +
                                      "\n\tPresione la tecla <INTRO> para intentarlo de nuevo...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                }
            } while (opcion_menu != '5');
        }

        public static void AltaEmpleado(string nombre, float sueldo)
        {
            ColaNombresEmpleados.Enqueue(nombre);
            ColaSueldosEmpleados.Enqueue(sueldo);
        }

        public static void BajaEmpleado()
        {
            Console.WriteLine($"\n\tSe ha dado de baja el empleado {ColaNombresEmpleados.Dequeue()}" +
                                                $"\n\tque tenía un sueldo de {ColaSueldosEmpleados.Dequeue():c}");
        }

        public static void MostrarEmpleados()
        {
            int index = 0;
            foreach(string nombre in ColaNombresEmpleados)
            {
                Console.WriteLine("\n\t.*. Empleado {0} .*." +
                                                    "\n\tNombre: {1}" +
                                                    "\n\tSueldo: {2:c}"
                                                    , index + 1, nombre, ColaSueldosEmpleados.ToArray()[index]);
                index++;
            }
        }

        public static void MostrarEmpleadosSueldoMenor()
        {
            int index = 0;
            foreach (float sueldo in ColaSueldosEmpleados)
            {
                if (sueldo <= 1500)
                {
                    Console.WriteLine("\n\t.*. Empleado {0} .*." +
                                                        "\n\tNombre: {1}" +
                                                        "\n\tSueldo: {2:c}"
                                                        , index + 1, ColaNombresEmpleados.ToArray()[index], sueldo);
                    index++;

                }
            }
            if(index != 0) Console.WriteLine("\n\tLos empleados han sido mostrados correctamente.");
            else Console.WriteLine("\n\tNo existe ningún empleado con un sueldo menor a $1500.00");
        }
    }
}
