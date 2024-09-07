using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Metodos
{
    // Machado Sanchez Javier. 22211600
    internal class Program
    {
        // Declaración de la clase
        class Planta
        {
            // Campos de la clase
            private string nombrePlanta;
            private string colorPlanta;
            private int alturaPlanta;
            private int alturaMaximaPlanta;
            private short añosVidaPlanta;
            private short añosVidaMaximosPlanta;
            private int crecimientoAnualPlanta;
            private bool plantaMuerta;
            private bool plantaCortada;

            // Declaración de constructor
            public Planta(string nombrePlanta, string colorPlanta, int alturaPlanta, int alturaMaximaPlanta, short añosVidaPlanta, short añosVidaMaximosPlanta, int crecimientoAnualPlanta, bool plantaMuerta, bool plantaCortada)
            {
                this.nombrePlanta = nombrePlanta;
                this.colorPlanta = colorPlanta;
                this.alturaPlanta = alturaPlanta;
                this.alturaMaximaPlanta = alturaMaximaPlanta;
                this.añosVidaPlanta = añosVidaPlanta;
                this.añosVidaMaximosPlanta = añosVidaMaximosPlanta;
                this.crecimientoAnualPlanta = crecimientoAnualPlanta;
                this.plantaMuerta = plantaMuerta;
                this.plantaCortada = plantaCortada;
            }

            // Creacion de los métodos de la clase
            // Método para simular el paso del tiempo
            public void adelantarTiempoPlanta(short añosTranscurridos)
            {
                // Verificacion del estado de la planta
                if (this.plantaCortada == false && this.plantaMuerta == false)
                {
                    // Declaración de variables auxiliares para evitar modificar los campos del objeto accidentalmente 
                    int crecimientoAnualPlanta = this.crecimientoAnualPlanta, alturaPlanta = this.alturaPlanta;
                    short añosVidaPlanta = this.añosVidaPlanta;
                    // Proceso donde se calcula el crecimiento de la planta en los años ingresados
                    crecimientoAnualPlanta *= añosTranscurridos;
                    alturaPlanta += crecimientoAnualPlanta;
                    if (alturaPlanta > this.alturaMaximaPlanta)
                    {
                        int tempalturaPlanta = 0;
                        tempalturaPlanta = alturaPlanta;
                        alturaPlanta = this.alturaMaximaPlanta;
                        tempalturaPlanta -= this.alturaMaximaPlanta;
                        crecimientoAnualPlanta -= tempalturaPlanta;
                    }
                    // Proceso donde se calcula los años de vida de la planta en los años ingresados
                    añosVidaPlanta += añosTranscurridos;
                    if (añosVidaPlanta > this.añosVidaMaximosPlanta)
                    {
                        añosVidaPlanta = this.añosVidaMaximosPlanta;
                        this.plantaMuerta = true;
                        Console.Write("\tLa planta ha sobrepasado su ciclo de vida, por lo tanto ha muerto.");
                    }
                    // Mensaje para mostrar los resultados
                    Console.WriteLine("\n\tLa planta ha crecido {0} centímetros en {1} años.", crecimientoAnualPlanta, añosTranscurridos);
                    // Asignación de nuevos valores a los campos del objeto
                    this.alturaPlanta = alturaPlanta;
                    this.añosVidaPlanta = añosVidaPlanta;
                }
                // Mensaje para avisar que la planta está muerta
                else
                {
                    Console.WriteLine("\tLa planta está muerta o ha sido cortada, por lo tanto la simulación a terminado.\n\tReinicie el programa para realizar otra simulación.");
                }
            }
            // Método para simular el corte de la planta
            public void cortarPlanta()
            {   // Comprobaciónd el estado de la planta
                if (this.plantaMuerta == false && this.plantaCortada == false)
                {   // Declaración de variable auxiliar
                    string respuesta = "";
                    do
                    {   // Pregunta para asegurar que el usuario esté tomando la opción deseada
                        Console.Write("\n\t¿Está seguro de querer cortar la planta(ésta morirá)? sí | no: "); respuesta = Console.ReadLine();
                        // Switch case para controlar las opciones
                        switch (respuesta.ToLower())
                        {   // Respuesta positiva
                            case "sí":
                                {
                                    this.plantaMuerta = true;
                                    this.plantaCortada = true;
                                    Console.WriteLine("\tLa planta ha sido cortada y por lo tanto murió.");
                                    respuesta = "fin";
                                }
                                break;
                            // Respuesta positiva auxiliar
                            case "si":
                                {
                                    this.plantaMuerta = true;
                                    this.plantaCortada = true;
                                    Console.WriteLine("\tLa planta ha sido cortada y por lo tanto murió.");
                                    respuesta = "fin";
                                }
                                break;
                            // Respuesta negativa
                            case "no":
                                {
                                    this.plantaMuerta = false;
                                    this.plantaCortada = false;
                                    Console.WriteLine("\tLa planta no se cortará y permanecerá con vida.");
                                    respuesta = "fin";
                                }
                                break;
                            // Control de respuestas incorrectas
                            default:
                                {
                                    Console.WriteLine("\tLa opción ingresada no es válida. Asegurese de escribirla correctamente(minúsculas).\n\tPresione una tecla para regresar...");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                        }
                    }
                    while (respuesta != "fin");
                }
                else if (this.plantaMuerta == true && this.plantaCortada == false)
                {
                    Console.WriteLine("\tLa planta ya está muerta, por lo tanto será cortada");
                    plantaCortada = true;
                }
                else if (this.plantaMuerta == true && this.plantaCortada == true)
                {
                    Console.WriteLine("\tLa planta ya está muerta y ya ha sido cortada");
                }
            }
            // Método para mostrar la información de la planta 
            public void desplegarInformacionPlanta()
            {
                // Declaración de variables auxiliares
                string _plantaMuerta = "", _plantaCortada = "";
                // Bucles para comprobrar el estado de la planta y mostrar los valores correspondientes
                if (this.plantaMuerta == true)
                {
                    _plantaMuerta = "muerta";
                }
                else
                {
                    _plantaMuerta = "viva";
                }
                if (this.plantaCortada == true)
                {
                    _plantaCortada = "cortada";
                }
                else
                {
                    _plantaCortada = "plantada";
                }
                //Despliegue de información
                Console.Write("\t\t*** Información ***\n\n\tNombre de la planta: {0}.\n\tColor de la planta: {1}.\n\tAltura de la planta: {2} cm.\n\tAltura Máxima de la planta: {3} cm.\n\tcrecimiento anual de la planta: {4} cm.\n\tAños de vida de la planta: {5}.\n\tAños de vida máximos de la planta: {6}.\n\tLa planta está: {7}.\n\tLa planta está: {8}.", this.nombrePlanta, this.colorPlanta, this.alturaPlanta, this.alturaMaximaPlanta, this.crecimientoAnualPlanta, this.añosVidaPlanta, this.añosVidaMaximosPlanta, _plantaMuerta, _plantaCortada);
            }
            //Método para desplegar el menú de opciones
            public string desplegarMenu()
            {   // Declaración de variable auxiliar
                string opcion = "";
                Console.Write("\n\n\t\t*** Menú ***\n\n\t1 - Acelerar tiempo.\n\t2 - Cortar planta.\n\t3 - Salir.\n\n\tSeleccione el número de la opción que desea realizar: ");
                opcion = Console.ReadLine();
                // Retorno del valor
                return opcion;
            }
            // Destructor de la clase
            ~Planta()
            {
                Console.WriteLine("\n\tLa memoria de la clase planta ha sido liberada de la memoria RAM\n\tBismuth Company®. Derechos reservados.");
            }
        }
        static void Main(string[] args)
        {
            // Declaración de variables
            string opcion = "";
            short añosTranscurridos = 0;
            //Declaración de objeto y sus parámetros
            Planta Ficus = new Planta("Ficus Lyrata", "Verde", 0, 800, 0, 15, 60, false, false);
            // Mensaje de incio para dar contexto del programa
            Console.Write("\t\t*** Bienvenido al simulador de plantas. ***\n\n\tPresione la tecla <ENTER> para comenzar la simulación.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            do
            {
                try
                {
                    //Llamda al método para mostrar la información de la planta
                    Ficus.desplegarInformacionPlanta();
                    //Llamda al método para seleccionar la opción y asignación del valor retornado a la variable correspondiente
                    opcion = Ficus.desplegarMenu();
                    Console.Clear();
                    //Switch case para controlar las opciones
                    switch (opcion.ToLower())
                    {
                        case "1": // Proceso para adelantar el tiempo
                            {
                                Console.Write("\tIngrese los años que desea adelantar: ");
                                añosTranscurridos = short.Parse(Console.ReadLine());
                                // Llamada al método para realizar los calculos y mostrarlos en consola
                                Ficus.adelantarTiempoPlanta(añosTranscurridos);
                                // Mensaje final
                                Console.Write("\tEl proceso ha finalizado.");
                            }
                            break;
                        case "uno": // Caso 1 auxiliar
                            {
                                Console.Write("\tIngrese los años que desea adelantar: ");
                                añosTranscurridos = short.Parse(Console.ReadLine());
                                // Llamada al método para realizar los calculos y mostrarlos en consola
                                Ficus.adelantarTiempoPlanta(añosTranscurridos);
                                // Mensaje final
                                Console.Write("\tEl proceso ha finalizado.");
                            }
                            break;
                        case "2": // Proceso para cortar la planta
                            {
                                // Llamda al método para realizar la operación
                                Ficus.cortarPlanta();
                                // Mensaje final
                                Console.Write("\tEl proceso ha finalizado.");
                            }
                            break;
                        case "dos": // Caso 2 auxiliar
                            {
                                Ficus.cortarPlanta();
                                // Mensaje final
                                Console.Write("\tEl proceso ha finalizado.");
                            }
                            break;
                        case "3": // Opcion para salir del programa
                            {
                            }
                            break;
                        case "tres": // Caso 3 auxiliar
                            {
                                opcion = "3";
                            }
                            break;
                        case "salir": // Caso 3 auxiliar
                            {   
                                opcion = "3";
                            }
                            break;
                        default: // Control de respuestas incorrectas
                            {   // Mensaje de aviso
                                Console.Write("\tNo se ha encontrado el dato ingresado, asegúrese de escribirlo correctamente");
                            }
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\n\tError: {0}" +
                                      "\n\n\tRuta del error: {1}",e.Message,e.StackTrace);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("\n\tError: {0}" +
                                      "\n\n\tRuta del error: {1}", e.Message, e.StackTrace);
                }
                finally
                {
                    if(opcion == "3")
                    {
                        Console.Write("\n\tGracias por utilizar nuestro software de simulacón, deseamos verlo de nuevo pronto." +
                                      "\n\tPresione la tecla <Esc> para salir del programa." +
                                      "\n\tBismuth Company®. Derechos reservados.");
                    }
                    else
                    {
                        Console.Write("\n\tPresione cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            } // Condición para finalizar el programa
            while (opcion != "3");
        }
    }
}       // Machado Sanchez Javier. 22211600