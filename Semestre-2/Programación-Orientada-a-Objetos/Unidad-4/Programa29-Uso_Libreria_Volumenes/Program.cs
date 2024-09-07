using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Biblioteca propia
using lbrVolumenes;

namespace Programa29_Uso_Libreria_Volumenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables auxiliares
            float radio, altura, lado;
            double result;

            //Captura de datos esfera
            Console.WriteLine("\n\t*** Esfera ***");
            Console.WriteLine("\nPara continuar ingrese los siguientes datos...\n\n");
            Console.Write("Radio: "); radio = float.Parse(Console.ReadLine());
            Console.WriteLine("Datos capturados correctamente.");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Creación de objeto esfera y llamada a métodos
            clsEsfera MiEsfera = new clsEsfera(radio);
            Console.WriteLine("\n\t*** Esfera ***");
            result = MiEsfera.calcularVolumen();
            MiEsfera.desplegarVolumen(result);
            Console.WriteLine("\nDatos mostrados correctamente.");
            Console.Write("\nPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Captura de datos Cubo
            Console.WriteLine("\n\t*** Cubo ***");
            Console.WriteLine("\nPara continuar ingrese los siguientes datos...\n\n");
            Console.Write("Lado: "); lado = float.Parse(Console.ReadLine());
            Console.WriteLine("Datos capturados correctamente.");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Creación de objeto cubo y llamada a métodos
            clsCubo MiCubo = new clsCubo(lado);
            Console.WriteLine("\n\t*** Cubo ***");
            result = MiCubo.calcularVolumen();
            MiCubo.desplegarVolumen(result);
            Console.WriteLine("Datos mostrados correctamente.");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Captura de datos Cilindro
            Console.WriteLine("\n\t*** Cilindro ***");
            Console.WriteLine("\nPara continuar ingrese los siguientes datos...\n\n");
            Console.Write("Radio: "); radio = float.Parse(Console.ReadLine());
            Console.Write("Altura: "); altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Datos capturados correctamente.");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Creación de objeto Cilindro y llamada a métodos
            clsCilindro MiCilindro = new clsCilindro(radio, altura);
            Console.WriteLine("\n\t*** Cilindro ***");
            result = MiCilindro.calcularVolumen();
            MiCilindro.desplegarVolumen(result);
            Console.WriteLine("Datos mostrados correctamente.");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Captura de datos Cono
            Console.WriteLine("\n\t*** Cono ***");
            Console.WriteLine("\nPara continuar ingrese los siguientes datos...\n\n");
            Console.Write("Radio: "); radio = float.Parse(Console.ReadLine());
            Console.Write("Altura: "); altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Datos capturados correctamente.");
            Console.Write("Presione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Creación de objeto Cono y llamada a métodos
            clsCono MiCono = new clsCono(radio, altura);
            Console.WriteLine("\n\t*** Cono ***");
            result = MiCono.calcularVolumen();
            MiCono.desplegarVolumen(result);
            Console.WriteLine("Datos mostrados correctamente.");
            Console.Write("Presione la tecla <Esc> para salir del programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}