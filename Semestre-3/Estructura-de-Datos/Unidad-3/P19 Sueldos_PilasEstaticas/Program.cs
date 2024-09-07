using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_Sueldos_PilasEstaticas
{
    internal class Program
    {   //Variable local para controlar el top de la pila
        public static int top = 0;
        static void Main(string[] args)
        {
            Console.Title = "P19 Sueldos con Pilas Estaticas";
            //Declaración de variables
            //Variables para la pila
            float[] PilaSueldos = new float[100];
            //Variables para captura de datos
            float sueldo, promedio = 0.0f;
            //Variables para control de menú y opciones
            char opcion; bool ejecucion = true;
            
            //Despliegue de menú
            do
            {
                Console.Write("\n\t\t:**: MENÚ DE OPCIONES :**:" +
                              "\n\t| Las opciones disponibles son las siguientes |" +
                              "\n\n\t[1] - Insertar Sueldos." +
                                "\n\t[2] - Mostrar Sueldos." +
                                "\n\t[3] - Eliminar Sueldos." +
                                "\n\t[4] - Salir del Programa." +
                            "\n\n\tIngrese el número de la opción deseada: ");
                opcion = char.Parse(Console.ReadLine());
                Console.Write($"\n\n\tSe ha seleccionado la opción {opcion}" +
                              $"\n\tPresione la tecla <INTRO> para continuar...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                Console.Clear();

                //Control de opciones
                switch(opcion)
                {
                    case '1': 
                        {
                            do
                            {   //Caso 1. Insertar sueldo
                                Console.Write("\n\t\t:**: INSERTAR SUELDOS :**:" +
                                              "\n\n\tIngrese el sueldo a insertar: ");
                                sueldo = float.Parse(Console.ReadLine());
                                //Llamada al método para insertar
                                Insertar(PilaSueldos, sueldo);
                                Console.Write($"\n\n\tSe ha insertado el sueldo ${sueldo}" +
                                              $"\n\n\t¿Desea insertar otro valor [ S | N ]? ");
                                opcion = char.ToUpper(char.Parse(Console.ReadLine()));
                                Console.Write("\n\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            } while (opcion == 'S');
                        }                        
                        break;
                    case '2': 
                        {  //Caso 2. Mostrar sueldos
                            float[] auxPilaSueldos = new float[top];
                            Console.WriteLine("\n\t\t:**: MOSTRAR SUELDOS :**:" +
                                                               "\n\t| Estos son los datos guardados en la pila |");
                            for (int i = top - 1; i >= 0; i--)
                            {
                                Console.WriteLine("\n\t{0:c}", PilaSueldos[i]);
                                promedio += PilaSueldos[i];
                                auxPilaSueldos[i] = PilaSueldos[i];
                            }
                            Console.WriteLine($"\n\tEl número mayor es: ${PilaSueldos.Max()}" +
                                                               $"\n\tEl número menor es: ${auxPilaSueldos.Min()}" +
                                                               $"\n\tEl promedio de los sueldos es: ${promedio / top}");
                            Console.Write("\n\tPresione la tecla <INTRO> para continuar...");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            promedio = 0.0f;
                        }
                        break;
                    case '3': 
                        {       //Caso 3. Eliminar sueldo
                            do
                            {
                                Console.Write("\n\t\t:**: ELIMINAR SUELOS :**:" +
                                                            "\n\n\t¿Desea eliminar el último sueldo insertado [ S | N ]? ");
                                opcion = char.ToUpper(char.Parse(Console.ReadLine()));
                                if (opcion.Equals('S')) Eliminar(PilaSueldos, opcion); //Llamada a método para eliminar
                                Console.Write("\n\tPresione la tecla <INTRO> para continuar...");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                            } while (opcion == 'S');
                        }
                        break;
                    case '4': 
                        {  //Caso 4. Salida del programa
                            Console.Write("\n\t\t:**: SALIDA :**:" +
                                                    "\n\n\tGracias por utilizar nuestro programa" +
                                                    "\n\n\tPresione la tecla <Esc> para salir...");
                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                            ejecucion = false;
                        }
                        break;
                    default: 
                        {  //En caso de ingresar una opción inválida
                            Console.Write("\n\t\t.: SALIDA :." +
                                                    "\n\n\tGracias por utilizar nuestro programa" +
                                                    "\n\n\tPresione la tecla <Esc> para salir...");
                            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
                        }
                        break;
                }
            } while (ejecucion);
        }

        //Definición de procedimiento para insertar
        public static void Insertar(float[] Pilasueldo, float sueldo)
        {
            if(VerificarLLena(Pilasueldo.Length) == false)
            {
                Pilasueldo[Program.top] = sueldo;
                Program.top++;
            }
        }

        //Definicion de función para comprobar si está llena la pila
        public static bool VerificarLLena(int tamanio)
        {
            if (Program.top == tamanio - 1) return true;
            else return false;
        }
        //***************************************************************************************************\\

        //Definición de método para eliminar
        public static void Eliminar(float[] Pilasueldo, char opcion)
        {
            if (VerificarVacia() == false)
            {
                Program.top--;
                Console.WriteLine("\n\tSe ha eliminado el sueldo {0:c}", Pilasueldo[Program.top]);
                Pilasueldo[Program.top] = 0.0f;
            }
            else Console.WriteLine("\n\tLa pila está vacía." +
                                                        "\n\tIngrese \"N\" para regresar al menú");
        }

        //Definición de función para comprobar si está vacía la pila
        public static bool VerificarVacia()
        {
            if (Program.top <= 0) return true;
            else return false;
        }
    }
}
