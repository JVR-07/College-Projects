using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa21___Herencia_clase_persona_y_trabajador
{
    internal class Program
    {
        class Persona //clase base
        {
            public string Nombre; // campo de objeto Persona que almacena su nombre
            public int Edad; // campo de objeto Persona que almacena su edad
            public string NIP; // campo de objeto Persona que almacena su NIP
                               // constructor de Persona
            public Persona(string nombre, int edad, string nip)
            {
                Nombre = nombre;
                Edad = edad;
                NIP = nip;
            }
            public void Cumpleaños() // método que incrementa en uno la Edad
            {
                Edad++;
            }
            public void DesplegarDatosPersona()
            {
                Console.WriteLine("\tEl nombre es: " + Nombre);
                Console.WriteLine("\tLa edad es: " + Edad);
                Console.WriteLine("\tEl NIP es: " + NIP);
            }
            //Destructor de la clase
            ~Persona()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto " + Nombre);
            }
        } //fin clase base
        class Trabajador : Persona //clase derivada
        {
            public float Sueldo; //campo de objeto Trabajador que almacena su sueldo
                                 //constructor de Trabajador
            public Trabajador(string nombre, int edad, string nip, float sueldo)
            : base(nombre, edad, nip) //inicializa Trabajador en base al constructor de la clase Persona
            {
                Sueldo = sueldo;
            }
            public void DesplegarDatosTrabajador()
            {
                Console.WriteLine("\tEL nombre es: " + Nombre);
                Console.WriteLine("\tLa edad es: " + Edad);
                Console.WriteLine("\tEl NIP es: " + NIP);
                Console.WriteLine("\tEl sueldo es: {0:C}",Sueldo);
            }
            ~Trabajador()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto " + Nombre);
            }
        } //fin clase derivada
        static void Main(string[] args)
        {   //Declaración de variables
            string nombre, NIP;
            int edad;
            float sueldo;
            //Captura de datos
            Console.Write("\tIngrese el nombre: "); nombre = Console.ReadLine();
            Console.Write("\tIngrese la edad: "); edad = int.Parse(Console.ReadLine());
            Console.Write("\tIngrese su NIP: "); NIP = Console.ReadLine();
            //Creación del objeto de clase basae
            Persona MiPersona = new Persona(nombre, edad, NIP);
            //Llamada a método de clase base
            MiPersona.DesplegarDatosPersona();
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Captura de datos
            Console.Write("\tIngrese su sueldo: "); sueldo = float.Parse(Console.ReadLine());
            //Creacion del objeto de la clase base
            Trabajador MiTrabajador = new Trabajador(MiPersona.Nombre, MiPersona.Edad, MiPersona.NIP, sueldo);
            //Llamada a método heredado
            MiTrabajador.Cumpleaños();
            //Llamada a método de la clase derivada
            MiTrabajador.DesplegarDatosTrabajador();
            Console.Write("\tEl programa ha finalizado\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
