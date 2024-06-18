using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_ExcepcionesDefinidasUsuario
{
    internal class Program
    {
                        //Creación de excepciones personalizadas

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
        public class clsAlumno
        {
            //Campos
            string nombre_alumno, matricula_alumno;
            short semestre_alumno, calificacion_alumno;
            
            //Métodos
            public string GetNombre()
            {
                return this.nombre_alumno;
            }
            public string GetMatricula()
            {
                return this.matricula_alumno;
            }
            public short GetSemestre() 
            { 
                return semestre_alumno;
            }
            public short GetCalificacion()
            {
                return calificacion_alumno;
            }

            //Constructores y destructores
            public clsAlumno(string nombre_alumno, string matricula_alumno, short semestre_alumno, short calificacion_alumno)
            {
                this.nombre_alumno = nombre_alumno;
                this.matricula_alumno = matricula_alumno;
                this.semestre_alumno = semestre_alumno;
                this.calificacion_alumno = calificacion_alumno;
            }
            ~clsAlumno()
            {
                Console.WriteLine("\n\tMemoria Liberada del Objeto clsAlumno." + this.nombre_alumno);
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

            //Declaración de lista
            List<clsAlumno> Lista_Alumnos = new List<clsAlumno>();

            //Declaración de variables auxiliares para menú y contadores
            bool ejecucion = true;
            int contador_alumnos = 0, aux_opcion_numero__menu = 0,posicion_alumno = 0;

            //Ciclo do while para controlar el menú
            do
            {
                //Bloque try en donde se puede generar una excepción
                try
                {   //Despliegue de menú
                    Console.WriteLine("\n\t\t.: * MENÚ DE OPCIONES * :.");
                    Console.WriteLine("\t| Este programa crea listas de alumnos |");
                    Console.WriteLine("\n\t1) - Añadir alumno" +
                                      "\n\t2) - Eliminar alumno" +
                                      "\n\t3) - Desplegar información de alumnos" +
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
                                Console.WriteLine("\n\t   .: * NUEVO ALUMNO * :.");
                                Console.WriteLine("\t| Agrege los datos del alumno |");
                                Console.Write("\n\n\tIngrese el nombre del alumno: "); nombre_alumno = Console.ReadLine();
                                Console.Write("\n\n\tIngrese la matrícula del alumno: "); matricula_alumno = Console.ReadLine();
                                Console.Write("\n\n\tIngrese el semestre del alumno: "); semestre_alumno = short.Parse(Console.ReadLine());
                                //Comprobación de semestre
                                ComprobarSemestre(semestre_alumno);
                                Console.Write("\n\n\tIngrese la calificación del alumno: "); calificacion_alumno = short.Parse(Console.ReadLine());
                                //Comprobación de calificación
                                ComprobarCalificacion(calificacion_alumno);
                                Console.WriteLine("\n\tDatos capturados correctamente");

                                //Creación de instancia dentro de una lista
                                Lista_Alumnos.Add(new clsAlumno(nombre_alumno, matricula_alumno, semestre_alumno, calificacion_alumno));
                                Console.WriteLine("\tEl alumno ha sido agregado correctamente");

                                contador_alumnos++;

                                //Liberación de espacio en memoria
                                nombre_alumno = ""; matricula_alumno = "";
                                semestre_alumno = 0; calificacion_alumno = 0;
                                aux_opcion_numero__menu = 0;
                            }
                            break;
                        //Opción 2
                        case 2:
                            {   //Despliegue de alumnos en la lista
                                Console.WriteLine("\n\t\t.: * ELIMINAR ALUMNO * :.");
                                Console.WriteLine("\t| Hay un total de {0} alumnos registrados |\n",contador_alumnos);

                                if (Lista_Alumnos.Count == 0)
                                {
                                    Console.WriteLine("\n\tNo hay alumnos registrados");
                                }
                                else
                                {
                                    //foreach para recorrer toda la colección
                                    foreach (var alumno in Lista_Alumnos)
                                    {
                                        posicion_alumno++;
                                        Console.WriteLine("\tAlumno {0}: Nombre: {1} | Matrícula: {2}", posicion_alumno, alumno.GetNombre(), alumno.GetMatricula());
                                    }
                                }

                                //Captura de dato
                                Console.Write("\n\n\n\tIngrese el número del alumno que desea eliminar: "); aux_opcion_numero__menu = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n\tDatos capturados correctamente");

                                //Eliminación de alumnos
                                Lista_Alumnos.Remove(Lista_Alumnos[aux_opcion_numero__menu - 1]);
                                Console.WriteLine("\tEl alumno ha sido eliminado correctamente");

                                contador_alumnos = contador_alumnos - 1;

                                //Liberación de espacio en memoria
                                aux_opcion_numero__menu = 0;
                                posicion_alumno = 0;
                            }
                            break;

                        //Opción 3
                        case 3:
                            {   //Despliegue de alumnos
                                Console.WriteLine("\n\t   .: * DESPLEGAR INFORMACIÓN * :.");
                                Console.WriteLine("\t| Hay un total de {0} alumnos registrados |\n",contador_alumnos);

                                //Condicional
                                if(Lista_Alumnos.Count == 0)
                                {
                                    Console.WriteLine("\n\tNo hay alumnos registrados");
                                }
                                else
                                {
                                    //foreach para recorrer toda la colección
                                    foreach (var alumno in Lista_Alumnos)
                                    {
                                        posicion_alumno++;
                                        Console.WriteLine("\tAlumno {0}: Nombre: {1} | Matrícula: {2}" +
                                                        "\n\t      Semestre: {3} | Calificación: {4}\n"
                                                        , posicion_alumno, alumno.GetNombre(), alumno.GetMatricula(), alumno.GetSemestre(), alumno.GetCalificacion());
                                    }
                                }

                                //Liberación de espacio en memoria
                                aux_opcion_numero__menu = 0;
                                posicion_alumno = 0;
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