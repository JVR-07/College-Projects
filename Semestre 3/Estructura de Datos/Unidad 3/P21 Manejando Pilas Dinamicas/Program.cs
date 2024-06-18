using System;
using System.Collections.Generic;

namespace P21_Manejando_Pilas_Dinamicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "P21 Manejando Pilas Dinámicas";
            //Declaración de pila dinamica
            Stack<string> PilaMascotas = new Stack<string>(40);
            //Declaración de variables para menú
            int opcion_menu;
            //Declaración de variables para procedimientos
            string nombre_mascota;

            //Despliegue de menú
            do
            {
                Console.Write("\n\t\t.: MENÚ OPCIONES :." +
                                  "\n\n\t[1] - Insertar Mascotas." +
                                  "\n\n\t[2] - Eliminar Mascotas." +
                                  "\n\n\t[3] - Buscar Mascotas." +
                                  "\n\n\t[4] - Mostrar Mascotas." +
                                  "\n\n\t[5] - Salida del Programa." +
                                  "\n\n\tIngrese el número de la opción deseada: ");
                
                opcion_menu = int.Parse(Console.ReadLine());
                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                //Control de opciones del menú
                switch (opcion_menu)
                {
                    case 1: 
                        {   //Condición para validar estado de la pila
                                do
                                {
                                    if (PilaMascotas.Count < 40)
                                    {
                                        Console.Clear();
                                        //Captura de datos
                                        Console.Write("\n\t\t.: INSERTAR MASCOTAS :." +
                                                      "\n\n\tIngrese el nombre de la mascota: ");
                                        nombre_mascota = Console.ReadLine();

                                        //Procedimiento para insertar el nombre
                                        PilaMascotas.Push(nombre_mascota);

                                        //Pregunta para ingresar otro nombre
                                        Console.Write($"\n\n\tSe ha insertado la mascota {nombre_mascota}" +
                                                      $"\n\n\t¿Desea ingresar otra mascota [1.Sí][2.No]? " +
                                                      $"\n\n\tIngrese el número de la opción: ");
                                        opcion_menu = int.Parse(Console.ReadLine());
                                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                    }
                                    else
                                    {   //Pila llena
                                        Console.WriteLine("\n\n\t.: LA PILA ESTÁ LLENA :.");
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        opcion_menu =2;
                                    }
                                } while (opcion_menu == 1);
                        }
                        break;
                    case 2: 
                        {
                            //Condición para validar estado de la pila
                                do
                                {
                                    if (PilaMascotas.Count > 0)
                                    {
                                        Console.Clear();
                                        //Captura de datos
                                        Console.Write("\n\t\t.: ELIMINAR MASCOTAS :." +
                                                      "\n\n\tIngrese el nombre de la mascota a eliminar: ");
                                        nombre_mascota = Console.ReadLine();
                                        //Condición para válidar que el nombre se encuentre en la pila
                                        if (PilaMascotas.Contains(nombre_mascota) == true)
                                        {
                                            //Eliminación de mascota y pregunta para hacer otra iteración
                                            Console.Write($"\n\n\tSe ha eliminado la mascota {PilaMascotas.Pop()}");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"\n\n\tEl nombre {nombre_mascota} no se encuentra en la pila");
                                        }
                                        Console.Write($"\n\n\t¿Desea eliminar otra mascota [1.Sí][2.No]? " +
                                                                        $"\n\n\tIngrese el número de la opción: ");
                                        opcion_menu = int.Parse(Console.ReadLine());
                                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                   }
                                    else
                                    {   //Pila Vacía
                                        Console.WriteLine("\n\n\t.: LA PILA ESTÁ VACÍA :.");
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        opcion_menu = 2;
                                    }
                                } while (opcion_menu == 1);
                                
                        }
                        break;
                    case 3: 
                        {
                                do
                                {
                                if (PilaMascotas.Count > 0)
                                {
                                    Console.Clear();
                                    //Captura de datos
                                    Console.Write("\n\t\t.: BUSCAR MASCOTAS :." +
                                                  "\n\tIngrese el nombre de la mascota a buscar: ");
                                    nombre_mascota = Console.ReadLine();

                                    //Procedimiento de busqueda
                                    if (PilaMascotas.Contains(nombre_mascota) == true) Console.WriteLine($"\n\n\tEl nombre {nombre_mascota} sí se encuentra en la pila");
                                    else Console.WriteLine($"\n\n\tEl nombre {nombre_mascota} no se encuentra en la pila");

                                    //Pregunta para hacer otra iteración
                                    Console.Write("\n\n\t¿Desea buscar otra mascota [1.Sí][2.No]? " +
                                                  "\n\n\tIngrese el número de la opción: ");
                                    opcion_menu = int.Parse(Console.ReadLine());
                                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                }
                                else
                                {   //Pila Vacía
                                    Console.WriteLine("\n\n\t.: LA PILA ESTÁ VACÍA :.");
                                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                    opcion_menu = 2;
                                }
                            } while (opcion_menu == 1);                            
                        }
                        break;
                    case 4: 
                        {
                            //Condición para validar estado de la pila
                            if (PilaMascotas.Count > 0)
                            {
                                    //Captura de datos
                                    Console.Write("\n\t\t.: MOSTRAR MASCOTAS :." +
                                                  "\n\n\tSe han encontrado las siguientes mascotas: \n");

                                    //Procedimiento para mostrarlos
                                    foreach(string nombre in PilaMascotas)
                                    {
                                        Console.WriteLine($"\n\t{nombre}");
                                    }
                                //Mensaje para regresar al menú
                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            else
                            {   //Pila Vacía
                                Console.WriteLine("\n\n\t.: LA PILA ESTÁ VACÍA :.");
                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                        }
                        break;
                    case 5: 
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
            } while (opcion_menu != 5);
        }
    }
}
