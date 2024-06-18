using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Registros_Personas
{
    internal class Program
    {   //Estructura para guardar los registros
        struct structPersona
        {
            public string Nombre;
            public DateTime FechaNacimiento;
            public int Edad;
            public string CiudadNacimiento;
        }
        //Función para comprobar fecha
        static int calcularEdad(DateTime fecha_actual, DateTime fecha_nacimiento)
        {
            TimeSpan Diferencia = fecha_actual - fecha_nacimiento;
            return Diferencia.Days / 365;
        }
        static void Main(string[] args)
        {
            //Declaración de Objeto tipo DateTime y especificacion de formato
            DateTime fecha_actual = DateTime.Now;
            CultureInfo SpanishFormat = new CultureInfo("es-ES");
            int C = 0; char reset = ' ';
            //Declaración de objeto de estructura
            structPersona[] Persona = new structPersona[50];

            //Captura de datos
            do
            {
                Console.WriteLine("\n\t\t.: CAPTURA DE DATOS DE LA PERSONA {0} :." +
                                    "\n\t| Ingrese los datos que se le pidan |", C + 1);
                Console.Write("\n\tNombre de la Persona: "); Persona[C].Nombre = Console.ReadLine();
                Console.Write("\n\tFecha de Nacimiento(dd/MM/yyyy): "); Persona[C].FechaNacimiento = Convert.ToDateTime(Console.ReadLine(), SpanishFormat);
                Persona[C].Edad = calcularEdad(fecha_actual, Persona[C].FechaNacimiento);
                Console.Write("\n\tCiudad de Nacimiento: "); Persona[C].CiudadNacimiento = Console.ReadLine();

                Console.Write("\n\n\tDatos capturados correctamente." +
                                "\n\t¿Desea realiza otro registro? S | N" +
                                "\n\tIngrese la letra de la opción deseada: ");
                reset = char.Parse(Console.ReadLine().ToUpper());
                if (reset == 'S')
                {
                    Console.Write("\n\tPresione la tecla <INTRO> para ingresar otra persona...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;                
                }
                else if (reset == 'N')
                {
                    Console.Write("\n\tPresione la tecla <Esc> para terminar la captura...");
                    while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                }
                Console.Clear();
                C++;
            } while (reset == 'S') ;
            
            //Impresión de datos
            Console.WriteLine("\n\t\t.: IMPRESIÓN DE DATOS DE LAS PERSONAS :.");
            Console.WriteLine("\n\tNombre\t\tFecha de Nacimiento\t\tEdad\tLugar de Nacimiento");
            for(int i = 0; i < C; i++)
            {
                Console.Write("\n\t{0}\t\t{1}\t{2}\t{3}", Persona[i].Nombre, Persona[i].FechaNacimiento, Persona[i].Edad, Persona[i].CiudadNacimiento);
            }
            Console.Write("\n\n\tDatos mostrados correctamente." +
                            "\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}