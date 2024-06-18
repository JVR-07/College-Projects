using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa19___Sobrecarga_de_Operadores
{
    internal class Program
    { 
        //Declaración de la clase
        class NumerosComplejos
        {
            //Campos de la clase
            float numero_real, numero_imaginario;
            //Constructor de la clase
            public NumerosComplejos(float numero_real, float numero_imaginario)
            {
                this.numero_real = numero_real;
                this.numero_imaginario = numero_imaginario;
            }
            //Métodos de la clase
            //Sobrecargada de operador unario ++(incremento)
            public static NumerosComplejos operator ++(NumerosComplejos c1)
            {
                return new NumerosComplejos(c1.numero_real + 1, c1.numero_imaginario + 1);
            }
            //Sobrecargada de operador unario --(decremento)
            public static NumerosComplejos operator --(NumerosComplejos c1)
            {
                return new NumerosComplejos(c1.numero_real - 1, c1.numero_imaginario - 1);
            }
            //Sobrecarga de operador binario +(suma)
            public static NumerosComplejos operator +(NumerosComplejos c1, NumerosComplejos c2)
            {
                return new NumerosComplejos(c1.numero_real + c2.numero_real, c1.numero_imaginario +
                c2.numero_imaginario);
            }
            //Sobrecarga de operador binario -(resta)
            public static NumerosComplejos operator -(NumerosComplejos c1, NumerosComplejos c2)
            {
                return new NumerosComplejos(c1.numero_real - c2.numero_real, c1.numero_imaginario -
                c2.numero_imaginario);
            }
            //Sobrecarga de operador binario *(multiplicación)
            public static NumerosComplejos operator *(NumerosComplejos c1, NumerosComplejos c2)
            {
                return new NumerosComplejos(c1.numero_real * c2.numero_real, c1.numero_imaginario *
                c2.numero_imaginario);
            }
            //Sobrecarga de operador binario /(división)
            public static NumerosComplejos operator /(NumerosComplejos c1, NumerosComplejos c2)
            {
                return new NumerosComplejos(c1.numero_real / c2.numero_real, c1.numero_imaginario /
                c2.numero_imaginario);
            }
            // mostrar resultado de forma personalizada en pantalla
            public override string ToString()
            {
                return (String.Format("{0} + {1}i", numero_real, numero_imaginario));
            }
            //Destructor de la clase
            ~NumerosComplejos()
            {
                Console.WriteLine("\tLa memoria de la clase Numeros Complejos ha sido liberada");
            }
        }
        static void Main(string[] args)
        {
            float numero_real1 = 0f,numero_imaginario1 = 0f, numero_real2 = 0f, numero_imaginario2 = 0f;
            //Captura de datos para operaciones unarias
            Console.Write("\tIngrese el valor real para el número complejo: ");
            numero_real1 = float.Parse(Console.ReadLine());

            Console.Write("\tIngrese el valor imaginario para el número complejo: ");
            numero_imaginario1 = float.Parse(Console.ReadLine());
            //Creación del objeto
            NumerosComplejos C1 = new NumerosComplejos(numero_real1, numero_imaginario1);
            NumerosComplejos C2 = new NumerosComplejos(numero_real1, numero_imaginario1);
            Console.Write("\tEl número ingresado es: {0}\n\tPresione la tecla <Enter> para realizar las operaciones...",C1);
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Utilización de operadores sobrecargados
            C1++;
            C2--;
            Console.WriteLine("\tEl valor del incremento es: {0}\n\tEl valor del decremento es: {1}", C1, C2);
            Console.Write("\tOperaciones de unarios terminadas,\n\tpresione <Enter> para pasar a la siguiente sección...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Captura de datos para operaciones binarias
            Console.Write("\tIngrese el valor real para el primer número complejo: ");
            numero_real1 = float.Parse(Console.ReadLine());

            Console.Write("\tIngrese el valor imaginario para el primer número complejo: ");
            numero_imaginario1 = float.Parse(Console.ReadLine());

            Console.Write("\tIngrese el valor real para el segundo número complejo: ");
            numero_real2 = float.Parse(Console.ReadLine());

            Console.Write("\tIngrese el valor imaginario para el segundo número complejo: ");
            //Creación de objetos
            numero_imaginario2 = float.Parse(Console.ReadLine());
            NumerosComplejos C3 = new NumerosComplejos(numero_real1, numero_imaginario1);
            NumerosComplejos C4 = new NumerosComplejos(numero_real2, numero_imaginario2);
            Console.WriteLine("\tEl primer número complejo es: {0}\tEl segundo número complejo es: {1}", C3, C4);
            Console.Write("\tPresione la tecla <Enter> para realizar las operaciones...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Utilización de operadores sobrecargados
            NumerosComplejos Csuma = C3 + C4;
            NumerosComplejos Cresta = C3 - C4;
            NumerosComplejos Cmultiplica = C3 * C4;
            NumerosComplejos Cdivide = C3 / C4;
            //Despliegue de resultaados
            Console.WriteLine("\n\t({0}) + ({1}) = ({2})", C3, C4, Csuma);
            Console.WriteLine("\n\t({0}) - ({1}) = ({2})", C3, C4, Cresta);
            Console.WriteLine("\n\t({0}) * ({1}) = ({2})", C3, C4, Cmultiplica);
            Console.WriteLine("\n\t({0}) / ({1}) = ({2})", C3, C4, Cdivide);
            //Mensaje final
            Console.Write("\tOperaciones terminadas, presione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}