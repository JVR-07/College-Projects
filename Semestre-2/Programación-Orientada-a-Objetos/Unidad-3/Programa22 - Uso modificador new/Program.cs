using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa22___Uso_modificador_new
{
    internal class Program
    {
        class Rectangulo
        {   //Declaración de campos
            public float largo, ancho;
            //Constructor de la clase sin parámetros
            public Rectangulo()
            {
            }
            //Declaración de constructor con parámetros
            public Rectangulo(float _largo, float _ancho)
            {
                largo = _largo;
                ancho = _ancho;
            }
            //Métodos de la clase
            public void Area()
            {
                Console.WriteLine("\tEl área resultante es: {0}", largo * ancho);
            }
            public void Perimetro()
            {
                Console.WriteLine("\tEl perimétro resultante es: {0}", 2 * (largo + ancho));
            }
            //Constructor de la clase base
            ~Rectangulo()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto Rectángulo");
            }
        }
        //Creacion de clase derivada
        class Cuadrado : Rectangulo
        {
            new public float largo;
            //Constructor de la clase
            public Cuadrado(float _largo) : base(_largo,0)
            {
                largo = _largo;
            }
            //Métodos de la clase
            new public void Area()
            {
                Console.WriteLine("\tEl área resultante es: {0}", largo * largo);
            }
            new public void Perimetro()
            {
                Console.WriteLine("\tEl perimétro resultante es: {0}", 4 * largo);
            }
            //Destructor de la clase derivada
            ~Cuadrado()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto Cuadrado");
            }
        }
        static void Main(string[] args)
        {   //Declaración de varialbes
            float largo, ancho;
            //Captura de datos
            Console.WriteLine("\n\t*** Datos del Rectángulo ***");
            Console.Write("\n\tIngrese el largo del rectángulo: "); largo = float.Parse(Console.ReadLine());
            Console.Write("\n\tIngrese el ancho del rectángulo: "); ancho = float.Parse(Console.ReadLine());
            Console.Write("\n\tDatos capturados correctamente\n\tPresione la tecla <Enter> para realizar los cálculos...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creacion del objeto de la clase base
            Rectangulo miRectangulo = new Rectangulo(largo, ancho);
            //Llamada a métodos de la clase base
            miRectangulo.Area();
            miRectangulo.Perimetro();
            Console.Write("\n\tProceso terminado\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Captura de dataos
            Console.WriteLine("\n\t*** Datos del Cuadrado ***");
            Console.Write("\n\tingrese el largo del cuadrado: "); largo = float.Parse(Console.ReadLine());
            Console.Write("\n\tDatos capturados correctamente\n\tPresione la tecla <Enter> para realizar los cálculos...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación del objeto de la clase derivada
            Cuadrado miCuadrado = new Cuadrado(largo);
            //Llamada a métodos
            miCuadrado.Area();
            miCuadrado.Perimetro();
            Console.Write("\n\tProceso terminado\n\tPresione la tecla <Esc> para salir del programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}