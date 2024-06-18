using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3_Constructores_y_Destructores
{
    internal class Program
    {
        //Declaración de clase base
        class Emisor
        {   //Declaración de campo
            public string mensaje;
            //Declaración de constructor
            public Emisor()
            { 
                mensaje = "Hola Mundo";
                Console.WriteLine("\n\tSoy la clase emisor y mi mensaje es: " + mensaje);
            }
            //Destructor de la clase
            ~Emisor()
            {
                Console.WriteLine("\n\tClase emisor destruida");
            }
        }
        //Declaración de primer clase derivada
        class Traductor : Emisor
        {   //Declaración de constructor
            public Traductor()
            {
                Console.WriteLine("\n\tSoy la clase traductor y he traducido el mensaje...");
                mensaje = "Hello word";
            }
            //Destructor de la clase
            ~Traductor()
            {
                Console.WriteLine("\n\tClase Traductor destruida");
            }
        }
        //Declaración de segunda clase derivada
        class Receptor : Traductor
        {   //declaración de constructor
            public Receptor()
            {
                Console.WriteLine("\n\tSoy la clase receptor y he sido creada por el programador para recibir el mensaje traducido");
            }
            //Método para desplegar mensaje final
            public void DesplegarMensaje()
            {
                Console.WriteLine("\n\tEl mensaje recibido es: " + mensaje);
            }
            //Destructor de la clase
            ~Receptor()
            {
                Console.WriteLine("\n\tClase receptor destruida");
            }
        }
        static void Main(string[] args)
        {   
            /* Se llama unicamente a un solo constructor, no obstante, se llaman todos los constructores de las clases
             base debido a la jerarquia de estas. A través de los mensajes de cada constructor es como nos podemos dar 
            cuenta de que sucede esto.
             */
            Console.WriteLine("\n\t\t\t*** Ejemplo de jerarquia de constructores en herencia ***");
            //Declaración de objeto receptor
            Receptor MiReceptor = new Receptor();
            //Llamada a método del objeto
            MiReceptor.DesplegarMensaje();
            Console.Write("\n\tPrograma ejemplo finalizado.\n\tPresione la tecla <Esc> para cerrar el programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}