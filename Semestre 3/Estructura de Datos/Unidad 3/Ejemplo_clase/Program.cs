using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int elemento = 0, tamanio = 100, top = 0, menu = 0, temp = 0;
            int[] Pila = new int[tamanio]; string otro = "";

            //Menú Principal
            do
            {
                Console.WriteLine("\n\t\t.: MENÚ PRINCIPAL :" +
                                    "\n\t1. Insercción" +
                                    "\n\t2. Eliminación" +
                                    "\n\t3. Mostrar" +
                                    "\n\t4. Salida");
                Console.Write("\n\tEscoge una opción: "); otro = Console.ReadLine();
                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                switch (otro)
                {
                    case "1":
                        {
                            do
                            {
                                Console.Write("\n\t\t.: INSERCCIÓN :." +
                                                            "\n\n\tDe el valor a insertar: "); elemento = int.Parse(Console.ReadLine());
                                top = Insertar(Pila, top, elemento, tamanio);
                                Console.Write("\n\n\t¿Desea otra insercción? [1.Sí|2.No] : "); otro = Console.ReadLine();
                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                while(Console.ReadKey().Key != ConsoleKey.Enter); Console.Clear();
                            }
                            while (otro.Equals("1"));
                        }
                        break;
                    case "2":
                        {
                            do
                            {
                                Console.Write("\n\t\t.: ELIMINACIÓN :." +
                                                "\n\t¿Desea eliminar el último elemento insertado? [1.Sí|2.No]: "); otro = Console.ReadLine();
                                if (otro.Equals("1"))
                                {
                                    top = Eliminar(Pila, top, temp);
                                }
                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            } while (otro.Equals("1"));
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("\n\t\t.: MOSTRAR :." +
                                                                    "\n\t| Se mostrarán los elementos guardados en la pila");
                            for (int i = top - 1; i >= 0; i--)
                            {
                                Console.WriteLine($"\n\t" + Pila[i]);
                            }
                            Console.Write("\n\tPresione la tecla <INTRO> para continuar...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                        }
                        break;
                    case "4":
                        {
                            Console.Write("\n\t\t.: SALIDA :." +
                                                "\n\n\tGracias por utilizar nuestro programa" +
                                                "\n\n\tPresione la tecla <Esc> para salir...");
                            while (Console.ReadKey().Key != ConsoleKey.Escape) ; 
                            menu = 1;
                        }
                        break;
                    default:
                        {
                            Console.Write("\n\t\t.: OPCIÓN INVALIDA :." +
                                                               "\n\n\tPor favor ingrese una opción existente" +
                                                               "\n\n\tPresione la tecla <INTRO> para continuar...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                        }
                        break;
                }
            } while (menu != 1);
        }

        public static int Insertar(int[] pila, int top, int elemento, int tamanio)
        {
            if(FuncionLlena(top, tamanio) == false)
            {
                pila[top] = elemento;
                top++;
                Console.Write($"\n\tSe ha insertado el elemento {elemento} en la pila ");
            }
            else
            {
                Console.WriteLine("\n\tLa pila está llena");
            }
            return top;
        }

        public static bool FuncionLlena(int top, int tamanio)
        {
            if(top == tamanio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------\\
        
        public static int Eliminar(int[] pila, int top, int temp)
        {
            if (FuncionVacia(top) == false)
            {
                top--;
                Console.WriteLine($"\n\tEl valor a eliminar es {pila[top]}");
                temp = pila[top]; pila[top] = 0;
                Console.Write($"\n\tSe ha eliminado el elemento");
            }
            else
            {
                Console.WriteLine("\n\tLa pila está vacía");
            }
            return top;
        }

        public static bool FuncionVacia(int top)
        {
            if(top == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
