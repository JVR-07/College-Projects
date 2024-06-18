using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Declaración de libreria Input/Output para acceder a métodos
using System.IO;

namespace Ejemplo_FileText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables auxiliares
            short opcion;
            string contenido_nota, nombre_nota;
            bool ejecucion = true;

            //Declaración de lector
            FileStream LectorArchivo;
            StreamReader LectorString;
            //Declaración de escritor
            StreamWriter EscritorString;
            //Declaración de editor de archivo
            FileInfo EditorDeArchivo;
            do
            {
                try
                {   //Despliegue de menú
                    Console.WriteLine("\n\t\t.: MENÚ DE OPCIONES :.");
                    Console.WriteLine("\n\t1 - Escribir nota" +
                                      "\n\t2 - Leer nota" +
                                      "\n\t3 - Editar nota" +
                                      "\n\t4 - Eliminar nota" +
                                      "\n\t0 - Salir del programa");
                    //Captura de datos
                    Console.Write("\n\n\tIngrese el número de la opción deseada: "); opcion = short.Parse(Console.ReadLine());
                    Console.WriteLine("\n\tDato capturado correctamente");
                    Console.Write("\n\tPresione la tecla <Enter> para continuar..."); Console.ReadKey(); Console.Clear();

                    //Inicio bloque switch case
                    switch (opcion)
                    {
                        case 0:
                            {
                                Console.WriteLine("\n\t\t.: SALIDA :.");
                                Console.WriteLine("\n\tGracias por utilizar nuestro software");
                                ejecucion = false;
                            }
                            break;

                        case 1:
                            {
                                Console.WriteLine("\n\t\t.: ESCRITURA :.");
                                Console.WriteLine("\t|Si existe un archivo con el mismo nombre, este será reemplazado|");
                                Console.Write("\n\n\tIngrese el nombre de la nota que desea crear: "); nombre_nota = Console.ReadLine();
                                Console.Write("\n\tIngrese el contenido de la nota: "); contenido_nota = Console.ReadLine();
                                Console.WriteLine("\n\tDatos capturado correctamente");
                                Console.Write("\n\tPresione la tecla <Enter> para continuar..."); Console.ReadKey(); Console.Clear();

                                //Creación de archivo escritor
                                EscritorString = new StreamWriter(nombre_nota + ".txt", false, Encoding.ASCII);

                                //Proceso de escritura
                                EscritorString.Write(contenido_nota);

                                //Mensaje final
                                Console.WriteLine("\n\t\t.: ESCRITURA :.");
                                Console.WriteLine("\n\tSe ha escrito en la nota el siguiente mensaje:");
                                Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
                                Console.Write("\t{0}", contenido_nota);
                                Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");

                                //Liberación de memoria
                                EscritorString.Close();
                                nombre_nota = "";
                                contenido_nota = "";
                            }
                            break;

                        case 2:
                            {   //Declaración de variable auxiliar
                                string contenido_aux = "";

                                Console.WriteLine("\n\t\t.: LECTURA :.");
                                Console.Write("\n\n\tIngrese el nombre de la nota que desea leer: "); nombre_nota = Console.ReadLine();
                                Console.WriteLine("\n\tDatos capturado correctamente");
                                Console.Write("\n\tPresione la tecla <Enter> para continuar..."); Console.ReadKey(); Console.Clear();

                                //Creación de archivo lector
                                LectorArchivo = new FileStream(nombre_nota + ".txt", FileMode.Open, FileAccess.Read);
                                LectorString = new StreamReader(LectorArchivo);

                                //Proceso de lectura
                                Console.WriteLine("\n\t\t.: LECTURA :.\n\n\t");
                                //While para recorrer todos los caracteres del archivo
                                Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
                                while ((contenido_aux = LectorString.ReadLine()) != null)
                                {
                                    Console.WriteLine("\n\t{0}", contenido_aux);
                                }
                                Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");

                                //Liberación de memoria
                                LectorArchivo.Close();
                                LectorString.Close();
                                nombre_nota = "";
                                contenido_nota = "";
                                contenido_aux = "";
                            }
                            break;

                        case 3:
                            {
                                Console.WriteLine("\n\t\t.: EDICIÓN :.");
                                Console.Write("\n\n\tIngrese el nombre de la nota que desea editar: "); nombre_nota = Console.ReadLine();
                                Console.Write("\n\tIngrese el contenido que desea agregar a la nota: "); contenido_nota = Console.ReadLine();
                                Console.WriteLine("\n\tDatos capturado correctamente");
                                Console.Write("\n\tPresione la tecla <Enter> para continuar..."); Console.ReadKey(); Console.Clear();

                                //Creación de archivo escritor
                                EscritorString = new StreamWriter(nombre_nota + ".txt", true, Encoding.ASCII);

                                //Proceso de escritura
                                EscritorString.WriteLine(contenido_nota);
                                //Mensaje final
                                Console.WriteLine("\n\t\t.: EDICIÓN :.");
                                Console.WriteLine("\n\tSe ha añadido en la nota el siguiente mensaje:\n\t");
                                Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");
                                Console.Write("\t{0}", contenido_nota);
                                Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------------");

                                //Liberación de memoria
                                EscritorString.Close();
                                nombre_nota = "";
                                contenido_nota = "";
                            }
                            break;

                        case 4:
                            {
                                Console.WriteLine("\n\t\t.: ELIMINACIÓN DE NOTA :.");
                                Console.Write("\n\n\tIngrese el nombre de la nota que desea eliminar: "); nombre_nota = Console.ReadLine();
                                Console.WriteLine("\n\tDatos capturado correctamente");
                                Console.Write("\tPresione la tecla <Enter> para continuar..."); Console.ReadKey(); Console.Clear();

                                //Proceso de eliminación
                                EditorDeArchivo = new FileInfo(nombre_nota + ".txt");
                                EditorDeArchivo.Delete();
                                //Mensaje final
                                Console.WriteLine("\n\t\t.: ELIMINACIÓN DE NOTA :.");
                                Console.WriteLine("\n\tSe ha eliminado la nota exitosamente");

                                //Liberación de memoria
                                nombre_nota = "";
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("\n\t\t.: ERROR :.");
                                Console.WriteLine("\n\tOpcion inválida");
                            }
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: ERROR :.");
                    Console.WriteLine("\n\tMensaje de error: {0}" +
                                      "\n\n\t{1}", e.Message, e.StackTrace);
                }
                catch (FileNotFoundException e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: ERROR :.");
                    Console.WriteLine("\n\tMensaje de error: {0}" +
                                      "\n\n\t{1}", e.Message, e.StackTrace);
                }
                finally
                {
                    if (ejecucion == false)
                    {
                        Console.Write("\n\n\tPresione la tecla <Enter> para salir del programa..."); Console.ReadKey();
                    }
                    else
                    {


                        Console.Write("\n\n\tPresione la tecla <Enter> para regresar al menú...");
                        Console.ReadKey(); Console.Clear();
                    }
                }

            }
            while (ejecucion);
        }
    }
}
