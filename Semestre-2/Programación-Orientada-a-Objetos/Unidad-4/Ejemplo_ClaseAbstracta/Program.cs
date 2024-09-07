using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_ClaseAbstracta
{
    internal class Program
    {
        //Declaración de funciones auxiliares para capturar datos
        static string CapturaString(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return Console.ReadLine();
        }
        static long CapturaLong(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return long.Parse(Console.ReadLine());
        }

        static float CapturaFloat(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return float.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {   //Declaración de variables
            string nombre_cuenta, direccion_cuenta;  
            long numero_telefonico_cuenta;
            
            //Captura de datos
            Console.WriteLine("\n\t\t\t*** Registo de nueva cuenta ***");
            Console.WriteLine("\n\tPor favor ingrese los datos que se le pidan.\n\n");
            nombre_cuenta = CapturaString("su nombre");
            direccion_cuenta = CapturaString("su dirección");
            numero_telefonico_cuenta = CapturaLong("su número de teléfono");
            Console.WriteLine("\t*** Registo completado exitosamente ***");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
           
            //Creación de objeto cuenta regular
            clsCuentaRegular CuentaR = new clsCuentaRegular(nombre_cuenta,direccion_cuenta, numero_telefonico_cuenta, 100f);
            //Llamada a métodos
            Console.WriteLine("\n\t\t\t*** Cuenta regular ***\n");
            CuentaR.AbrirCuenta();
            Console.WriteLine("\n");
            CuentaR.Depositar(1515.76f);
            Console.WriteLine("\n");
            CuentaR.Retirar(267.50f);
            Console.WriteLine("\n");
            Console.WriteLine("\n\tProceso terminado");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            Console.WriteLine("\n\t\t\t*** Información de la cuenta regular ***");
            CuentaR.MostrarInformacion();
            Console.WriteLine("\n\n\tProceso terminado");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Creación de objeto cuenta gold
            clsCuentaGold CuentaG = new clsCuentaGold(nombre_cuenta, direccion_cuenta, numero_telefonico_cuenta, 1820f);
            //Llamada a métodos
            Console.WriteLine("\n\t\t\t*** Cuenta gold ***\n");
            CuentaG.AbrirCuenta();
            Console.WriteLine("\n");
            CuentaG.Depositar(4628.91f);
            Console.WriteLine("\n");
            CuentaG.Retirar(5928.48f);
            Console.WriteLine("\n");
            Console.WriteLine("\n\tProceso terminado");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            Console.WriteLine("\n\t\t\t*** Información de la cuenta gold ***\n");
            CuentaG.MostrarInformacion();
            Console.WriteLine("\n\n\tProceso terminado");
            Console.Write("\tPresione la tecla <Esc> para cerrar el programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}