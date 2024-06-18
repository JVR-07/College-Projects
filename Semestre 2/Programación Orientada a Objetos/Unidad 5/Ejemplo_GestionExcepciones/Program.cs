using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_excepciones
{
    internal class Program
    {
        // Funcion para comprobar que el número ingreaso sea positivo.
        static void comprobar(float num1)
        {
            if (num1 < 0)
            {
                throw new ArgumentException();
            }
        }
        static void Main(string[] args)
        {
            // Bloque de instrucciones a ejecutar
            try
            { // Operación que se desea realizar
                float numero;
                double resultado;
                Console.WriteLine("\n\t\t.: Calculadora de raíz cuadrada :.");
                Console.Write("\n\tIngrese un número al que deseé sacarle raíz: ");
                numero = float.Parse(Console.ReadLine());
                Console.Write("\n\tDato capturado correctamente\n\tPresione la tecla <Enter> para continuar");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("\n\t\t .: RESULTADO :.");
                comprobar(numero);
                resultado = Math.Sqrt(numero); resultado = Math.Round(resultado, 4);
                Console.WriteLine("\n\t\tLa raíz cuadrada de " + numero + " es: " + resultado);
            }
            catch (ArgumentException)
            { // Mensaje en caso de no poder ejercutarse la acción
                Console.WriteLine("\n\t\tOperación inválida. No puede obtener una raíz cuadrada de un número negativo.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            catch (FormatException)
            { // Mensaje en caso de no poder ejercutarse la acción
                Console.WriteLine("\n\t\tOperación inválida. Ingrese un número por favor.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            finally
            {// Mensaje final. Se muestra siempre
                Console.WriteLine("\n\tProceso terminado");
                Console.Write("\tPresione la tecla <Esc> para cerrar el programa...");
                while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
        }
    }
}