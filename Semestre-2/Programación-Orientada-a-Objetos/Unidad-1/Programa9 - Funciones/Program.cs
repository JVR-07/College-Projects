using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa9___Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Programa que capture numero de celda, número de trabajadores, número de horas trabajadas a la semana, número de piezas aceptadas y rechazadas por calidad 
               Sacar Total de piezas, porcentaje de error, promedio de piezas por persona y promedio de piezas por hora.
             */
            //Declaración de variables
            Random random = new Random();
            string numeroCelda = "", opcion = "";
            int numeroTrabajadores = 0, horasTrabajadas = 0, piezasAceptadas = 0, piezasRechazadas = 0, porcentajeDeError = 0, piezasPorHora = 0, piezasPorTrabajador = 0, totalDePiezas = 0;
            do
            {
                Console.Write("\t\t***MENÚ***\n\t1 - Cálcular parametros de producción.\n\t2 - Salir\n\tIngrese el número de la operación a realizar: ");
                opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "1":
                        {
                            numeroCelda = Convert.ToString(random.Next(1, 30)); numeroTrabajadores = random.Next(5, 10);
                            horasTrabajadas = random.Next(7, 72); piezasAceptadas = random.Next(400, 2400); piezasRechazadas = random.Next(0, 2400);
                            Console.WriteLine("\n\tIngrese el número de celda: {0}\n\tIngrese el número de trabajadores: {1}\n\tIngrese el número de horas trabajadas a la semana: {2}\n\tIngrese número de piezas aceptadas por calidad: {3}\n\tIngrese número de piezas rechazadas por calidad: {4}\n\t", numeroCelda, numeroTrabajadores, horasTrabajadas, piezasAceptadas, piezasRechazadas);
                            totalDePiezas = TotalDePiezas(piezasAceptadas, piezasRechazadas);
                            porcentajeDeError = PorcentajeDeError(totalDePiezas, piezasRechazadas);
                            piezasPorTrabajador = PromedioDePiezasPorTrabajador(totalDePiezas, numeroTrabajadores);
                            piezasPorHora = PromedioDePiezasPorHora(totalDePiezas, horasTrabajadas);
                            Console.Write("\tLa celda con número {0}, realizó un total de {1} piezas, con {2} aceptadas y {3} rechazadas.\n\tEl porcentaje de error obtenido es de: {4}%\n\tEl número de trabajadores fue de {5} personas, realizando en promedio {6} piezas cada una de ellas.\n\tSe trabajó un total de {7} horas, con un promedio de {8} piezas por hora.\n\tEl cálculo ha finalizado exitosamente.\n\tPresione cualquier tecla para regresar al menú(los datos se borrarán).",numeroCelda,totalDePiezas,piezasAceptadas,piezasRechazadas,porcentajeDeError,numeroTrabajadores,piezasPorTrabajador,horasTrabajadas,piezasPorHora);
                            Console.ReadLine();
                            Console.Clear();
                        } break;
                    case "2":
                        {
                            Console.Write("\tGracias por usar nuestro software, regrese pronto.\n\tPresione la tecla <ESC> para salir...");
                                while(Console.ReadKey().Key != ConsoleKey.Escape);
                        }break;
                    default:
                        Console.Write("\tEl dato introducido no ha sido válido. Asegurese de escribirlo correctamente.\n\tPresione cualquier tecla para regresar al menú.");
                            Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != "2");
        }
        static int TotalDePiezas(int piezasAceptadas, int piezasRechazadas)
        {
            int totalDePiezas;
            totalDePiezas = piezasAceptadas + piezasRechazadas;
            return totalDePiezas;
        }
        static int PorcentajeDeError(int totalDePiezas, int piezasRechazadas)
        {
            int porcentajeDeError = 0;
            porcentajeDeError = (piezasRechazadas * 100) / totalDePiezas;
            return porcentajeDeError;
        }
        static int PromedioDePiezasPorTrabajador(int totalDePiezas,int numeroTrabajadores)
        {
            int piezasPorTrabajador = 0;
            piezasPorTrabajador = totalDePiezas / numeroTrabajadores;
            return piezasPorTrabajador;
        }
        static int PromedioDePiezasPorHora(int totalDePiezas,int horasTrabajadas)
        {
            int piezasPorHora = 0;
            piezasPorHora = totalDePiezas / horasTrabajadas;
            return piezasPorHora;
        }
    }
}
