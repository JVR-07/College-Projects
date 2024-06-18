using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Manejando_Menu_Opciones_Recursividad_Directa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string nombre = ""; int opcion = 0;
            //Llamada a métodos recursivo
            MenuOpciones(nombre, opcion);
        }
        //Declaración de método recursivo
        static public void MenuOpciones(string nombre, int opcion)
        {   //Condición del ciclo
            if (opcion != 3)
            {   //Despliegue de menú
                Console.WriteLine("\n\t\t.: MENÚ DE OPCIONES :.");
                Console.WriteLine("\t| Ingrese el número de la opción deseada |");
                Console.WriteLine("\n\t1) Ingresar nombre." +
                                  "\n\t2) Mostrar nombre." +
                                  "\n\t3) Salir.");
                Console.Write("\n\tIngrese la opción deseada: "); opcion = int.Parse(Console.ReadLine());
                Console.Write($"\n\n\tSe ha seleccionado la opción {opcion}." +
                                  $"\n\tPresione la tecla <INTRO> para continuar...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                Console.Clear();
                //inicio bloque switch case para controlar las opciones
                switch (opcion)
                {
                    case 1: 
                        {   //Caso 1 captura de datos
                            Console.Write("\n\t\t.: CAPTURA DE DATOS :." +
                                          "\n\n\tIngrese el nombre de una persona: "); nombre = Console.ReadLine();
                            Console.Write($"\n\n\tSe ha ingresado el nombre de {nombre}." +
                                            $"\n\tPresione la tecla <INTRO> para regresar al menú...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            Console.Clear();
                            //Llamada a método recursivo con nuevos valores
                            MenuOpciones(nombre,opcion);
                        } 
                        break;
                    case 2: 
                        {   //Caso 2 Impresión de resultados
                            Console.Write($"\n\t\t.: IMPRESIÓN DE RESULTADOS :." +
                                          $"\n\n\tEl nombre de la persona es: {nombre}" +
                                          $"\n\n\tNombre capturado correctamente." +
                                          $"\n\tPresione la tecla <INTRO> para regresar al menú....");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            Console.Clear();
                            //Llamada a método recursivo con nuevos valores
                            MenuOpciones(nombre, opcion);
                        } 
                        break;
                    case 3: 
                        {   //Caso 3 Salida del programa
                            Console.Write("\n\t\t.: SALIDA DEL PROGRAMA :." +
                                          "\n\n\tGracias por utilizar nuestro software" +
                                          "\n\tPresione la tecla <Esc> para salir del programa...");
                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                            Console.Clear();
                            //Llamada a método recursivo con nuevos valores
                            MenuOpciones(nombre, opcion);
                        } 
                        break;
                    default:
                        {   //Caso 4 Opción incorrecta
                            Console.Write($"\n\t\t.: ALGO SALIÓ MAL :." +
                                          $"\n\n\t{opcion} no es una opción válida." +
                                          $"\n\tPresione la tecla <INTRO> para regresar al menú...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            Console.Clear();
                            //Llamada a método recursivo con nuevos valores
                            MenuOpciones(nombre, opcion);
                        } 
                        break;
                }
            }
        }
    }
}