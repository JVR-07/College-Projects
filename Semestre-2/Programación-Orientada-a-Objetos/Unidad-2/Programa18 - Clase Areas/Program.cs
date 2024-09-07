using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa18___Clase_Areas
{
    internal class Program
    {   //Declaración de la clase
        class Area
        {   //Declaración de campos
            string nombre_figura;
            //Declaración de constructor
            public Area(string nombre_figura)
            {
                this.nombre_figura = nombre_figura;
            }
            //Declaración de métodos con sobrecargas
            //Primer método
            public double CalcularArea(float lado_cuadrado)
            {
                return Math.Pow(lado_cuadrado, 2);
            }
            //Método sobrecargado
            public float CalcularArea(float largo_rectangulo, float ancho_rectangulo)
            {
                return largo_rectangulo * ancho_rectangulo;
            }
            //Método para desplegar información
            public void DesplegarArea(double area)
            {
                Console.WriteLine("\tEl área del {0} es : {1:f2}",this.nombre_figura, area);
            }
            //Destructor
            ~Area()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto " + this.nombre_figura);
            }
        }
        static void Main(string[] args)
        {   //Declaración de variables
            float lado_cuadrado, largo_rectangulo, ancho_rectangulo;
            double area;
            //Captura de datos
            Console.Write("\tIngrese el lado del cuadrado: "); lado_cuadrado = float.Parse(Console.ReadLine());
            //Creación del objeto
            Area ObjetoC = new Area("Cuadrado");
            //Llamda al método para calcular área
            area = ObjetoC.CalcularArea(lado_cuadrado);
            //lLamada al método para desplegar información
            ObjetoC.DesplegarArea(area);
            Console.Write("\tPresione la tecla <Enter> para continuar");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Captura de datos para nueva operación
            Console.Write("\tIngrese el largo del rectángulo: "); largo_rectangulo = float.Parse(Console.ReadLine());
            Console.Write("\tIngrese el ancho del rectángulo: "); ancho_rectangulo = float.Parse(Console.ReadLine());
            //Creacion de segundo objeto
            Area ObjetoR = new Area("Rectángulo");
            //Llamada al método sobrecargado para calcular el área
            area = ObjetoR.CalcularArea(largo_rectangulo, ancho_rectangulo);
            //Llamada al método sobrecargado para desplegar información
            ObjetoR.DesplegarArea(area);
            //Mensaje final
            Console.Write("\tPresione la tecla <Esc> para salir");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
