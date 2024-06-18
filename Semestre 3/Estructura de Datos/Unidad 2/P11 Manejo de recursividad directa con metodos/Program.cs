using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Manejo_de_recursividad_directa_con_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            float[] sueldos = new float[5];
            int c = 0;
            float promedio_sueldos = 0.0f;

            //Captura de datos
            Console.WriteLine("\n\t\t:. CAPTURA DE SUELDOS :.");
            while(c < sueldos.Length)
            {
                Console.Write("\n\tIngrese el sueldo: {0}: ",c + 1);
                sueldos[c] = float.Parse(Console.ReadLine()); c++;
            }
            Console.Write("\n\tDatos capturados correctamente." +
                          "\n\tPresione la tecla <INTRO> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();

            //Procedimiento e impresión de datos
            Console.WriteLine("\n\t\t:. IMPRESIÓN DE RESULTADOS :.");
            calcularPromedioSueldos(sueldos, promedio_sueldos, c = 0);
            Console.Write("\n\tProcesos finalizados. Presione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }

        //Declaración de proceso recursivo
        static public void calcularPromedioSueldos(float[] sueldos, float promedio_sueldos, int c)
        {
            if(c < sueldos.Length)
            {
                promedio_sueldos += sueldos[c]; c++;
                calcularPromedioSueldos(sueldos, promedio_sueldos, c);
            }
            else 
            {
                promedio_sueldos /= sueldos.Length; 
                for(int i = 0; i < sueldos.Length; i++) 
                {
                    Console.WriteLine("\n\tSueldo {0}: {1:c}",i + 1, sueldos[i]);
                }
                Console.WriteLine("\n\tEl promedio general de los sueldos es: {0:c}.",promedio_sueldos);
            }
        }
    }
}