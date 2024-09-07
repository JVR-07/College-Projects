using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_Cola_Simple_Estatica_de_Calificaciones
{
    internal class Program
    {   //Declaración de variable global de la clase Program
        public static int Front = 0, Rear = 0;
        static void Main(string[] args)
        {
            Console.Title = "P23 Cola Simple Estática de Calificaciones";
            //Declaración de variables para controles de menú y opciones
            short opcion_menu = 0;
            //Declaración de variables para procedimientos
            //Declaración de variables para colas
            short[] ColaSimpleCalificaciones = new short[30];

            //Despliegue de menú 
            do
            {
                Console.Write("\n\t\t.: MENÚ DE OPCIONES :." +
                              "\n\n\t[1] - Insertar Calificación" +
                              "\n\t[2] - Eliminar Calificación" +
                              "\n\t[3] - Buscar Calificación" +
                              "\n\t[4] - Mostrar Calificaciones" +
                              "\n\t[5] - Salir del programa" +
                              "\n\n\tIngrese el número de la opción deseada: ");
                if (short.TryParse(Console.ReadLine(), out opcion_menu))
                {
                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();

                    //Control de opciones
                    switch (opcion_menu)
                    {
                        case 1:
                            {
                                do
                                {
                                    Console.Write("\n\t\t.: INSERTAR CALIFIACIÓN :." +
                                                  "\n\n\tIngrese la calificación a insertar: ");
                                    InsertarCalificaciones(ColaSimpleCalificaciones, short.Parse(Console.ReadLine()));
                                    Console.Write("\n\n\t¿Desea insertar otra calificación [1.Sí] [2.No] ? " +
                                                   "\n\tIngrese el número de la opción deseada: ");
                                    opcion_menu = short.Parse(Console.ReadLine());
                                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                } while (opcion_menu == 1);
                            }
                            break;
                        case 2:
                            {
                                do
                                {
                                    Console.Write("\n\t\t.: ELIMINAR CALIFICACIÓN :." +
                                                  "\n\n\t| Eliminando la última calificación insertada |");
                                    EliminarCalificaciones(ColaSimpleCalificaciones);
                                    Console.Write("\n\n\t¿Desea eliminar otra calificación [1.Sí] [2.No] ? " +
                                                   "\n\tIngrese el número de la opción deseada: ");
                                    opcion_menu = short.Parse(Console.ReadLine());
                                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                } while (opcion_menu == 1);
                            }
                            break;
                        case 3:
                            {
                                do
                                {
                                    Console.WriteLine("\n\t\t.: BUSCANDO CALIFICACIÓN :.");
                                    BuscarCalificaciones(ColaSimpleCalificaciones);
                                    Console.Write("\n\n\t¿Desea buscar otra calificación [1.Sí] [2.No] ? " +
                                                   "\n\tIngrese el número de la opción deseada: ");
                                    opcion_menu = short.Parse(Console.ReadLine());
                                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                } while (opcion_menu == 1);
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("\n\t\t.: MOSTRANDO CALIFICACIONES :.");
                                MostrarCalificaciones(ColaSimpleCalificaciones);
                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case 5:
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
                    Console.Clear();
                    Console.Write("\n\t\t.: VALOR NO NÚMERICO :." +
                                                                  "\n\n\tPor favor ingrese un número entero" +
                                                                  "\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                }
            } while (opcion_menu != 5);
        }
        //**********************************************************************************************************
        //Procedimiento Insertar
        public static void InsertarCalificaciones(short[] ColaSimpleCalificaciones, short ciudad)
        {
            if (!VerificarLLena(ColaSimpleCalificaciones.Length))
            {
                ColaSimpleCalificaciones[Front] = ciudad;
                Front++;
                Console.Write($"\n\tLa calificación {ciudad} ha sido insertada correctamente.");
            }
            else Console.WriteLine("\n\tCola Simple llena");
        }
        //**********************************************************************************************************
        //Función Llena
        public static bool VerificarLLena(int tamanio)
        {
            if (Front >= tamanio) return true;
            else return false;
        }
        //Fin Función LLena
        //**********************************************************************************************************
        //Procedimiento Eliminar
        public static void EliminarCalificaciones(short[] ColaSimpleCalificaciones)
        {
            if (VerificarVacia()) Console.WriteLine("\n\n\tCola Simple Vacía");
            else
            {
                Console.WriteLine($"\n\tSe ha eliminado la calificación {ColaSimpleCalificaciones[Rear]}");
                ColaSimpleCalificaciones[Rear] = 0; Rear++;
            }
        }
        //Fin procedimiento Eliminar
        //**********************************************************************************************************
        //Función vacía
        public static bool VerificarVacia()
        {
            if (Rear == Front) return true;
            else return false;
        }
        //**********************************************************************************************************
        //Mostar valores de cola simple
        public static void MostrarCalificaciones(short[] ColaSimpleCalificaciones)
        {
            if (!VerificarVacia())
            {
                for (int i = Rear; i < Front; i++)
                {
                    Console.WriteLine($"\n\t{ColaSimpleCalificaciones[i]}");
                }
            }
            else Console.WriteLine("\n\n\tCola Simple Vacía");
        }
        //Fin Método
        //**********************************************************************************************************
        //Buscar Elemento dentro de la cola simple
        public static void BuscarCalificaciones(short[] ColaSimpleCalificaciones)
        {
            bool bandera = false;
            if (!VerificarVacia())
            {
                Console.Write("\n\n\tIngrese el nombre de la calificación a buscar: ");
                short busca = short.Parse(Console.ReadLine());
                for (int i = Rear; i < Front; i++)
                {
                    if (ColaSimpleCalificaciones[i] == busca)
                    {
                        bandera = true;
                        break;
                    }
                }
                if (bandera) Console.WriteLine($"\n\tLa calificación de {busca} Sí se ha encontrado");
                else Console.WriteLine($"\n\tLa calificación de {busca} No se ha encontrado");
            }
            else Console.WriteLine("\n\n\tCola Simple Vacía");
        }
        //Fin método
        //**********************************************************************************************************
    }
}
