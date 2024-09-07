using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa31_Interfaz_Perímetros
{
    internal class Program
    {
        interface Perimetros //Declaración interface
        {
            //Métodos de la interfaz
            float CalcularPerimetro();
            void DesplegarPerimetro(float resultado);
        }

        class Rombo : Perimetros //Declaración de clase derivada Rombo
        {
            //Campos de la clase
            float lado_rombo;
            //Constructor de la clase
            public Rombo(float lado)
            {
                this.lado_rombo = lado;
            }
            //Métodos de la clase derivada
            public float CalcularPerimetro()
            {
                return 4 * this.lado_rombo;
            }
            public void DesplegarPerimetro(float resultado)
            {
                Console.WriteLine("\tEl valor del lado es: {0}" +
                                  "\n\tEl resultado es: {1:f4}", this.lado_rombo, resultado);
            }
            //Destructor de la clase
            ~Rombo()
            {
                Console.WriteLine("\n\tMemoria Liberada del objeto Rombo");
            }
        }

        class Romboide : Perimetros //Declaración de clase derivada Romboide
        {
            //Campos de la clase
            float base_romboide, altura_romboide;
            //Constructor de la clase
            public Romboide(float base_romboide, float altura_romboide)
            {
                this.base_romboide = base_romboide;
                this.altura_romboide = altura_romboide;
            }
            //Métodos de la clase derivada
            public float CalcularPerimetro()
            {
                return (2 * this.base_romboide) + (2 * this.altura_romboide);
            }
            public void DesplegarPerimetro(float resultado)
            {
                Console.WriteLine("\tEl valor de la base es: {0}" +
                                  "\n\tEl valor de la altura es: {1}" +
                                  "\n\tEl resultado es: {2:f4}", this.base_romboide, this.altura_romboide, resultado);
            }
            //Destructor de la clase
            ~Romboide()
            {
                Console.WriteLine("\n\tMemoria Liberada del objeto Romboide");
            }
        }

        class PoligonoRegular : Perimetros //Declaración de clase derivada PoligonoRegular
        {
            //Campos de la clase
            float lado_poligono;
            short numero_lados_poligono;
            //Constructor de la clase
            public PoligonoRegular(float lado_poligono, short numero_lados_poligono)
            {
                this.lado_poligono = lado_poligono;
                this.numero_lados_poligono = numero_lados_poligono;
            }
            //Métodos de la clase derivada
            public float CalcularPerimetro()
            {
                return this.lado_poligono * this.numero_lados_poligono;
            }
            public void DesplegarPerimetro(float resultado)
            {
                Console.WriteLine("\tEl valor del lado es: {0}" +
                                  "\n\tEl número de lados es: {1}" +
                                  "\n\tEl resultado es: {2:f4}", this.lado_poligono, this.numero_lados_poligono, resultado);
            }
            //Destructor de la clase
            ~PoligonoRegular()
            {
                Console.WriteLine("\n\tMemoria Liberada del objeto PoligonoRegular");
            }
        }
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
                            Console.Write("\n\tPresione la tecla <Enter> para regresar al menú...");
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
