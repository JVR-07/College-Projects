using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declaración de libreria propia
using Perimetros;
/*
 La libreria se encuentra dentro de la carpeta
 del proyecto, en la raíz.
 */

namespace Programa32_Uso_Biblioteca_Perimetros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Declaración de variables auxiliares
            char opcion;
            float lado, _base, altura;
            short numero_lados;
            bool ejecucion = true; ;

            //Do while para controlar el menu
            do
            {
                //Despliegue de menú
                Console.WriteLine("\n\t\t\t*** Menú Perímetros***");
                Console.WriteLine("\n\ta) - Rombo");
                Console.WriteLine("\n\tb) - Romboide");
                Console.WriteLine("\n\tc) - Polígono Regular");
                Console.WriteLine("\n\td) - Salir del programa");
                Console.Write("\n\tIngrese la letra de la opción deseada: ");
                opcion = char.Parse(Console.ReadLine());
                opcion = char.ToLower(opcion);
                Console.Write("\n\tDato capturado correctamente" +
                              "\n\tPresione la tecla <Enter> para continuar...");
                Console.ReadKey();
                Console.Clear();
                //Switch case para controlar las opciones del menú
                switch (opcion)
                {
                    case 'a':
                        {
                            //Captura de datos
                            Console.WriteLine("\n\t\t\t*** Rombo***");
                            Console.WriteLine("\n\t\tIngrese los datos que se le pidan");
                            Console.Write("\n\tIngrese el valor del lado: ");
                            lado = float.Parse(Console.ReadLine());
                            Console.Write("\n\tDatos capturados correctamente" +
                                              "\n\tPresione la tecla <Enter> para continuar...");
                            Console.ReadKey(); Console.Clear();
                            //Creación del objeto
                            Rombo MiRombo = new Rombo(lado);
                            //LLamada a métodos
                            Console.WriteLine("\n\t\t\t*** Rombo***\n\n");
                            MiRombo.DesplegarPerimetro(MiRombo.CalcularPerimetro());
                            Console.Write("\n\n\tCálculo finalizado." +
                                              "\n\tPresione la tecla <Esc> para salir" +
                                              "\n\tPresione la tecla <Enter> para regresar al menú...");
                            if (Console.ReadKey().Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                lado = 0.0f;
                            }
                            else
                            {
                                ejecucion = false;
                            }
                        }
                        break;
                    case 'b':
                        {
                            //Captura de datos
                            Console.WriteLine("\n\t\t\t*** Romboide***");
                            Console.WriteLine("\n\t\tIngrese los datos que se le pidan");
                            Console.Write("\n\tIngrese el valor de la base: ");
                            _base = float.Parse(Console.ReadLine());
                            Console.Write("\n\tIngrese el valor de la altura: ");
                            altura = float.Parse(Console.ReadLine());
                            Console.Write("\n\tDatos capturados correctamente" +
                                              "\n\tPresione la tecla <Enter> para continuar...");
                            Console.ReadKey(); Console.Clear();
                            //Creación del objeto
                            Romboide MiRomboide = new Romboide(_base, altura);
                            //LLamada a métodos
                            Console.WriteLine("\n\t\t\t*** Romboide***\n\n");
                            MiRomboide.DesplegarPerimetro(MiRomboide.CalcularPerimetro());
                            Console.Write("\n\n\tCálculo finalizado." +
                                              "\n\tPresione la tecla <Esc> para salir" +
                                              "\n\tPresione la tecla <Enter> para regresar al menú...");
                            if (Console.ReadKey().Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                _base = 0.0f;
                                altura = 0.0f;
                            }
                            else
                            {
                                ejecucion = false;
                            }
                        }
                        break;
                    case 'c':
                        {
                            //Captura de datos
                            Console.WriteLine("\n\t\t\t*** Polígono Regular***");
                            Console.WriteLine("\n\t\tIngrese los datos que se le pidan");
                            Console.Write("\n\tIngrese el valor del lado: ");
                            lado = float.Parse(Console.ReadLine());
                            Console.Write("\n\tIngrese el número de lados: ");
                            numero_lados = short.Parse(Console.ReadLine());
                            Console.Write("\n\tDatos capturados correctamente" +
                                              "\n\tPresione la tecla <Enter> para continuar...");
                            Console.ReadKey(); Console.Clear();
                            //Creación del objeto
                            PoligonoRegular MiPoligonoRegular = new PoligonoRegular(lado, numero_lados);
                            //LLamada a métodos
                            Console.WriteLine("\n\t\t\t*** Polígono Regular***\n\n");
                            MiPoligonoRegular.DesplegarPerimetro(MiPoligonoRegular.CalcularPerimetro());
                            Console.Write("\n\n\tCálculo finalizado." +
                                              "\n\tPresione la tecla <Esc> para salir" +
                                              "\n\tPresione la tecla <Enter> para regresar al menú...");
                            if (Console.ReadKey().Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                lado = 0.0f;
                                numero_lados = 0;
                            }
                            else
                            {
                                ejecucion = false;
                            }
                        }
                        break;
                    case 'd': { ejecucion = false; } break;
                    default:
                        {
                            Console.WriteLine("\tEl dato ingresado no es válido" +
                                              "\n\tAsegúrese de escribirlo correctamente");
                        }
                        break;
                }
            }
            while (ejecucion);
            Console.Clear();
            Console.Write("\n\tEl programa ha finalizadon" +
                              "\n\tPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
