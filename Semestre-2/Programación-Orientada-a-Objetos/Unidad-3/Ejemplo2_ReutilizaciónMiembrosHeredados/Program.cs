using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_ReutilizaciónMiembrosHeredados
{
    internal class Program
    {   //Declaración de funciones auxiliares para capturar datos
        static string CapturaString(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return Console.ReadLine();
        }
        static float CapturaFloat(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return float.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {   //Declaración de variables
            string color, nombre;
            float carga, nueva_carga;
            Console.WriteLine("\n\t\t*** Tren de carga de sólidos ***\n");
            //Captura de datos
            nombre = CapturaString("el nombre del tren");
            color = CapturaString("el color del tren");
            carga = CapturaFloat("el tamaño de la carga actual en kg");
            //Creación de la instancia para la clase base
            clsTrenCargaSolidos TrenSolidos = new clsTrenCargaSolidos(nombre, color, carga);
            //Llamada a métodos de la instancia base
            nueva_carga = CapturaFloat("el tamaño de la nueva carga en kg");
            TrenSolidos.SubirCarga(nueva_carga);
            TrenSolidos.DesplegarInformacion();
            Console.Write("\tProceso terminado.\n\tPresione la tecla <Enter> para limpiar la pantalla...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Captura de datos
            Console.WriteLine("\n\t\t*** Tren de carga de líquidos ***\n");
            nombre = CapturaString("el nombre del tren");
            color = CapturaString("el color del tren");
            carga = CapturaFloat("el tamaño de la carga actual en L");
            //Creación de la instancia para la clase derivada
            clsTrenCargaLiquidos TrenLiquidos = new clsTrenCargaLiquidos(nombre,color,carga);
            //Llamada a métodos de la instancia derivada
            nueva_carga = CapturaFloat("el tamaño de la nueva carga en kg");
            TrenLiquidos.SubirCarga(nueva_carga);
            TrenLiquidos.DesplegarInformacion();
            Console.Write("\tProceso terminado.\n\tPresione la tecla <Esc> para cerrar el programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}