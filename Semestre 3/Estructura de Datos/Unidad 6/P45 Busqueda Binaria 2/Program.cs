﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P45_Busqueda_Binaria_2
{
    internal class Program
    {
        //*********************************************************************************************************************************************************

        //Inicio Método Buscar
        public static bool Buscar(float[] Arreglo, float elemento, ref int position)
        {
            int Mitad, Li = 0, Ls = Arreglo.Length - 1;
            bool Encontrado = false;

            while (Li <= Ls && Encontrado != true)
            {
                Mitad = (Li + Ls) / 2;
                if (Arreglo[Mitad] == elemento) { position = Mitad; Encontrado = true; }
                else if (elemento < Arreglo[Mitad]) Li = Mitad + 1;
                else Ls = Mitad - 1;
            }
            return Encontrado;
        }
        //Fin Método Buscar

        //*********************************************************************************************************************************************************

        //Inicio Método Mostrar
        public static void Mostrar(float[] Arreglo)
        {
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Console.Write("\n\t{0} - {1:c}.", i + 1, Arreglo[i]);
            }
        }
        //Fin Método Mostrar

        //*********************************************************************************************************************************************************

        //Inicio Método Ordenar
        public static void IntercalacionSimpleM1(ref float[] ArregloOriginal)
        {
            //Inicio declaración de variables locales

            int i, j, izquierda, derecha, mitad;
            float auxiliar;

            //Fin declaración de variables locales

            //Inicio bloque de instrucciones

            for (i = 1; i < ArregloOriginal.Length; i++)
            {
                auxiliar = ArregloOriginal[i];
                izquierda = 0;
                derecha = i - 1;

                while (izquierda <= derecha)
                {
                    mitad = (izquierda + derecha) / 2;

                    if (auxiliar >= ArregloOriginal[mitad]) derecha = mitad - 1;
                    else izquierda = mitad + 1;
                }

                j = i - 1;

                while (j >= izquierda)
                {
                    ArregloOriginal[j + 1] = ArregloOriginal[j];
                    j--;
                }
                ArregloOriginal[izquierda] = auxiliar;
            }
        }

        //Fin Método Ordenar

        //*********************************************************************************************************************************************************

        static void Main(string[] args)
        {
            Console.Title = "P45 Búsqueda Binaria 2";

            //*********************************************************************************************************************************************************
            //Declaración de variables
            char opcion_menu;
            float sueldo_empleado;
            float[] SueldosArreglo = new float[20];
            int PositionElement = 0;
            //Fin Declaración de variables

            //*********************************************************************************************************************************************************


            //Despliegue de menú
            do
            {
                Console.Write("\n\t\t.: MENÚ OPCIONES :." +
                                  "\n\n\t[1] - Insertar Sueldos." +
                                  "\n\n\t[2] - Buscar Sueldos." +
                                  "\n\n\t[3] - Mostrar Sueldos." +
                                  "\n\n\t[4] - Salida del Programa." +
                                  "\n\n\tIngrese el número de la opción deseada: ");

                if (char.TryParse(Console.ReadLine(), out opcion_menu))
                {
                    opcion_menu = char.ToUpper(opcion_menu);
                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                    //Control de opciones del menú
                    switch (opcion_menu)
                    {
                        case '1':
                            {
                                //Captura de datos
                                Console.Write("\n\t\t.: INSERTAR SUELDOS :." +
                                              $"\n\n\tA continuación se insertarán los {SueldosArreglo.Length} sueldos en el arreglo: ");

                                for (int i = 0; i < SueldosArreglo.Length; i++)
                                {
                                    Console.Write($"\n\n\t{i + 1}.- Ingrese el sueldo del empleado: ");
                                    SueldosArreglo[i] = float.Parse(Console.ReadLine());
                                    Console.Write("\n\tSe ha ingresado el sueldo {0:c} correctamente", SueldosArreglo[i]);
                                }

                                IntercalacionSimpleM1(ref SueldosArreglo);

                                Console.Write("\n\n\tSe han ingresado los sueldos correctamente" +
                                                                "\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case '2':
                            {
                                //Captura de datos
                                Console.Write("\n\t\t.: BUSCAR SUELDOS :." +
                                              "\n\n\tIngrese el sueldo del empleado a buscar: ");
                                sueldo_empleado = float.Parse(Console.ReadLine());

                                //Procedimiento de búsqueda
                                if (Buscar(SueldosArreglo, sueldo_empleado, ref PositionElement)) Console.WriteLine("\n\n\tEl sueldo {0:c} se encuentra en la posición {1} de la lista", sueldo_empleado, PositionElement + 1);
                                else Console.WriteLine("\n\n\tEl sueldo {0:c} no se encuentra en la lista", sueldo_empleado);

                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case '3':
                            {
                                //Captura de datos
                                Console.Write("\n\t\t.: MOSTRAR SUELDOS :." +
                                              $"\n\n\tA continuación se mostrarán las {SueldosArreglo.Length} sueldos del arreglo: \n");

                                Mostrar(SueldosArreglo);

                                Console.Write("\n\n\tSe han mostrado los sueldos correctamente" +
                                                                "\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                        case '4':
                            {
                                //Caso 4. Salida del programa
                                Console.Write("\n\t\t:. SALIDA :." +
                                                        "\n\n\tGracias por utilizar nuestro programa" +
                                                        "\n\n\tPresione la tecla <Esc> para salir...");
                                while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                            }
                            break;
                        default:
                            {
                                //En caso de ingresar una opción inválida
                                Console.Write("\n\t\t.: OPCIÓN INVALIDA :." +
                                                                   "\n\n\tPor favor ingrese una opción existente" +
                                                                   "\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            }
                            break;
                    }
                }
                else
                {
                    Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                    Console.Write("\n\t\t.: OPCIÓN INVALIDA :." +
                                                                   "\n\n\tPor favor ingrese una opción existente" +
                                                                   "\n\n\tPresione la tecla <INTRO> para continuar...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                }
            } while (opcion_menu != '4');
        }
    }
}
