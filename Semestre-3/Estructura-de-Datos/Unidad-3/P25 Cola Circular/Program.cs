using System;

namespace P25_Cola_Circular
{
    class Program
    {
        static int[] circularCola = new int[5]; // Tamaño máximo de la cola circular
        static readonly int maxSize = 5;//solo de lectura, tiene el tamaño total de la cola
        static int front = -1;//posicionador para insertar
        static int rear = -1;//posicionador para eliminar
        static void Main(string[] args)
        {
            Console.Title = "P25 Cola Circular";
            int Elige;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Salida");
                Console.Write("Selecciona una opción: ");
                //captura y verifica que el valor ingresado sea un número entero
                if (int.TryParse(Console.ReadLine(), out Elige))
                {
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                    switch (Elige)//entrado a cada opción
                    {
                        case 1:
                            Console.Clear();
                            Insertar();//procedimiento insertar
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            break;
                        case 2:
                            Console.Clear();
                            Eliminar();//procedimiento eliminar
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            break;
                        case 3:

                            Console.Clear();
                            Console.WriteLine("Saliendo del programa.");//mensaje de despedida
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                            break;
                        default:
                            Console.Clear();//mensaje cuando no se escoge una opción válida
                            Console.WriteLine("Opción no válida. Introduce [1, 2 o 3]");
                            break;
                    }
                }
                else
                {//cuando no se da un valor numérico entero
                    Console.WriteLine("Por favor, introduce un número válido.");
                }
                Console.Clear();
            } while (Elige != 3);//cerrando el ciclo
        }
        //verificando si ya está llena la cola
        static bool EstaLlena()
        {
            //esta instrucción
            return (rear + 1) % maxSize == front;
        }
        //verificando si la cola está vacía
        static bool EstaVacia()
        {// esta instrucción
            return front == -1;
        }
        static void Insertar()//procedimiento insertar
        {
            int numero;
            MostrarCola();
            //verifica se esta vacia
            Console.Write("Introduce el número a insertar: ");
            numero = int.Parse(Console.ReadLine());
            if (!EstaLlena())//su equivalente if(EstaLlena() != verdadero)
            {
                rear = (rear + 1) % maxSize;//obteniendo posición
                circularCola[rear] = numero;//insertando valor
                if (front == -1)//verificando posicionador
                {
                    front = rear;//poniendolos en la misma posición
                }
                MostrarCola();//llamando al procedimiento
            }
            else
            {//mostrando mensaje de que ya no hay lugar
                Console.WriteLine("La cola está llena. No se pueden insertar más números.");
            }
        }
        static void Eliminar()//procedimiento eliminar
        {
            int numeroEliminado;//variable donde se almacena el valor eliminado
            if (!EstaVacia())// verifica si hay datos para eliminar
            {
                MostrarCola();//imprime la cola
                Console.WriteLine();
                numeroEliminado = circularCola[front];//copia el elemento que se elimina
                circularCola[front] = 0;//elimina el elemento

                if (front == rear)//verifica si ambos posicionadores están en el mismo lugar
                {
                    front = rear = -1;//se pasa al infinito y mas allá
                }
                else
                {
                    front = (front + 1) % maxSize;
                }
                Console.WriteLine("Número eliminado: {0}", numeroEliminado);
                MostrarCola();
            }
            else
            {//aquí muestra el mensaje que no hay ningún elemento
                Console.WriteLine("La cola está vacía. No se pueden eliminar más números.");
            }
        }
        static void MostrarCola()
        {
            Console.WriteLine("Elementos en la cola:");
            int i = front;
            do
            {
                i = (i + 1) % maxSize;
                Console.Write("[{0}]", circularCola[i]);
            } while (i != (rear + 1) % maxSize);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
