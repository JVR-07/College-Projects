using System;

namespace P28_Lista_Enlazada_Nombres_Ascendientes
{
    internal class Program
    {
        //---------------------------------------------------------------------------------------------
        //Declaración de la clase Nodo
        public class Node
        {   //Campo para almacenar la edad
            public string name;
            using System;

namespace P28_Lista_Enlazada_Nombres_Ascendientes
    {
        internal class Program
        {
            //---------------------------------------------------------------------------------------------
            //Declaración de la clase Nodo
            public class Node
            {   //Campo para almacenar la edad
                public string name;
                //Campo para almacenar la referencia al siguiente nodo
                public Node next;
            }
            //Fin de la clase Nodo
            //---------------------------------------------------------------------------------------------

            //---------------------------------------------------------------------------------------------
            //Declaración de variables globales
            public static Node startNode, endNode, tempNode, aNode, sNode;
            public static int length_list = 0;
            //Fin variables globales
            //---------------------------------------------------------------------------------------------

            //---------------------------------------------------------------------------------------------
            //Declaración de método para insertar
            public static void AddElement(string element)
            {
                tempNode = new Node();
                tempNode.name = element;

                if (startNode == null)
                {
                    // Si la lista está vacía, crea un nuevo nodo y establece startNode y endNode en él.
                    startNode = tempNode;
                    endNode = tempNode;
                    tempNode.next = null;
                    length_list++;
                }
                else if (element.CompareTo(startNode.name) < 0)
                {
                    // Si el elemento es menor que el primer nodo, colócalo al principio.
                    tempNode.next = startNode;
                    startNode = tempNode;
                    length_list++;
                }
                else
                {
                    Node currentNode = startNode;
                    Node previousNode = null;

                    while (currentNode != null && element.CompareTo(currentNode.name) >= 0)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.next;
                    }

                    if (currentNode == null)
                    {
                        // Si el elemento es mayor que todos los nodos actuales, colócalo al final.
                        endNode.next = tempNode;
                        endNode = tempNode;
                        tempNode.next = null;
                        length_list++;
                    }
                    else
                    {
                        // Inserta el elemento entre previousNode y currentNode.
                        previousNode.next = tempNode;
                        tempNode.next = currentNode;
                        length_list++;
                    }
                }
            }
            //Fin método para insertar
            //---------------------------------------------------------------------------------------------

            //---------------------------------------------------------------------------------------------
            //Declaración de método para eliminar
            public static bool DeleteElement(string element)
            {
                if (startNode == null)
                {
                    // La lista está vacía, no se puede eliminar nada.
                    return false;
                }

                if (element == startNode.name)
                {
                    if (startNode == endNode)
                    {
                        // Si solo hay un elemento en la lista.
                        startNode = null;
                        endNode = null;
                    }
                    else
                    {
                        // Actualiza las referencias cuando se elimina el primer elemento.
                        tempNode = startNode;
                        startNode = startNode.next;
                        endNode.next = startNode;
                        tempNode = null;
                    }

                    Program.length_list--;
                    return true;
                }

                aNode = startNode;
                sNode = startNode.next;

                while (sNode != startNode)
                {
                    if (element == sNode.name)
                    {
                        aNode.next = sNode.next;
                        sNode = null;
                        Program.length_list--;
                        return true;
                    }

                    aNode = sNode;
                    sNode = sNode.next;
                }

                // Si el elemento no se encontró en toda la lista.
                return false;
            }
            //Fin método para eliminar
            //---------------------------------------------------------------------------------------------

            //---------------------------------------------------------------------------------------------
            //Declaración de método imprimir la lista
            public static void PrintElements()
            {
                if (Program.length_list > 0)
                {
                    Console.WriteLine(Program.length_list == 1
                        ? "\n\n\tEste es el nombre de la lista:"
                        : $"\n\n\tEstos son los {Program.length_list} nombres de la lista:");

                    Node currentNode = startNode;
                    Console.Write("\n\t");
                    for (int i = 0; i < Program.length_list; i++)
                    {
                        Console.Write($"[ {currentNode.name} ] ");
                        currentNode = currentNode.next;

                        if (currentNode == startNode)
                        {
                            break; // Detener el bucle cuando volvemos al primer elemento.
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\tLa lista se encuentra vacía.");
                }
            }
            //Fin método para imprimir la  lista
            //---------------------------------------------------------------------------------------------

            //---------------------------------------------------------------------------------------------
            //Inicio Main
            static void Main(string[] args)
            {
                Console.Title = "P28 Lista Enlazada con nombres ordenados por alfabéticamente";
                //Declaración de variables locales
                string name; char opcion_menu; bool answer_bool = false;

                //Despliegue de menú
                do
                {
                    Console.Write("\n\t\t>> MENÚ DE OPCIONES <<" +
                                                "\n\n\t1.- Insertar Elemento." +
                                                    "\n\t2.- Eliminar Elemento." +
                                                    "\n\t3.- Mostrar Elementos." +
                                                    "\n\t4.- Salir del Programa." +
                                                "\n\n\tIngrese el número de la opción deseada: ");
                    //Condición para controlar excepción por formato incorrecto
                    if (char.TryParse(Console.ReadLine(), out opcion_menu))
                    {
                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                        //Switch case para controlar las opciones del menú
                        switch (opcion_menu)
                        {
                            case '1':
                                {
                                    do
                                    {
                                        Console.Write("\n\t\t>> INSERTANDO ELEMENTO <<" +
                                                                    "\n\n\tPor favor, ingrese el nombre que desea insertar: ");
                                        name = Console.ReadLine();
                                        //Llamada a método para insertar
                                        AddElement(name);
                                        Console.Write($"\n\n\tSe ha insertado el nombre {name} en la lista.");
                                        PrintElements(); //Llamada a método para imprimir

                                        do
                                        { //Ciclo do while para controlar las repuestas del usuario
                                            Console.Write("\n\n\t¿Desea insertar otro nombre [S = Sí] [N = No] ?" +
                                                                            "\n\tIngrese la letra de su respuesta: ");
                                            //Llamada a DoAgain para controlar las respuestas
                                            (answer_bool, opcion_menu) = DoAgain(Console.ReadLine(), answer_bool);
                                        } while (answer_bool == false);
                                    } while (opcion_menu != 'N');
                                }
                                break;
                            case '2':
                                {
                                    do
                                    { //Condición para validar que la lista contenga elementos
                                        if (length_list > 0)
                                        {

                                            Console.Write("\n\t\t>> ELIMINANDO ELEMENTO <<");
                                            PrintElements();
                                            Console.Write("\n\n\tIngrese el nombre que desea eliminar: ");
                                            name = Console.ReadLine();
                                            if (DeleteElement(name))
                                            {
                                                Console.Write("\n\t\t>> ELIMINANDO ELEMENTO <<");
                                                Console.Write($"\n\n\n\tSe ha eliminado el nombre {name} correctamente.");
                                            }
                                            else
                                            {
                                                Console.Write("\n\n\t\t>> NO HAY NADA QUE ELIMINAR <<" +
                                                                           $"\n\n\tNo se ha encontrado el nombre {name}.");
                                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                            }
                                            PrintElements();
                                            do
                                            {
                                                Console.Write("\n\n\t¿Desea eliminar otro nombre [S = Sí] [N = No] ?" +
                                                                                "\n\tIngrese la letra de su respuesta: ");
                                                //Llamada a DoAgain para controlar las respuestas
                                                (answer_bool, opcion_menu) = DoAgain(Console.ReadLine(), answer_bool);
                                            } while (answer_bool == false);
                                        }
                                        else
                                        {
                                            Console.Write("\n\t\t>> NO HAY NADA QUE ELIMINAR  <<");
                                            Console.WriteLine("\n\n\tLa lista se encuentra vacía.");
                                            Console.Write("\n\tPresione la tecla <INTRO> para regresar al menú...");
                                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                            opcion_menu = 'N';
                                        }
                                    } while (opcion_menu != 'N');
                                }
                                break;
                            case '3':
                                {
                                    if (length_list > 0)
                                    {

                                        Console.Write("\n\t\t>> MOSTRANDO ELEMENTOS <<");
                                        //Llamada a método para imprimir
                                        PrintElements();
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para regresar al menú...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                    }
                                    else
                                    {
                                        Console.Write("\n\t\t>> NO HAY NADA QUE MOSTRAR  <<");
                                        //Llamada a método para imprimir
                                        PrintElements();
                                        Console.Write("\n\n\tPresione la tecla <INTRO> para regresar al menú...");
                                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                                        opcion_menu = 'N';
                                    }
                                }
                                break;
                            case '4':
                                {
                                    Console.Write("\n\t\t:. SALIDA :." +
                                                                "\n\n\tGracias por utilizar nuestro programa" +
                                                                "\n\n\tPresione la tecla <Esc> para salir...");
                                    while (Console.ReadKey().Key != ConsoleKey.Escape) ;
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
                    }
                    else
                    {
                        Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();

                        Console.Write("\n\t\t>> ALGO HA SALIDO MAL <<" +
                                                    "\n\n\tPor favor ingrese solamente un número." +
                                                    "\n\n\tPresione la tecla <INTRO> para regresar al menú...");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                    }
                } while (opcion_menu != '4');
            }
            //Fin Main

            //---------------------------------------------------------------------------------------------
            //Inicio método para preguntar hacer de nuevo

            /*Definición de método DoAgain(Hacer de nuevo) para hacer todo el procesamiento
             * de las respuestas leídas. 
             * Answer bool es true cuando la respuesta es 'S' o 'N', por lo que se puede salir del 
             * do while donde se hace la pregunta. En caso de ser cualquier otra respuesta se avisa
             * al usuario que la opción no existe y se vuelve a imprimir la pregunta
           */
            public static (bool, char) DoAgain(string read_line, bool answer_bool)
            {
                char opcion_menu;
                if (char.TryParse(read_line, out opcion_menu))
                {
                    opcion_menu = char.ToUpper(opcion_menu);
                    if (opcion_menu == 'S')
                    {
                        Console.Write("\n\tPresione la tecla <INTRO> para continuar...");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                        return (answer_bool = true, opcion_menu);
                    }
                    else if (opcion_menu == 'N')
                    {
                        Console.Write("\n\tPresione la tecla <INTRO> para regresar al menú...");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                        return (answer_bool = true, opcion_menu);
                    }
                    else
                    {
                        Console.Write("\n\n\tPor favor, ingrese una respuesta válida" +
                                                    "\n\tPresione la tecla <INTRO> para intentarlo de nuevo...");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                        return (answer_bool = false, opcion_menu);
                    }
                }
                else
                {
                    Console.Write("\n\n\tPor favor, ingrese una respuesta válida" +
                                                    "\n\tPresione la tecla <INTRO> para intentarlo de nuevo...");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                }
                return (answer_bool = false, opcion_menu);
            }
            //Fin método para preguntar hacer de nuevo
            //---------------------------------------------------------------------------------------------
        }
    }