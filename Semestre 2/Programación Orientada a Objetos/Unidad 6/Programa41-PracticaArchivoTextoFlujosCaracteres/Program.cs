using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programa41_PracticaArchivoTextoFlujosCaracteres
{
    internal class Program
    {
        public class TextoCaracteres
        {
            //campos de la clase
            StreamWriter sw = null; //declaración flujo de escritura
            StreamReader sr = null; //declaración flujo de lectura
            String str; //variable auxiliar

            //método 1
            public void CrearArchivo(string nombre)
            {
                try
                {
                    // Crea flujo de escritura hacia el archivo doc.txt, si el archivo existe sobreescribe su contenido.
                    sw = new StreamWriter(nombre);
                    Console.WriteLine("\n\t\t.: ESCRITURA DE ARCHIVO :." +
                                      "\n\t\t--------------------------");
                    Console.WriteLine("\n\tEscriba las líneas de texto para el archivo.\n" +
                                      "\n\tFinalice cada línea pulsando la tecla <Enter>\n" +
                                       "\n\tPara finalizar la escritura pulse sólo la tecla <ENTER>.\n");
                    // Lee una línea de la entrada estándar
                    str = Console.ReadLine();
                    // Mientras la cadena str no esté vacía escribe en el archivo
                    while (str.Length != 0)
                    {
                        // Escribe la línea leída en el archivo
                        sw.WriteLine(str);
                        // Lee la línea siguiente de la entrada estándar
                        str = Console.ReadLine();
                    }
                }
                catch (IOException es)
                {
                    Console.WriteLine("\n\tMensaje del Error: " + es.Message);
                    Console.WriteLine("\n\tRuta del Error: " + es.StackTrace);
                }
                finally
                {
                    // Cierra el flujo de escritura
                    if (sw != null) sw.Close();
                    Console.WriteLine("\n\tEscritura finalizada exitosamente");
                }
            }
            public void LeerArchivo(string nombre)
            {
                try
                {
                    // Crea flujo de lectura desde el archivo doc.txt
                    sr = new StreamReader(nombre);
                    // Lee del archivo una línea de texto
                    str = sr.ReadLine();
                    // Mientras la cadena str no esté vacía lee en el archivo
                    while (str != null)
                    {
                        // Muestra la línea leída y lee la línea siguiente del archivo
                        Console.WriteLine("\n");
                        Console.WriteLine("\t" + str);
                        str = sr.ReadLine();
                    }
                }
                catch (IOException le)
                {
                    Console.WriteLine("\n\tMensaje del Error: " + le.Message);
                    Console.WriteLine("\n\tRuta del Error: " + le.StackTrace);
                }
                finally
                {
                    if (sr != null) sr.Close(); // Cierra el flujo de lectura
                    Console.WriteLine("\n\tLectura finalizada exitosamente");
                }
            }
            ~TextoCaracteres()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto TextoCaracteres");
            }
        }
        static void Main(string[] args)
        {
            //Declaración de variables auxiliares
            string nombre;
            char opcion = ' ';

            //Inicio do while
            do
            {
                //Inicio bloque try
                try
                {
                    Console.WriteLine("\n\t\t.: MENÚ ARCHIVO TEXTO BYTES :." +
                                      "\n\t\t------------------------------");
                    Console.WriteLine("\ta) Escribir un archivo" +
                                      "\n\tb) Leer un archivo" +
                                      "\n\tc) Salir del programa");
                    Console.Write("\n\tIngrese la letra de la opción deseada: "); opcion = Char.ToLower(char.Parse(Console.ReadLine()));
                    Console.Write("\n\n\tDato capturado correctamente" +
                                  "\n\tPresione la tecla <Enter> para continuar...");
                    Console.ReadKey(); Console.Clear();

                    switch (opcion)
                    {
                        case 'a':
                            {
                                Console.WriteLine("\n\t\t.: CAPTURA DE DATOS :." +
                                                  "\n\t\t----------------------");
                                Console.Write("\n\tIngrese el nombre del archivo: "); nombre = Console.ReadLine() + ".txt";
                                Console.Write("\n\n\tDato capturado correctamente" +
                                              "\n\tPresione la tecla <Enter> para continuar...");
                                Console.ReadKey(); Console.Clear();

                                TextoCaracteres MiTexto = new TextoCaracteres();
                                MiTexto.CrearArchivo(nombre);
                                Console.Write("\n\n\tArchivo creado correctamente");
                            }
                            break;
                        case 'b':
                            {
                                Console.WriteLine("\n\t\t.: CAPTURA DE DATOS :." +
                                                  "\n\t\t----------------------");
                                Console.Write("\n\tIngrese el nombre del archivo: "); nombre = Console.ReadLine() + ".txt";
                                Console.Write("\n\n\tDato capturado correctamente" +
                                              "\n\tPresione la tecla <Enter> para continuar...");
                                Console.ReadKey(); Console.Clear();
                                TextoCaracteres MiTexto = new TextoCaracteres();
                                MiTexto.LeerArchivo(nombre);
                                Console.Write("\n\n\tArchivo leido correctamente");

                            }
                            break;
                        case 'c':
                            {
                                Console.WriteLine("\n\t\t.: SALIDA :." +
                                                   "\n\t\t-----------");

                            }
                            break;
                        default:
                            {
                                Console.WriteLine("\n\t\t.: ERROR :." +
                                                   "\n\t\t----------");
                                Console.WriteLine("\n\tLa opción ingresada no ha sido válida.");
                            }
                            break;
                    }
                }
                //Fin bloque try

                //Inicio bloques catch
                catch (FormatException e)
                {
                    Console.WriteLine("\n\tMensaje de Error: {0}" +
                                          "\n\tSe produjo{1}",
                                          e.Message, e.StackTrace);
                }
                //Fin bloques catch

                //Inicio bloque finally
                finally
                {
                    if (opcion == 'c')
                    {
                        Console.Write("\n\tGracias por utilizar nuestro software" +
                                      "\n\tPresione la tecla <Esc> para salir del programa...");
                        Console.ReadKey(); Console.Clear();
                    }
                    else
                    {
                        Console.Write("\n\tPresione la tecla <Enter> para regresar al menú...");
                        Console.ReadKey(); Console.Clear();
                    }
                }
                //Fin bloque finally

            }
            while (opcion != 'c');
            //Fin do while
        }
    }
}
