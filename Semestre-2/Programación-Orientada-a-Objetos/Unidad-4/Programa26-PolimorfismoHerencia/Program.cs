using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa26_PolimorfismoHerencia
{
    internal class Program
    {
        //Declaración de clase base
        class Animal
        {
            //Método de clase base
            public void Desplazarse()
            {

            }
            //Destructor de la clase
            ~Animal()
            {
                Console.WriteLine("\n\tMemoria liberada clase base Animal");
            }
        }
        //Declaración de clase derivada Mamífero
        class Mamifero : Animal
        {
            //Campos de la clase derivada mamífero
            public string nombre_mamifero;
            //Constructor de la clase mamífero
            public Mamifero(string nombre_mamifero)
            {
                this.nombre_mamifero = nombre_mamifero;
            }
            //Método de la clase derivada mamífero
            public new void Desplazarse() 
            {
                Console.WriteLine("\tHola mi nombre es: {0} y me desplazo caminando.", this.nombre_mamifero);
            }
            //Destructor de la clase derivada mamífero
            ~Mamifero()
            {
                Console.WriteLine("\n\tMemoria Liberada clase derivada Mamífero " + this.nombre_mamifero);
            }
        }
        //Declaración de clase derivada Ave
        class Ave : Animal
        {
            //Campos de la clase derivada ave
            public string nombre_ave;
            //Constructor de la clase ave
            public Ave(string nombre_ave)
            {
                this.nombre_ave = nombre_ave;
            }
            //Método de la clase derivada ave
            public new void Desplazarse()
            {
                Console.WriteLine("\tHola mi nombre es: {0} y me desplazo volando.", this.nombre_ave);
            }
            //Destructor de la clase derivada ave
            ~Ave()
            {
                Console.WriteLine("\n\tMemoria Liberada clase derivada Ave " + this.nombre_ave);
            }
        }
        //Declaración de clase derivada Pez
        class Pez : Animal
        {
            //Campos de la clase derivada Pez
            public string nombre_pez;
            //Constructor de la clase pez
            public Pez(string nombre_pez)
            {
                this.nombre_pez = nombre_pez;
            }
            //Método de la clase derivada pez
            public new void Desplazarse()
            {
                Console.WriteLine("\tHola mi nombre es: {0} y me desplazo nadando.", this.nombre_pez);
            }
            //Destructor de la clase derivada pez
            ~Pez()
            {
                Console.WriteLine("\n\tMemoria Liberada clase derivada Pez " + this.nombre_pez);
            }
        }
        //Declaración de clase derivada Reptil
        class Reptil : Animal
        {
            //Campos de la clase derivada Reptil
            public string nombre_reptil;
            //Constructor de la clase reptil
            public Reptil(string nombre_reptil)
            {
                this.nombre_reptil = nombre_reptil;
            }
            //Método de la clase derivada reptil
            public new void Desplazarse()
            {
                Console.WriteLine("\tHola mi nombre es: {0} y me desplazo reptando.", this.nombre_reptil);
            }
            //Destructor de la clase derivada reptil
            ~Reptil()
            {
                Console.WriteLine("\n\tMemoria Liberada clase derivada Reptil " + this.nombre_reptil);
            }
        }
        //Declaración de funciones auxiliares para captura de datos
        static string CapturaString(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {   //Declaración de variables
            string nombre_mamifero, nombre_ave, nombre_pez, nombre_reptil;
            //Captura de datos
            Console.WriteLine("\n\t\t\t*** Bienvenido ***");
            Console.WriteLine("\n\tIngrese los nombres para continuar.");
            Console.WriteLine("\n");
            nombre_mamifero = CapturaString("el nombre del mamífero");
            nombre_ave = CapturaString("el nombre del ave");
            nombre_pez = CapturaString("el nombre del pez");
            nombre_reptil = CapturaString("el nombre del reptil");
            Console.WriteLine("\n\tDatos capturados correctamente");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de objeto y llamada a método
            Mamifero Mamifero1 = new Mamifero(nombre_mamifero);
            Console.WriteLine("\n\t\t\t*** Acción ***\n");
            Mamifero1.Desplazarse();
            Console.WriteLine("\tEl proceso ha terminado exitosamente.");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de objeto y llamada a método
            Ave Ave1 = new Ave(nombre_ave);
            Console.WriteLine("\n\t\t\t*** Acción ***\n");
            Ave1.Desplazarse();
            Console.WriteLine("\tEl proceso ha terminado exitosamente.");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de objeto y llamada a método
            Pez Pez1 = new Pez(nombre_pez);
            Console.WriteLine("\n\t\t\t*** Acción ***\n");
            Pez1.Desplazarse();
            Console.WriteLine("\tEl proceso ha terminado exitosamente.");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de objeto y llamada a método
            Reptil Reptil1 = new Reptil(nombre_reptil);
            Console.WriteLine("\n\t\t\t*** Acción ***\n");
            Reptil1.Desplazarse();
            Console.WriteLine("\tEl proceso ha terminado exitosamente.");
            //Mensaje final
            Console.Write("\tPresione la tecla <Esc> para cerrar el programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}