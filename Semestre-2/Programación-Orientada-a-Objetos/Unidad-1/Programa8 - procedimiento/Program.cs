using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Programa8___procedimiento
{
    internal class Program
    {
        // Declaración de procedimiento y tipo de variables.
        static void imprimirdatos(string numeroempleado, double horastrabajadas, double promediopiezashora, double totalpiezasproducidas, double porcentajedeerror, double piezasaceptadas, double piezasrechazadas)
        {   // Procedimiento 
            Console.WriteLine("\n\tEl trabajador con número de empleado {0}, trabajó un total de {1} horas.\n\tProdujo un total de {2} piezas, donde se aceptaron un total de {3} y se rechazarón un total de {4}.\n\tSe obtuvo un porcentaje de error del {5}% y un promedio de piezas por hora de {6}.", numeroempleado, horastrabajadas, totalpiezasproducidas, piezasaceptadas,piezasrechazadas,porcentajedeerror, promediopiezashora);
            Console.Write("\n\tEl proceso ha finalizado exitosamente, presione <INTRO> para continuar(Los datos se borrarán).");
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {   // Declaración de variables
            string opcionmenu = "";
            Random random = new Random();
            do
            {
                // Declaración de variables
                string numeroempleado = ""; double piezasaceptadas = 0.0, piezasrechazadas = 0.0, totalpiezasproducidas = 0.0, porcentajedeerror = 0.0;
                double horaentrada = 0.0, horasalida = 0.0, horastrabajadas = 0.0, promediopiezashora = 0.0;
                Console.Write("\n\t¿Qué acción desea realizar?\n\n\t- Cálcular productividad: Ingrese <calcular>\n\t- Salir: ingrese <salir>\n\tIngrese aquí la operación: ");
                opcionmenu = Console.ReadLine();
                // If para controlar menú(Era mejor usar switch case pero decidí hacerlo con if's para intentar algo nuevo).
                if (opcionmenu == "calcular")
                {
                    // Captura de datos
                    //Console.Write("\tIngrese el número de empleado: ");
                    numeroempleado = Convert.ToString(random.Next(22210000, 22219999));
                    //Console.Write("\tIngrese la hora de entrada(formato 24 horas, ejemplo: 20.00): "); 
                    horaentrada = random.Next(05,13);
                    //Console.Write("\tIngrese la hora de salidad(formato 24 horas, ejemplo: 20.00): "); 
                    horasalida = random.Next(14, 22);
                    //Console.Write("\tIngrese el total de piezas aceptadas: "); 
                    piezasaceptadas = random.Next(15, 200);
                    //Console.Write("\tIngrese el total de piezas rechazadas: "); 
                    piezasrechazadas = random.Next(0, 200);
                    // Procesos
                    horastrabajadas = horasalida - horaentrada;
                    promediopiezashora = piezasaceptadas / horastrabajadas;
                    promediopiezashora = Math.Round(promediopiezashora, 2);
                    totalpiezasproducidas = piezasaceptadas + piezasrechazadas;
                    porcentajedeerror = (piezasrechazadas * 100) / totalpiezasproducidas;
                    porcentajedeerror = Math.Round(porcentajedeerror, 2);
                    // Uso de procedimiento
                    imprimirdatos(numeroempleado, horastrabajadas, promediopiezashora, totalpiezasproducidas, porcentajedeerror, piezasaceptadas, piezasrechazadas);
                }
                else if (opcionmenu == "salir")
                {
                    Console.Write("\tGracias por usar nuestro software.\n\tPresione la tecla <ESC> para salir.");
                    while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                }
                else
                {
                    Console.WriteLine("\n\tEl valor ingresado no es válido, asegurese de escribirlo correctamente.");
                }
            }
            while (opcionmenu != "salir");
        }
    }
}