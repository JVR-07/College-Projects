using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa14___Clase_Coche
{
    internal class Program
    {
        //Creacion de la clase
        public class Coche
        {   
            // Declaración de campos de la clase
            string colorCoche, modeloCoche;
            int velocidadMaximaCoche;
            bool motorEncendidoCoche;

            //Creación del constructor de la clase
            public Coche(string _colorCoche, string _modeloCoche, int _velocidadMaximaCoche)
            {
                colorCoche = _colorCoche;
                modeloCoche = _modeloCoche;
                velocidadMaximaCoche = _velocidadMaximaCoche;
                motorEncendidoCoche = false;
            }

            // Declaración de métodos de la clase
            public void arrancar()
            {
                if (motorEncendidoCoche == true)
                {
                    Console.WriteLine("\tEl motor ya está encendido.");
                }
                else
                {
                    motorEncendidoCoche = true;
                    Console.WriteLine("\tEl motor ha encendido.");
                }
            }
            public void visualizar()
            {
                Console.WriteLine("\tEl coche es un {0} de color {1}.\n\tSu velocidad máxima es de {2}",modeloCoche,colorCoche,velocidadMaximaCoche);
                if(motorEncendidoCoche == true)
                {
                    Console.WriteLine("\tEl motor está encendido.");
                }
                else
                {
                    Console.WriteLine("\tEl motor está apagado.");
                }
            }
            //Destructor
            ~Coche()
            {
                Console.WriteLine("\n\tLa memoria del objeto coche ha sido liberada exitosamente.");
            }
        }
        static void Main(string[] args)
        {
            //Declaracion de variables
            string colorCoche, modeloCoche, preguntaEncenderCoche;
            int velocidadMaximaCoche;
            short opcion = 0;
            //Captura de datos
            Console.Write("\tIngrese el color del coche: "); colorCoche = Console.ReadLine();
            Console.Write("\n\tIngrese el modelo del coche: "); modeloCoche = Console.ReadLine();
            Console.Write("\n\tIngrese la velocidad máxima del coche(en kilómetros): "); velocidadMaximaCoche = Convert.ToInt16(Console.ReadLine());
            // Inicialización del objeto
            Coche miCoche = new Coche(colorCoche, modeloCoche, velocidadMaximaCoche);
            Console.Clear();
            Console.Write("\t¿Desea encender el vehiculo? ~sí | ~no: "); preguntaEncenderCoche = Console.ReadLine();
            do
            {
                switch (preguntaEncenderCoche)
                {
                    case "si":
                        {   // Uso del método arrancar
                            miCoche.arrancar();
                            opcion = 1;
                        }
                        break;
                    case "sí":
                        {   // Uso del método arrancar
                            miCoche.arrancar();
                            opcion = 1;
                        }
                        break;
                    case "no":
                        {
                            opcion = 1;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("\tLa respuesta no ha sido válida, asegúrese de escribirla correctamente(minúsculas).");
                        }
                        break;
                }
                Console.Clear();
            }
            while (opcion != 1);
            // Uso del método visualizar
            miCoche.visualizar();
            Console.Write("\tEl programa ha finalizado, presione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}