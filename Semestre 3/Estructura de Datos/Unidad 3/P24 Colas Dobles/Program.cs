using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P24_Colas_Dobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "P24 Colas Dobles";
            //Declaración de variables para control de colas
            float[] ColaDobleSueldo = new float[12];
            int front_L = 0, front_R = 0, front_C = 0, rear_L = 0, rear_R = 0, rear_C = 0;
            //Declaración de variables para procedimientos
            float sueldo;
            //Declaración de variables para control de menú y opciones
            int opcion; char lado; 

            //Despliegue del menú
            do
            {
                Console.Write("\n\t\t>>** MENÚ DE OPCIONES **<<" +
                                            "\n\n\t1. Insertar Sueldo." +
                                            "\n\t2. Eliminar Sueldo." +
                                            "\n\t3. Salir del Programa." +
                                            "\n\n\tIngrese el número de la opción: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();

                    switch (opcion)
                    {
                        case 1: 
                            {
                                do
                                {
                                    Console.Write("\n\n\t>>** INSERTAR SUELDO **<<" +
                                                                "\n\n\t-- Ingrese el sueldo a insertar: ");
                                    sueldo = float.Parse(Console.ReadLine());
                                    Console.Write("\n\n\t--¿Por cuál lado desea insertar?" +
                                                                "\n\t[I - Izquierda] [D - Derecha]" +
                                                                "\n\tIngrese la letra del lado: ");
                                    if (char.TryParse(Console.ReadLine(), out lado))
                                    {
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        Console.Clear();
                                        if (front_C == 0)
                                        {
                                            front_C = ColaDobleSueldo.Length / 2; rear_C = front_C;
                                            front_L = front_C - 1; rear_L = front_C - 1;
                                            front_R = front_C + 1; rear_R = front_C + 1;
                                            ColaDobleSueldo[front_C] = sueldo;
                                            Console.Write($"\n\n\t>>** SUELDO INSERTADO **<<" +
                                                                                 $"\n\n\tSe ha insertado el sueldo {sueldo} en la parte central" +
                                                                                 $"\n\tPresione la tecla <INTRO> para mostrar la cola...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                            MostrarColaDobleSueldos(ColaDobleSueldo, ColaDobleSueldo.Length);
                                        }
                                        else
                                        {
                                            if (char.ToUpper(lado) == 'I')
                                            {
                                                if (front_L >= 0)
                                                {
                                                    front_L = InsertarIzquierda(ColaDobleSueldo, front_L, sueldo);
                                                    Console.Write($"\n\n\t>>** SUELDO INSERTADO **<<" +
                                                                                     $"\n\n\tSe ha insertado el sueldo {sueldo} en la parte izquierda" +
                                                                                     $"\n\tPresione la tecla <INTRO> para mostrar la cola...");
                                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                    MostrarColaDobleSueldos(ColaDobleSueldo, ColaDobleSueldo.Length);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\n\t\t>>** LO SENTIMOS **<<" +
                                                                                        "\n\n\tLa cola izquierda está llena");
                                                    Console.Write("\n\tPresione la tecla <INTRO> para continuar...");
                                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                }
                                            }
                                            else if (char.ToUpper(lado) == 'D')
                                            {
                                                if (front_R <= ColaDobleSueldo.Length)
                                                {
                                                    front_R = InsertarDerecha(ColaDobleSueldo, front_R, sueldo);
                                                    Console.Write($"\n\n\t>>** SUELDO INSERTADO **<<" +
                                                                                     $"\n\n\tSe ha insertado el sueldo {sueldo} en la parte derecha" +
                                                                                     $"\n\tPresione la tecla <INTRO> para mostrar la cola...");
                                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                    MostrarColaDobleSueldos(ColaDobleSueldo, ColaDobleSueldo.Length);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\n\t\t>>** LO SENTIMOS **<<" +
                                                                                        "\n\n\tLa cola derecha está llena");
                                                    Console.Write("\n\tPresione la tecla <INTRO> para continuar...");
                                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                }
                                            }
                                            else 
                                            {
                                                Console.WriteLine("\n\t\t>>** ALGO HA SALIDO MAL **<<" +
                                                                           "\n\n\tPor favor ingrese una opción válida.");
                                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                            }
                                        }
                                    }
                                    else 
                                    {
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        Console.WriteLine("\n\t\t>>** ALGO HA SALIDO MAL **<<" +
                                                                            "\n\n\tPor favor ingrese una sola letra.");
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                    }
                                    Console.Write("\n\t>>** ¿Desea realizar otra inserción? **<<" +
                                                                "\n\t[1.Sí] [2.No]" +
                                                                "\n\tIngrese el número de la opción: ");
                                    opcion = int.Parse(Console.ReadLine());
                                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                } while (opcion == 1);
                            }
                            break;
                        case 2: 
                            {
                                do
                                {
                                    Console.Write("\n\n\t>>** ELIMINAR SUELDO **<<" +
                                                                "\n\n\t-- ¿Desea eliminar un sueldo [1.Sí] [2.No] ?" +
                                                                "\n\tIngrese su respuesta: ");
                                    if (int.TryParse(Console.ReadLine(), out opcion))
                                    {
                                        if (opcion == 1)
                                        {
                                            Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                            Console.Write("\n\n\t--¿Por cuál lado desea eliminar?" +
                                                                        "\n\t[I - Izquierda] [D - Derecha] [C - Centro]" +
                                                                        "\n\tIngrese la letra del lado: ");
                                            if (char.TryParse(Console.ReadLine(), out lado))
                                            {
                                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                if (char.ToUpper(lado) == 'I')
                                                {
                                                    if (rear_L != front_L)
                                                    {
                                                        rear_L = EliminarIzquierda(ColaDobleSueldo, rear_L);
                                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                        MostrarColaDobleSueldos(ColaDobleSueldo, ColaDobleSueldo.Length);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n\t\t>>** LO SENTIMOS **<<" +
                                                                                        "\n\n\tLa cola izquierda está vacía");
                                                        Console.Write("\n\tPresione la tecla <INTRO> para continuar...");
                                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                    }
                                                }
                                                else if (char.ToUpper(lado) == 'D')
                                                {
                                                    if (rear_R != front_R)
                                                    {
                                                        rear_R = EliminarDerecha(ColaDobleSueldo, rear_R);
                                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                        MostrarColaDobleSueldos(ColaDobleSueldo, ColaDobleSueldo.Length);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n\t\t>>** LO SENTIMOS **<<" +
                                                                                        "\n\n\tLa cola derecha está vacía");
                                                        Console.Write("\n\tPresione la tecla <INTRO> para continuar...");
                                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                    }
                                                }
                                                else if(char.ToUpper(lado) == 'C')
                                                {
                                                    if (rear_C != 0)
                                                    {
                                                        Console.Write($"\n\n\t>>** SUELDO ELIMINADO **<<" +
                                                                                    $"\n\n\tSe ha eliminado el sueldo {ColaDobleSueldo[rear_C]} en la parte central" +
                                                                                    $"\n\n\tPresione la tecla <INTRO> para mostrar la cola...");
                                                        ColaDobleSueldo[rear_C] = 0.0f;
                                                        rear_C = 0;
                                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                        MostrarColaDobleSueldos(ColaDobleSueldo, ColaDobleSueldo.Length);
                                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\n\t\t>>** LO SENTIMOS **<<" +
                                                                                        "\n\n\tEl centro está vacío");
                                                        Console.Write("\n\tPresione la tecla <INTRO> para continuar...");
                                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\n\t\t>>** ALGO HA SALIDO MAL **<<" +
                                                                               "\n\n\tPor favor ingrese una opción válida.");
                                                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                }
                                            }
                                            else
                                            {
                                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                                Console.WriteLine("\n\t\t>>** ALGO HA SALIDO MAL **<<" +
                                                                                    "\n\n\tPor favor ingrese una sola letra.");
                                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                            }
                                            Console.Write("\n\t>>** ¿Desea realizar otra eliminación? **<<" +
                                                                        "\n\t[1.Sí] [2.No]" +
                                                                        "\n\tIngrese el número de la opción: ");
                                            opcion = int.Parse(Console.ReadLine());
                                            Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        }
                                        else if(opcion == 2)
                                        {
                                            Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                            Console.WriteLine("\n\t\t>>** SALIENDO AL MENÚ **<<");
                                            Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        }
                                        else
                                        {
                                            Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                            Console.WriteLine("\n\t\t>>** ALGO HA SALIDO MAL **<<" +
                                                                               "\n\n\tPor favor ingrese una opción válida.");
                                            Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        }
                                    }
                                    else
                                    {
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        Console.WriteLine("\n\t\t>>** ALGO HA SALIDO MAL **<<" +
                                                                               "\n\n\tPor favor ingrese un número entero valido.");
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                    }
                                } while (opcion == 1);
                            }
                            break;
                        case 3: 
                            {
                                Console.Write("\n\t\t.: SALIDA :." +
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
                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                    Console.WriteLine("\n\t\t>>** ALGO HA SALIDO MAL **<<" +
                                                        "\n\n\tPor favor ingrese un número entero.");
                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                }
            } while (opcion != 3);
        }

        //***************************************************
        //Inicio funciones para insertar
        public static int InsertarIzquierda(float[] ColaDobleSueldo , int front_L, float sueldo)
        {
                ColaDobleSueldo[front_L] = sueldo;
                front_L--;
                return front_L;
        }
        public static int InsertarDerecha(float[] ColaDobleSueldo, int front_R, float sueldo)
        {
                ColaDobleSueldo[front_R] = sueldo;
                front_R++;
                return front_R;
        }
        //Fin funciones para insertar
        //***************************************************

        //Inicio funciones para eliminar
        public static int EliminarIzquierda(float[] ColaDobleSueldo, int rear_L)
        {
            Console.Write($"\n\n\t>>** SUELDO ELIMINADO **<<" +
                                       $"\n\n\tSe ha eliminado el sueldo {ColaDobleSueldo[rear_L]} en la parte izquierda" +
                                       $"\n\tPresione la tecla <INTRO> para mostrar la cola...");
            ColaDobleSueldo[rear_L] = 0.0f;
            rear_L--;
            return rear_L;
        }
        public static int EliminarDerecha(float[] ColaDobleSueldo, int rear_R)
        {
            Console.Write($"\n\n\t>>** SUELDO ELIMINADO **<<" +
                                        $"\n\n\tSe ha eliminado el sueldo {ColaDobleSueldo[rear_R]} en la parte derecha" +
                                        $"\n\tPresione la tecla <INTRO> para mostrar la cola...");
            ColaDobleSueldo[rear_R] = 0.0f;
            rear_R++;
            return rear_R;
        }
        //Fin funciones para eliminar
        //***************************************************

        //Inicio método para mostrar
        public static void MostrarColaDobleSueldos(float[] ColaDobleSueldo, int length)
        {
            Console.WriteLine("\n\t\t>>** ESTADO ACTUAL DE LA COLA **<<" +
                                                "\n\t| Estos son los sueldos que están en cola |\n");
            Console.Write("\t");
            for(int i = 0; i < length; i++)
            {
                Console.Write($"| {ColaDobleSueldo[i]} | ");
            }
            Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
        }
        //Fin método para mostrar
        //***************************************************
    }
}
