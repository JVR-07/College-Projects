using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa23___Constructores_Destructores_Herencia
{
    internal class Program
    {   //Declaración de la clase
        class Escuela
        {
            //Campos de la clase base
            public string nombre_escuela, direccion_escuela;
            public long telefono_escuela;
            //Constructor de la clase
            public Escuela(string nombre_escuela, string direccion_escuela, long telefono_escuela)
            {
                this.nombre_escuela = nombre_escuela;
                this.direccion_escuela = direccion_escuela;
                this.telefono_escuela = telefono_escuela;
            }
            //Método de la clase
            public void DesplegarEscuela()
            {
                Console.WriteLine("\tEl nombre de la escuela es: {0}", this.nombre_escuela);
                Console.WriteLine("\tLa dirección de la escuela es: {0}", this.direccion_escuela);
                Console.WriteLine("\tEl teléfono de la escuela es: {0}", this.telefono_escuela);
            }
            //Destructor de la clase
            ~Escuela()
            {
                Console.WriteLine("\n\tMemoria liberada del Objeto Escuela " + this.nombre_escuela);
            }
        }
        //Declaración de clase derivada
        class Alumno : Escuela
        {
            //Campos de la clase
            string nombre_alumno, carrera_alumno;
            int numero_control_alumno;
            short semestre_alumno;
            //Constructor de la clase
            public Alumno(string nombre_alumno, int numero_control_alumno, string carrera_alumno, short semestre_alumno, string nombre_escuela, string direccion_escuela, long telefono_escuela) : base(nombre_escuela,direccion_escuela,telefono_escuela)
            {
                this.nombre_alumno = nombre_alumno;
                this.numero_control_alumno = numero_control_alumno;
                this.carrera_alumno = carrera_alumno;
                this.semestre_alumno = semestre_alumno;
            }
            //Método de la clase
            public void DesplegarAlumno()
            {
                Console.WriteLine("\tEl nombre del alumno es: {0}",this.nombre_alumno);
                Console.WriteLine("\tEl número de control del alumno es: {0}",this.numero_control_alumno);
                Console.WriteLine("\tLa carrera del alumno es: {0}",this.carrera_alumno);
                Console.WriteLine("\tEl semestre del alumno es: {0}",this.semestre_alumno);
                Console.WriteLine("\tEl nombre de la escuela es: {0}", nombre_escuela);
                Console.WriteLine("\tLa dirección de la escuela es: {0}", direccion_escuela);
                Console.WriteLine("\tEl teléfono de la escuela es: {0}", telefono_escuela);
            }
            //Destructor de la clasee
            ~Alumno()
            {
                Console.WriteLine("\n\tMemoria liberada del Objeto Alumno " + this.nombre_alumno);
            }
        }
        //Declaración de segunda clase derivada
        class Maestro : Escuela
        {
            //Campos de la clase
            string nombre_maestro, profesion_maestro, departamento_maestro;
            int numero_filiacion;
            //Constructor de la clase
            public Maestro(string nombre_maestro, string profesion_maestro, string departamento_maestro, int numero_filiacion, string nombre_escuela, string direccion_escuela, long telefono_escuela) : base (nombre_escuela, direccion_escuela, telefono_escuela)
            {
                this.nombre_maestro = nombre_maestro;
                this.profesion_maestro = profesion_maestro;
                this.departamento_maestro = departamento_maestro;
                this.numero_filiacion = numero_filiacion;
            }
            //Método de la clase
            public void DesplegarMaestro()
            {
                Console.WriteLine("\tEl nombre del maestro es: {0}",this.nombre_maestro);
                Console.WriteLine("\tLa profesión del maestro es: {0}",this.profesion_maestro);
                Console.WriteLine("\tEl departamento del maestro es: {0}",this.departamento_maestro);
                Console.WriteLine("\tEl número de filiación: {0}",this.numero_filiacion);
                Console.WriteLine("\tEl nombre de la escuela es: {0}", nombre_escuela);
                Console.WriteLine("\tLa dirección de la escuela es: {0}", direccion_escuela);
                Console.WriteLine("\tEl teléfono de la escuela es: {0}", telefono_escuela);
            }
            //Destructor de la clase
            ~Maestro()
            {
                Console.WriteLine("\n\tMemoria liberada del Objeto Maestro " + this.nombre_maestro);
            }
        }
        static void Main(string[] args) 
        {   //Declaración de variables auxiliares
            string nombre_escuela, direccion_escuela, nombre_alumno, carrera_alumno, nombre_maestro, profesion_maestro, departamento_maestro;
            long telefono_escuela;
            int numero_control_alumno, numero_filiacion;
            short semestre_alumno;
            //Captura de datos
            nombre_escuela = CapturaString("el nombre de la escuela");
            direccion_escuela = CapturaString("la dirección de la escuela");
            telefono_escuela = CapturaLong("el número de la escuela");
            Console.Write("\tDatos capturados correctamente.\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de la instancia de la clase base
            Escuela ITT = new Escuela(nombre_escuela, direccion_escuela, telefono_escuela);
            //Ejecución de método clase base
            ITT.DesplegarEscuela();
            Console.Write("\tEl proceso ha terminado.\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Captura de datos
            nombre_alumno = CapturaString("el nombre del alumno");
            numero_control_alumno = CapturaInt("el número de control del alumno");
            carrera_alumno = CapturaString("la carrera del alumno");
            semestre_alumno = CapturaShort("el semestre del alumno");
            //Creacion objeto clase derivada
            Alumno EstudianteITT = new Alumno(nombre_alumno, numero_control_alumno, carrera_alumno, semestre_alumno, ITT.nombre_escuela, ITT.direccion_escuela, ITT.telefono_escuela);
            //Llamada a métodos
            EstudianteITT.DesplegarAlumno();
            Console.Write("\tEl proceso ha terminado.\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Captura de datos
            nombre_maestro = CapturaString("el nombre del maestro");
            numero_filiacion = CapturaInt("el número de filiación");
            profesion_maestro = CapturaString("la profesión del maestro");
            departamento_maestro = CapturaString("el departamento del maestro");
            //Creación de objeto clase derivada
            Maestro MaestroITT = new Maestro(nombre_maestro, profesion_maestro, departamento_maestro, numero_filiacion, ITT.nombre_escuela, ITT.direccion_escuela, ITT.telefono_escuela);
            //Llamada a método
            MaestroITT.DesplegarMaestro();
            Console.WriteLine("\n\tEl proceso ha terminado");
            Console.Write("\tPresione la tecla <Esc> para cerrar el programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
        //Declaración de funciones auxiliares para capturar datos
        static string CapturaString(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return Console.ReadLine();
        }
        static int CapturaInt(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return int.Parse(Console.ReadLine());
        }

        static short CapturaShort(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return short.Parse(Console.ReadLine());
        }

        static long CapturaLong(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return long.Parse(Console.ReadLine());
        }
    }
}