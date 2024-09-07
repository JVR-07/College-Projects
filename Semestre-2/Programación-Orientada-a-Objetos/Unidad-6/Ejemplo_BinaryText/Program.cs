using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Biblioteca para salida y entrada de datos
using System.IO;
using System.Runtime.InteropServices;

namespace Ejemplo_BinaryText
{
    internal class Program
    {
        //Excepcion OpcionInvalidaMenuException
        public class OpcionInvalidaMenuException : Exception //Clase derivada de Exception
        {   //Constructor para darle valor a los métodos de la clase Exception
            public OpcionInvalidaMenuException(string mensaje_error) : base(mensaje_error)
            {

            }
        }

        //Excepcion SemestreInexistenteException
        public class SemestreInexistenteException : Exception //Clase derivada de Exception
        {   //Constructor para darle valor a los métodos de la clase Exception
            public SemestreInexistenteException(string mensaje_error) : base(mensaje_error)
            {

            }
        }

        //Excepcion CalificacionInexistenteException
        public class CalificacionInexistenteException : Exception //Clase derivada de Exception
        {   //Constructor para darle valor a los métodos de la clase Exception
            public CalificacionInexistenteException(string mensaje_error) : base(mensaje_error)
            {

            }
        }

        //Clases del programa
        //Creación de clase
        public class clsArchivoBinario
        {   //Declaración de campos
            protected string directorio_archivo;
            private BinaryReader LectorArchivo;
            private BinaryWriter EscritorArchivo;
            private FileStream ArchivoBinarioEscritor;
            private FileStream ArchivoBinarioLector;

            //Constructor de la clase
            public clsArchivoBinario(string directorio)
            {
                directorio_archivo = directorio;
            }

            //Declaración de métodos
            public string GetDirectorio() 
            {
                return this.directorio_archivo;
            }

            //Creacion de archivo y métodos de escritura
            public void CreaArchivoEscritor()
            {
                ArchivoBinarioEscritor = new FileStream(directorio_archivo, FileMode.Create, FileAccess.Write);
                EscritorArchivo = new BinaryWriter(ArchivoBinarioEscritor);
            }

            public void Escribir(string text)
            {
                EscritorArchivo.Write(text);
            }
            public void Escribir(short number)
            {
                EscritorArchivo.Write(number);
            }

            public void CerrarArchivoEscritor()
            {
                EscritorArchivo.Close();
                ArchivoBinarioEscritor.Close();
            }

            //Creación de archivo y métodos de lectura 
            public void CrearArchivoDeLectura()
            {
                ArchivoBinarioLector = new FileStream(this.directorio_archivo, FileMode.Open, FileAccess.Read);
                LectorArchivo = new BinaryReader(ArchivoBinarioLector);
            }

            public void Leer()
            {
                while(ArchivoBinarioLector.Position != ArchivoBinarioLector.Length)
                {
                    Console.WriteLine("\tNombre: {0}",LectorArchivo.ReadString());
                    Console.WriteLine("\tMatrícula: {0}",LectorArchivo.ReadString());
                    Console.WriteLine("\tSemestre: {0}",LectorArchivo.ReadInt16());
                    Console.WriteLine("\tCalificaión: {0}",LectorArchivo.ReadInt16());
                    Console.WriteLine("\t{0}",LectorArchivo.ReadString());
                }
            }
            public void CerrarArchivoLectura()
            {
                ArchivoBinarioLector.Close();
                LectorArchivo.Close();
            }

            //Creación de archivo y métodos de edición
            public void AbrirArchivoParaEditar()
            {
                ArchivoBinarioEscritor = new FileStream(this.directorio_archivo, FileMode.Append, FileAccess.Write);
                EscritorArchivo = new BinaryWriter(ArchivoBinarioEscritor);
            }

            public void Agregar(string text)
            {
                EscritorArchivo.Write(text);
            }
            public void Agregar(short numbre)
            {
                EscritorArchivo.Write(numbre);
            }

            public void CerrarArchivoEditor()
            {
                ArchivoBinarioEscritor.Close();
                EscritorArchivo.Close();
            }

            //Destructor de la clase
            ~clsArchivoBinario()
            {
                Console.WriteLine("\n\tMemoria Liberada de la Clase ArchivoBinario: " + directorio_archivo);
            }
        }

        //Funciones auxiliares
        //Función auxiliar para comprobar que el semestre exista
        public static void ComprobarSemestre(short semestre)
        {
            if (!(semestre >= 0 && semestre <= 15))
            {
                throw new SemestreInexistenteException("El semestre ingresado no existe, por favor ingrese un semestre real");
            }
        }

        //Función auxiliar para comprobar que la calificación exista
        public static void ComprobarCalificacion(short calificacion)
        {
            if (!(calificacion >= 0 && calificacion <= 100))
            {
                throw new SemestreInexistenteException("La calificación ingresada no es válida, por favor ingrese una calificación real");
            }
        }
        static void Main(string[] args)
        {
            //Declaración de variables auxiliares para creación de objeto clsAlumno
            string nombre_alumno, matricula_alumno;
            short semestre_alumno, calificacion_alumno;
            //Declaración de variable auxiliar para el nombre/directorio del archivo
            string directorio;

            //Declaración de variables auxiliares para menú y contadores
            bool ejecucion = true;
            int aux_opcion_numero__menu = 0;

            //Ciclo do while para controlar el menú
            do
            {
                //Bloque try en donde se puede generar una excepción
                try
                {   //Despliegue de menú
                    Console.WriteLine("\n\t\t.: * MENÚ DE OPCIONES * :.");
                    Console.WriteLine("\t| Este programa crea archivos de alumnos |");
                    Console.WriteLine("\n\t1) - Crear nuevo archivo" +
                                      "\n\t2) - Agregar alumno a un archivo" +
                                      "\n\t3) - Desplegar la información de un archivo de alumnos" +
                                      "\n\t4) - Salir del programa");

                    //Captura de datos
                    Console.Write("\n\n\tIngrese el número de la opción que desea realizar: ");
                    aux_opcion_numero__menu = short.Parse(Console.ReadLine());
                    Console.Write("\n\tDato capturado correctamente" +
                                  "\n\tPresione la tecla <Enter> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    Console.Clear();

                    //Switch case para controlar las opciones
                    switch (aux_opcion_numero__menu)
                    {   //Opción uno
                        case 1:
                            {   //Captura de datos
                                Console.WriteLine("\n\t   .: * NUEVO ARCHIVO * :.");
                                Console.WriteLine("\t| Agrege los datos del alumno |");
                                Console.Write("\n\n\tIngrese el nombre del alumno: "); nombre_alumno = Console.ReadLine();
                                Console.Write("\n\n\tIngrese la matrícula del alumno: "); matricula_alumno = Console.ReadLine();
                                Console.Write("\n\n\tIngrese el semestre del alumno: "); semestre_alumno = short.Parse(Console.ReadLine());
                                //Comprobación de semestre
                                ComprobarSemestre(semestre_alumno);
                                Console.Write("\n\n\tIngrese la calificación del alumno: "); calificacion_alumno = short.Parse(Console.ReadLine());
                                //Comprobación de calificación
                                ComprobarCalificacion(calificacion_alumno);
                                Console.WriteLine("\n\t| Agrege los datos del archivo |");
                                Console.Write("\n\tIngrese el nombre del archivo: "); directorio = Console.ReadLine() + ".dat";

                                //Creación de instancia
                                clsArchivoBinario Alumno = new clsArchivoBinario(directorio);

                                //Llamada a métodos de escritura de archivo
                                Alumno.CreaArchivoEscritor();
                                Alumno.Escribir(nombre_alumno);
                                Alumno.Escribir(matricula_alumno);
                                Alumno.Escribir(semestre_alumno);
                                Alumno.Escribir(calificacion_alumno);
                                Alumno.Escribir("------------------------------");
                                Console.WriteLine("\n\tEl alumno ha sido agregado correctamente");

                                //Liberación de espacio en memoria
                                nombre_alumno = ""; matricula_alumno = "";
                                semestre_alumno = 0; calificacion_alumno = 0;
                                directorio = "";
                                aux_opcion_numero__menu = 0;
                                Alumno.CerrarArchivoEscritor();
                            }
                            break;
                        //Opción 2
                        case 2:
                            {
                                Console.WriteLine("\n\t\t.: * EDITAR ARCHIVO * :.");
                                Console.Write("\n\tIngrese el nombre del archivo: "); directorio = Console.ReadLine() + ".dat";
                                
                                //Validar directorio
                                bool file_exist = File.Exists(directorio);
                                if (!file_exist)
                                {
                                    throw new FileNotFoundException();
                                }
                                //Creación de instancia
                                clsArchivoBinario ArchivoBinario = new clsArchivoBinario(directorio);

                                //Llamada a métodos de escritura
                                ArchivoBinario.AbrirArchivoParaEditar();

                                Console.WriteLine("\n\t| Archivo encontrado, ingrese los datos del nuevo alumno |");
                                Console.Write("\n\n\tIngrese el nombre del alumno: "); nombre_alumno = Console.ReadLine();
                                Console.Write("\n\n\tIngrese la matrícula del alumno: "); matricula_alumno = Console.ReadLine();
                                Console.Write("\n\n\tIngrese el semestre del alumno: "); semestre_alumno = short.Parse(Console.ReadLine());
                                ComprobarSemestre(semestre_alumno);
                                Console.Write("\n\n\tIngrese la calificación del alumno: "); calificacion_alumno = short.Parse(Console.ReadLine());
                                ComprobarCalificacion(calificacion_alumno);

                                ArchivoBinario.Agregar(nombre_alumno);
                                ArchivoBinario.Agregar(matricula_alumno);
                                ArchivoBinario.Agregar(semestre_alumno);
                                ArchivoBinario.Agregar(calificacion_alumno);
                                ArchivoBinario.Agregar("------------------------------");

                                Console.WriteLine("\n\tEl nuevo alumno ha sido agregado al archivo");

                                //Liberación de espacio en memoria
                                nombre_alumno = ""; matricula_alumno = "";
                                semestre_alumno = 0; calificacion_alumno = 0;
                                directorio = "";
                                aux_opcion_numero__menu = 0;
                                ArchivoBinario.CerrarArchivoEditor();
                                file_exist = false;
                            }
                            break;

                        //Opción 3
                        case 3:
                            {
                                Console.WriteLine("\n\t   .: * BUSCAR ARCHIVO * :.");
                                Console.Write("\n\tIngrese el nombre del archivo que desea mostrar: "); directorio = Console.ReadLine() + ".dat";
                                Console.Write("\n\n\tPresione la tecla <Enter> para continuar...");
                                Console.ReadKey(); Console.Clear();

                                //Validar directorio
                                bool file_exist = File.Exists(directorio);
                                if (!file_exist)
                                {
                                    throw new FileNotFoundException();
                                }

                                //Despliegue de información
                                Console.WriteLine("\n\t   .: * DESPLEGAR INFORMACIÓN DE ARCHIVO * :.");
                                Console.WriteLine("\t| Estos son los alumnos registrados en el archivo |\n");
                                Console.WriteLine("\t------------------------------");
                                //Creacion de instancia
                                clsArchivoBinario ArchivoBinario = new clsArchivoBinario(directorio);
                                
                                //Llamada a métodos
                                ArchivoBinario.CrearArchivoDeLectura();
                                ArchivoBinario.Leer();

                                //Liberación de espacio en memoria
                                aux_opcion_numero__menu = 0;
                                directorio = "";
                                ArchivoBinario.CerrarArchivoLectura();
                                file_exist = false;
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("\n\t\t.: * SALIDA * :.");
                            }
                            break;
                        default:
                            {
                                throw new OpcionInvalidaMenuException("El dato ingresado no ha sido válido, intentelo de nuevo");
                            }
                    }
                }
                //Bloques catch
                catch (OpcionInvalidaMenuException e)
                {
                    Console.WriteLine("\n\t\t.: * ERROR * :.");
                    Console.WriteLine("\n\tMensaje de error: " + e.Message);
                    Console.WriteLine("\n\tRuta del error: " + e.StackTrace);
                    aux_opcion_numero__menu = 0;
                }
                catch (SemestreInexistenteException f)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: * ERROR * :.");
                    Console.WriteLine("\n\tMensaje de error: " + f.Message);
                    Console.WriteLine("\n\tRuta del error: " + f.StackTrace);
                }
                catch (CalificacionInexistenteException g)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: * ERROR * :.");
                    Console.WriteLine("\n\tMensaje de error: " + g.Message);
                    Console.WriteLine("\n\tRuta del error: " + g.StackTrace);
                }
                catch (ArgumentOutOfRangeException h)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: * ERROR * :.");
                    Console.WriteLine("\n\tMensaje de error: " + h.Message);
                    Console.WriteLine("\n\tRuta del error: " + h.StackTrace);
                }
                catch (OverflowException i)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: * ERROR * :.");
                    Console.WriteLine("\n\tMensaje de error: " + i.Message);
                    Console.WriteLine("\n\tRuta del error: " + i.StackTrace);
                }
                catch (FormatException j)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: * ERROR * :.");
                    Console.WriteLine("\n\tMensaje de error: " + j.Message);
                    Console.WriteLine("\n\tRuta del error: " + j.StackTrace);
                }
                catch (FileNotFoundException k)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t\t.: * ERROR * :.");
                    Console.WriteLine("\n\tMensaje de error: " + k.Message);
                    Console.WriteLine("\n\tRuta del error: " + k.StackTrace);
                }
                //Bloque finally
                finally
                {
                    if (aux_opcion_numero__menu == 4)
                    {
                        Console.Write("\n\tGracias por usar nuestro software\n\tPresione la tecla <Esc> para salir...");
                        while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                        ejecucion = false;
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t.: * REGRESANDO AL MENÚ * :.");
                        Console.Write("\n\tPresione la tecla <Enter> para regresar al menú...");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                        Console.Clear();
                        aux_opcion_numero__menu = 0;
                    }
                }
            }
            while (ejecucion);
        }
    }
}