using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa20___Practica_Unidad_2
{
    internal class Program
    {  
        //Declaración de la clase
        class EscolaresITT
        {
            //Campos de la clase
            string nombre_alumno, carrera_alumno, turno_alumno;
            int numero_control_alumno, semestre_alumno;
            //Constructor de la clase
            public EscolaresITT(string nombre_alumno, int numero_control_alumno, int semestre_alumno, string carrera_alumno, string turno_alumno)
            {
                this.nombre_alumno = nombre_alumno;
                this.numero_control_alumno = numero_control_alumno;
                this.semestre_alumno = semestre_alumno;
                this.carrera_alumno=carrera_alumno;
                this.turno_alumno = turno_alumno;
            }
            //Método sobrecargado para calcular inscripcíon
            public float CalcularInscripcion(float cuota_inscripcion)
            {
                return cuota_inscripcion * 1.8f; 
            }
            public float CalcularInscripcion(float cuota_inscripcion, float cuota_sociedad_alumnos)
            {
                return (cuota_inscripcion + cuota_sociedad_alumnos ) * 1.8f;
            }
            public float CalcularInscripcion(float cuota_inscripcion, float cuota_sociedad_alumnos, float cuota_biblioteca)
            {
                return (cuota_inscripcion + cuota_sociedad_alumnos + cuota_biblioteca) * 1.8f;
            }
            //Método para desplegar información
            public void DesplegarInformacion(float cuota_final)
            {
                Console.WriteLine("\tEl estudiante {0}, con número de control {1}, de la carrera de {2},",this.nombre_alumno, this.numero_control_alumno,this.carrera_alumno);
                Console.WriteLine("\tse incribió al semestre {0} en el turno {1} con una cuota de inscripción de {2:C}",this.semestre_alumno,this.turno_alumno, cuota_final);
            }
            //Declaración de destructor
            ~EscolaresITT()
            {
                Console.WriteLine("\n\tMemoria Objeto Escolares Liberada" + this.nombre_alumno);
            }
        }
        static void Main(string[] args)
        {
            //Declaración de variables
            string nombre_alumno, carrera_alumno, turno_alumno;
            int numero_control_alumno, semestre_alumno;
            float cuota_final, cuota_inscripcion, cuota_socieadad_alumnos, cuota_biblioteca;

            //Captura de datos
            Console.WriteLine("\t\t\t*** Bienvenido ***");
            Console.Write("\tIngrese el nombre del alumno: ");
            nombre_alumno = Console.ReadLine();
            Console.Write("\tIngrese el número de control del alumno: ");
            numero_control_alumno = int.Parse(Console.ReadLine());
            Console.Write("\tIngrese la carrera del alumno: ");
            carrera_alumno = Console.ReadLine();
            Console.Write("\tIngrese el semestre al que se incribirá el alumno: ");
            semestre_alumno = int.Parse(Console.ReadLine());
            Console.Write("\tIngrese el turno al que se inscribirá el alumno: ");
            turno_alumno = Console.ReadLine();
            Console.Write("\n\tDatos almacenados correctamete.\n\tPresione la tecla <Enter> para cargar los datos...");
            while (Console.ReadKey().Key != ConsoleKey.Enter);
            Console.Clear();

            //Creación del objeto
            EscolaresITT Alumno1 = new EscolaresITT(nombre_alumno, numero_control_alumno, semestre_alumno, carrera_alumno, turno_alumno);

            //Captura de datos
            Console.Write("\tIngresa la cuota de inscripción: "); cuota_inscripcion = float.Parse(Console.ReadLine());
            Console.Write("\tIngresa la cuota de sociedad de alumnos"); cuota_socieadad_alumnos = float.Parse(Console.ReadLine());
            Console.Write("\tIngrese el adeudo de biblioteca: "); cuota_biblioteca = float.Parse(Console.ReadLine());

            //Captura y despliegue de datos
            Console.WriteLine("\t\t*** Resultado de primer inscripción ***");
            cuota_final = Alumno1.CalcularInscripcion(cuota_inscripcion);
            Alumno1.DesplegarInformacion(cuota_final);
            Console.WriteLine("\t\t*** Resultado de segunda inscripción ***");
            cuota_final = Alumno1.CalcularInscripcion(cuota_inscripcion, cuota_socieadad_alumnos);
            Alumno1.DesplegarInformacion(cuota_final);
            Console.WriteLine("\t\t*** Resultado de tercera inscripción ***");
            cuota_final = Alumno1.CalcularInscripcion(cuota_inscripcion,cuota_socieadad_alumnos, cuota_biblioteca);
            Alumno1.DesplegarInformacion(cuota_final);
            Console.Write("\n\tProceso terminado. Presione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
    }
}