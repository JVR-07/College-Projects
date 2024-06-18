using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_Manejo_Recursividad_Indirecta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            float[] sueldo = new float[100]; float suma = 0.0f; int c = 0, op = 1;
            CapturaSueldos(sueldo, suma, c, op);
        }

        //Declaración de primer método recursivo
        static public void CapturaSueldos(float[] sueldo, float suma, int c, int op)
        {
            if(op == 1)
            {
                Console.Write("\n\t\t.: CAPTURANDO DATOS :." +
                              "\n\n\tIngrese un sueldo: "); sueldo[c] = float.Parse(Console.ReadLine());
                ProcedimientosSueldos(sueldo, suma, c, op);
            }
            else
            {
                Console.Write("\n\tCaptura terminada exitosamente" +
                              "\n\tPresione la tecla <INTRO> para continuar...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ; Console.Clear();
                Console.Write("\n\t\t.: IMPRIMIENDO DATOS :." +
                              "\n\n\t| Los sueldos ingresados son los siguientes |");
                for(int i = 0; i < c; i++)
                {
                    Console.WriteLine("\n\tSueldo {0}.- {1:c}", i + 1, sueldo[i]);
                }
                Console.Write("\tLa suma de lo sueldos es de: {0:c}" +
                              "\n\n\tDatos procesados correctamente, presione <Esc> para salir...",suma);
                while (Console.ReadKey().Key != ConsoleKey.Escape) ;
            }
        }

        //Declaración de segundo método recursivo
        static public void ProcedimientosSueldos(float[] sueldo, float suma, int c, int op)
        {
            suma += sueldo[c]; c++;
            Console.Write("\n\t¿Desea ingresar otro sueldo? 1.Sí | 2.No | : "); op = int.Parse(Console.ReadLine());
            CapturaSueldos(sueldo, suma, c, op);
        }
    }
}
