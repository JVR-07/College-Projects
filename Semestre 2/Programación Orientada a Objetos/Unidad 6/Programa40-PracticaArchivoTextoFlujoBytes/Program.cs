using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programa40_PracticaArchivoTextoFlujoBytes
{
    internal class Program
    {
        //Inicio clase para flujo de archivos de texto con bytes
        public class TextoBytes
        {
            //Inicio bloque de campos
            FileStream fs = null; //Declaración flujo salida
            FileStream fe = null; //Declaración flujo salida
            byte[] bBuffer = new byte[81];
            char[] cBuffer = new char[81];
            int nbytes = 0, car;
            //Fin bloque de campos

            //Inicio Constructor
            public TextoBytes()
            {
            }
            //Fin Constructor

            //Inicio bloque método 1
            public void CrearArchivo(string nombre)
            {   //Inicio bloque try
                try
                {
                    // Crea un flujo hacia el archivo texto.txt
                    fs = new FileStream(nombre, FileMode.Create, FileAccess.Write);

                    //Captura de datos
                    Console.WriteLine("\n\t\t.: ESCRITURA DE DATOS :." +
                                      "\n\t\t------------------------");  
                    Console.Write("\n\tEscriba el texto que desea almacenar en el archivo: ");

                    while ((car = Console.Read()) != '\n' && (nbytes < bBuffer.Length))
                    {
                        bBuffer[nbytes] = (byte)car; //convierte en byte el carácter leído
                        nbytes++; //incrementa contar de bytes
                    }

                    fs.Write(bBuffer, 0, nbytes);
                }
                //Final bloque try

                //Inicio bloques catch
                catch(IOException e)
                {
                    Console.WriteLine("\n\tMensaje de Error: {0}" +
                                      "\n\tSe produjo{1}",
                                      e.Message,e.StackTrace);
                }
                //Final bloques catch

                //Inicio bloque finally
                finally
                {
                    if (fs != null) fs.Close(); //cierra el flujo de escritura
                    Console.WriteLine("\n\tLa escritura ha finalizado");
                }
                //Final bloque finally
            }
            //Fin bloque método 1

            //Inicio bloque método 2
            public void LeerArchivo(string nombre)
            {
                //Inicio bloque try
                try
                {   //Crea un flujo desde el archivo texto.txt
                    fe = new FileStream(nombre, FileMode.Open, FileAccess.Read);  

                    // Lee del archivo una línea de texto
                    nbytes = fe.Read(bBuffer, 0, 81);
                    // Crea un objeto string con el texto leído
                    Array.Copy(bBuffer, cBuffer, bBuffer.Length);
                    String str = new String(cBuffer, 0, nbytes);

                    // Muestra el texto leído en pantalla
                    Console.WriteLine("\n\t\t.: ESCRITURA DE DATOS :." +
                                      "\n\t\t------------------------");
                    Console.WriteLine("\n\tCONTENIDO DEL ARCHIVO EN DISCO:");
                    Console.WriteLine("\n\t" + str);
                }
                //FInal bloque try

                //Inicio bloque catch
                catch(IOException e)
                {
                    Console.WriteLine("\n\tMensaje de Error: {0}" +
                                      "\n\tSe produjo{1}",
                                      e.Message,e.StackTrace);
                }
                //Final bloque catch

                //Inicio bloque finally
                finally
                {
                    if (fe != null) fe.Close(); //cierra el flujo de lectura
                    Console.WriteLine("\n\tLa lectura ha finalizado");
                }
                //Final bloque finally
            }
            //Fin bloque método 2

            //Inicio Destructor
            ~TextoBytes()
            {
                Console.WriteLine("\n\tMemoria Liberada del Objeto TextoBytes");
            }
            //Fin Destructor
        }
        //Fin clase para flujo de archivos de texto con bytes
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
                Console.WriteLine(  "\ta) Escribir un archivo" +
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
                        Console.Write("\n\n\tDato capturado correctamente"+
                                      "\n\tPresione la tecla <Enter> para continuar...");
                        Console.ReadKey(); Console.Clear();

                        TextoBytes MiTexto = new TextoBytes();
                        MiTexto.CrearArchivo(nombre);
                        Console.Write("\n\n\tArchivo creado correctamente");
                    }
                    break;
                    case 'b':
                    {
                        Console.WriteLine("\n\t\t.: CAPTURA DE DATOS :." +
                                          "\n\t\t----------------------");  
                        Console.Write("\n\tIngrese el nombre del archivo: "); nombre = Console.ReadLine() + ".txt";
                        Console.Write("\n\n\tDato capturado correctamente"+
                                      "\n\tPresione la tecla <Enter> para continuar...");
                        Console.ReadKey(); Console.Clear();
                        TextoBytes MiTexto = new TextoBytes();
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
                        Console.WriteLine("\n\tLa opción ingresada no ha sido válida.");
                    }
                    break;
                }
            }
            //Fin bloque try

            //Inicio bloques catch
            catch(FormatException e)
            {
                Console.WriteLine("\n\tMensaje de Error: {0}" +
                                      "\n\tSe produjo{1}",
                                      e.Message,e.StackTrace);
            }
            //Fin bloques catch
            
            //Inicio bloque finally
            finally
            {
                if (opcion == 'c')
                {
                    Console.Write("\n\tGracias por utilizar nuestro software"+
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
            while(opcion != 'c');
            //Fin do while
        }
    }
}