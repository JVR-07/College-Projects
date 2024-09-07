using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22_Manejando_Colas_Simples_Estaticas
{
    internal class Program
    {
        public static int Front = 0, Rear = 0;
        static void Main(string[] args)
        {
            Console.Title = "P22 Manejando Colas Simples Estaticas";
            //Declaración de variables para controles de menú y opciones
            short opcion_menu = 0;
            //Declaración de variables para procedimientos
            //Declaración de variables para colas
            string[] ColaSimpleCiudad = new string[30];
            
            //Despliegue de menú 
            do
            {
                Console.Write("\n\t\t.: MENÚ DE OPCIONES :." +
                              "\n\n\t[1] - Insertar Ciudad" +
                              "\n\t[2] - Eliminar Ciudad" +
                              "\n\t[3] - Buscar Ciudad" +
                              "\n\t[4] - Mostrar Ciudades" +
                              "\n\t[5] - Salir del programa" +
                              "\n\n\tIngrese el número de la opción deseada: ");
                opcion_menu = short.Parse(Console.ReadLine());
                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();

                //Control de opciones
                switch(opcion_menu) 
                {
                    case 1: 
                        {
                            do
                            {
                                Console.Write("\n\t\t.: INSERTAR CIUDAD :." +
                                              "\n\n\tIngrese el nombre de la ciudad a insertar: ");
                                InsertarCiudad(ColaSimpleCiudad, Console.ReadLine());
                                Console.Write("\n\n\t¿Desea insertar otra ciudad [1.Sí] [2.No]? " +
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
                                Console.Write("\n\t\t.: ELIMINAR CIUDAD :." +
                                              "\n\n\t| Eliminando la última ciudad insertada |");
                                EliminarCiudad(ColaSimpleCiudad);
                                Console.Write("\n\n\t¿Desea eliminar otra ciudad [1.Sí] [2.No]? " +
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
                                Console.WriteLine("\n\t\t.: BUSCANDO CIUDAD :.");
                                BuscarCiudad(ColaSimpleCiudad);
                                Console.Write("\n\n\t¿Desea buscar otra ciudad [1.Sí] [2.No]? " +
                                               "\n\tIngrese el número de la opción deseada: ");
                                opcion_menu = short.Parse(Console.ReadLine());
                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            } while (opcion_menu == 1);
                        }
                        break;
                    case 4: 
                        {
                            Console.WriteLine("\n\t\t.: MOSTRANDO CIUDADES :.");
                            MostrarCiudad(ColaSimpleCiudad);
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
            } while(opcion_menu != 5);
        }
        //********************************************************
        //Procedimiento Insertar
        public static void InsertarCiudad(string[] ColaSimpleCiudad, string ciudad)
        {
            if (!VerificarLLena(ColaSimpleCiudad.Length))
            {
                ColaSimpleCiudad[Front] = ciudad;
                Front++;
                Console.Write($"\n\tLa ciudad {ciudad} ha sido insertada correctamente.");
            }
            else Console.WriteLine("\n\tCola Simple llena");
        }
        //********************************************************
        //Función Llena
        public static bool VerificarLLena(int tamanio)
        {
            if (Front >= tamanio) return true;
            else return false;
        }
        //Fin Función LLena
        //********************************************************
        //Procedimiento Eliminar
        public static void EliminarCiudad(string[] ColaSimpleCiudad)
        {
            if (VerificarVacia()) Console.WriteLine("\n\n\tCola Simple Vacía");
            else
            {
                Console.WriteLine($"\n\tSe ha eliminado la ciudad {ColaSimpleCiudad[Rear]}");
                ColaSimpleCiudad[Rear] = ""; Rear++;
            }
        }
        //Fin procedimiento Eliminar
        //********************************************************
        //Función vacía
        public static bool VerificarVacia()
        {
            if (Rear == Front) return true;
            else return false;
        }
        //********************************************************
        //Mostar valores de cola simple
        public static void MostrarCiudad(string[] ColaSimple)
        {
            if (!VerificarVacia())
            {
                for (int i = Rear; i < Front; i++)
                {
                    Console.WriteLine($"\n\t{ColaSimple[i]}");
                }
            }
            else Console.WriteLine("\n\n\tCola Simple Vacía");
        }
        //Fin Método
        //********************************************************
        //Buscar Elemento dentro de la cola simple
        public static void BuscarCiudad(string[] ColaSimple)
        {
            bool bandera = false;
            if (!VerificarVacia())
            {
                Console.Write("\n\tIngrese el nombre de la ciudad a buscar: ");
                string busca = Console.ReadLine();
                for (int i = Rear; i < Front; i++)
                {
                    if (ColaSimple[i] == busca)
                    {
                        bandera = true;
                        break;
                    }
                }
                if (bandera) Console.WriteLine($"\n\tLa ciudad de {busca} Sí se ha encontrado");
                else Console.WriteLine($"\n\tLa ciudad de {busca} No se ha encontrado");
            }
            else Console.WriteLine("\n\n\tCola Simple Vacía");
        }
        //Fin método
        //********************************************************
    }
}
