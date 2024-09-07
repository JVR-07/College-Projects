using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa15___Clase_Alumno
{

    internal class Program
    { 
        //Declaración clase alumno
        class Alumno
        {
            //Campos de la clase
            private string nombreAlumno, carreraAlumno;
            private int numeroControlAlumno, promedioAlumno, semestreAlumno;
            //Constructor de la clase
            public Alumno(string nombreAlumno, int numeroControlAlumno, int semestreAlumno, int promedioAlumno, string carreraAlumno)
            {   //this. para diferenciar las variables de apoyo y los campos de la clase
                this.nombreAlumno = nombreAlumno;
                this.numeroControlAlumno = numeroControlAlumno;
                this.semestreAlumno = semestreAlumno;
                this.promedioAlumno = promedioAlumno;
                this.carreraAlumno = carreraAlumno;
            }
            //Método para desplegar información en pantalla
            public void desplegarAlumno()
            {
                Console.WriteLine("\tEl nombre del alumno es: " + this.nombreAlumno);
                Console.WriteLine("\tEl número de control del alumno es: " + this.numeroControlAlumno);
                Console.WriteLine("\tEl semestre del alumno es: " + this.semestreAlumno);
                Console.WriteLine("\tEl promedio del alumno es: " + this.promedioAlumno);
                Console.WriteLine("\tLa carrera del alumno es: " + this.carreraAlumno);
            }
            //Destructor de la clase
            ~Alumno()
            {
                Console.WriteLine("\tMemoria de la clase {0} liberada",this.nombreAlumno);
            }
        }
        static void Main(string[] args)
        {   // Declaración de variables
            string nombreAlumno, carreraAlumno;
            int numeroControlAlumno, promedioAlumno, semestreAlumno;
            //Captura de datos
            Console.Write("\n\tIngrese el nombre del alumno: "); nombreAlumno = Console.ReadLine();
            Console.Write("\n\tIngrese el número de control del alumno: "); numeroControlAlumno = int.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese el semestre del alumno: "); semestreAlumno = short.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese el promedio del alumno: "); promedioAlumno = short.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese la carrera del alumno: "); carreraAlumno = Console.ReadLine();
            Console.Clear();
            //Creación del objeto
            Alumno JavierMachado = new Alumno(nombreAlumno, numeroControlAlumno, semestreAlumno, promedioAlumno, carreraAlumno);
            //Llamada al método
            JavierMachado.desplegarAlumno();
            Console.Write("\tEl proceso ha finalizado exitosamente.\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}