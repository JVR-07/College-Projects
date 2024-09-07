using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4_Redefinicion_de_Metodos
{
    internal class Program
    {
        //Declaración de funciones auxiliares para captura de datos
        static string CapturaString(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return Console.ReadLine();
        }
        static short CapturaShort(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return short.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {   //Declaración de variables
            string auxiliar_reina = "Sí";
            short opcion, accion = 0, numero_alas = 0;
            bool ejecución_programa = true, reina = false; ;
            //Primer do while para controlar primer menú
            do
            {
                //Despliegue menú
                Console.WriteLine("\n\t*** Seleccione uno de los dos insectos disponibles actualmente ***");
                Console.WriteLine("\n\t1 - Hormiga\n\t2 - Abeja\n\t0 - Salir");
                opcion = CapturaShort("el número del insecto deseado");
                Console.Clear();
                //Switch case para controlar respuestas
                switch (opcion)
                {
                    case 1: // Caso 1
                        {
                            Console.WriteLine("\n\t¿Desea una reina? Sí | No");
                            auxiliar_reina = CapturaString("Ingrese la respuesta deseada(Escríbalo igual que en el ejemplo de arriba)");
                            Console.Clear();
                            switch (auxiliar_reina)
                            {
                                case "Sí": // Caso 1
                                    {
                                        reina = true;
                                        numero_alas = 2;
                                    }
                                    break;
                                case "Si": //Caso auxiliar 1
                                    {
                                        reina = true;
                                        numero_alas = 2;
                                    } break;
                                case "No": //Caso 2
                                    {
                                        reina = false;
                                        numero_alas = 0;
                                    } break;
                                default: //Ningún caso
                                    {
                                        Console.Write("\tNo se ha reconocido el dato ingreado, por lo que se tomará un no por defecto.");
                                        reina = false;
                                        numero_alas = 0;
                                    }
                                    break;
                            }
                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            Console.Clear();
                            //Creación del objeto
                            clsHormiga Linepithema_humile = new clsHormiga("Linepithema humile","Rojo",2.6f,reina,3,6,2,numero_alas);
                            //segundo do while para controlar el segundo menú
                            do
                            {
                                Console.WriteLine("\n\t*** Acciones a realizar ***");
                                Console.WriteLine("\t1 - Caminar\n\t2 - Descanar\n\t3 - Alimentarse\n\t4 - Reproducirse\n\t5 - Defenderse\n\t6 - Mostrar información\n\t0 - salir");
                                accion = CapturaShort("Ingrese el número de la acción que desea");
                                //Switch case para controlar respuestas
                                switch (accion)
                                {
                                    case 0: // Caso 1
                                        {
                                            Console.Write("\n\tGracias por usar nuestro software.\n\tPresione la tecla <Esc> parta salir...");
                                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                                            ejecución_programa = false;
                                        }
                                        break;
                                    case 1: // Caso 2
                                        {
                                            Linepithema_humile.Caminar();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        } break;
                                    case 2: // Caso 3
                                        {
                                            Linepithema_humile.Descansar();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        } break;
                                    case 3: // Caso 4
                                        {
                                            Linepithema_humile.Alimentarse();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        } break;
                                    case 4: // Caso 5
                                        {
                                            Linepithema_humile.Reproducirse();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        } break;
                                    case 5: // Caso 6
                                        {
                                            Linepithema_humile.Defenderse();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        } break;
                                    case 6: // Caso 7
                                        {
                                            Linepithema_humile.DesplegarInformacion();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        } break;
                                    default: // Ningún caso
                                        {
                                            Console.WriteLine("\n\tNo se ha encontrado el dato ingresado, asegúrese de escribirlo correctamente.");
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                }
                            }
                            while (accion != 0); //Condición de segundo do while
                        }
                        break;
                    case 2: // Caso 2
                        {
                            Console.WriteLine("\n\t¿Desea una reina? Sí | No");
                            auxiliar_reina = CapturaString("Ingrese la respuesta deseada(Escríbalo igual que en el ejemplo de arriba)");
                            Console.Clear();
                            switch (auxiliar_reina)
                            {
                                case "Sí":  // Caso 1
                                    {
                                        reina = true;
                                    }
                                    break;
                                case "Si": // Caso auxiliar 
                                    {
                                        reina = true;
                                    }
                                    break;
                                case "No": // Caso 2
                                    {
                                        reina = false;
                                    }
                                    break;
                                default: // Ningún caso
                                    {
                                        Console.Write("\tNo se ha reconocido el dato ingreado, por lo que se tomará un no por defecto.");
                                        reina = false;
                                    }
                                    break;
                            }
                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            Console.Clear();
                            //Creación del objeto
                            clsAbeja Apis_Mellifera = new clsAbeja("Apis mellifera", "Amarillo con negro", 1.3f, reina, 3, 6, 2, 2);
                            do // Tercer do while para controlar tercer menú
                            {
                                Console.WriteLine("\n\t*** Acciones a realizar ***");
                                Console.WriteLine("\t1 - Caminar\n\t2 - Descanar\n\t3 - Alimentarse\n\t4 - Reproducirse\n\t5 - Defenderse\n\t6 - Mostrar información\n\t0 - salir");
                                accion = CapturaShort("Ingrese el número de la acción que desea");
                                switch (accion) // Switch case para controlar respuestas
                                {
                                    case 0: // Caso 1
                                        {
                                            Console.Write("\n\tGracias por usar nuestro software.\n\tPresione la tecla <Esc> parta salir...");
                                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                                            ejecución_programa = false;
                                        }
                                        break;
                                    case 1: // Caso 2
                                        {
                                            Apis_Mellifera.Caminar();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                    case 2: // Caso 3
                                        {
                                            Apis_Mellifera.Descansar();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                    case 3: // Caso 4
                                        {
                                            Apis_Mellifera.Alimentarse();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                    case 4: // Caso 5
                                        {
                                            Apis_Mellifera.Reproducirse();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                    case 5: // Caso 6
                                        {
                                            Apis_Mellifera.Defenderse();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                    case 6: // Caso 7
                                        {
                                            Apis_Mellifera.DesplegarInformacion();
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                    default: // Ningún caso
                                        {
                                            Console.WriteLine("\n\tNo se ha encontrado el dato ingresado, asegúrese de escribirlo correctamente.");
                                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                                            Console.Clear();
                                        }
                                        break;
                                }
                            }
                            while (accion != 0); // Condición de tercer do while
                        } break;
                    case 0: // Caso 3
                        {
                            Console.Write("\n\tGracias por usar nuestro software.\n\tPresione la tecla <Esc> parta salir...");
                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                            ejecución_programa = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("\n\tNo se ha encontrado el dato ingresado, asegúrese de escribirlo correctamente.");
                            Console.Write("\tPresione la tecla <Enter> para continuar...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            Console.Clear();
                        }
                        break;
                }
            }
            while (ejecución_programa); // Condición de primer do while
        }
    }
}