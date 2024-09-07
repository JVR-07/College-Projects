using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Programa35_PracticaExcepcion_DivisiónSobreCero
{
    internal class Program
    {
        //método estático
        static float Divide(float divisor, float dividendo)
        {
            if (divisor == 0) //CONDICION ESPECIFICA
                throw new DivideByZeroException(); //lanzamiento de la excepción
            else return dividendo / divisor;
        }
        static void Main(string[] args)
        {
            //declaración de variables auxiliares
            float divisor, dividendo, cociente;
            try
            {
                //Captura de datos
                Console.WriteLine("\n\t\t\t.: |- Captura de Datos -| :.");
                Console.Write("\n\tIngrese el dividendo: "); dividendo = float.Parse(Console.ReadLine());
                Console.Write("\n\tIngrese el divisor: "); divisor = float.Parse(Console.ReadLine());
                Console.WriteLine("\n\tDatos capturados correctamente");
                Console.Write("\n\tPresione la tecla <Enter> para continuar..."); Console.ReadKey();
                Console.Clear();

                //Llamada a método
                cociente = Divide(divisor, dividendo);

                //despliegue del resultado obtenido
                Console.WriteLine("\n\t\t\t.: |- Despliegue de Resultado -| :.");
                Console.WriteLine("\n\tEl cociente es: " + cociente);
                Console.WriteLine("\n\tCálculos terminados exitosamente");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\n\tMensaje del Error: " + e.Message);
                Console.WriteLine("\n\tRuta del Error: " + e.StackTrace);
            }
            catch (FormatException f)
            {
                Console.WriteLine("\n\tMensaje del Error: " + f.Message);
                Console.WriteLine("\n\tRuta del Error: " + f.StackTrace);

            }
            finally
            {
                Console.Write("\n\tPresione la tecla <Enter> para salir...");
                Console.ReadKey();
            }
        }
    }
}