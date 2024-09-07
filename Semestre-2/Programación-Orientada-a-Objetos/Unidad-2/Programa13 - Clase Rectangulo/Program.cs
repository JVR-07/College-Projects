using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa13___Clase_Rectangulo
{
    internal class Program
    {
        //Declaración de la clase
        public class Rectangulo
        {
            //Declaracion de campos
            public float ancho_rectangulo;
            public float alto_rectangulo;

            //Asignación de constructor
            public Rectangulo(float _ancho_rectangulo, float _alto_rectangulo)
            {
                ancho_rectangulo = _ancho_rectangulo;
                alto_rectangulo = _alto_rectangulo;
            }

            //Declaración de métodos
            public float calcularArea(float ancho_rectangulo, float alto_rectangulo)
            {
                float area = 0f;
                return area = ancho_rectangulo * alto_rectangulo;
            }
            //Procedimiento 
            public void calcularPerimetro(float ancho_rectangulo, float alto_rectangulo)
            {
                float perimetro = 0f;
                perimetro = (ancho_rectangulo + alto_rectangulo) / 2;
                //Desplegar el resultado
                Console.WriteLine("\tEl perímetro es de {0:f2}",perimetro);
            }
            //Destructor 
            ~Rectangulo() 
            {
                Console.WriteLine("\tMemoria del objeto rectangulo liberada");
            }
        }
        static void Main(string[] args)
        {
            //Declaración de variables locales
            float ancho_rectangulo = 0f, alto_rectangulo = 0f;
            Console.Write("\tIngresa el valor del ancho del rectangulo: "); ancho_rectangulo = Single.Parse(Console.ReadLine());
            Console.Write("\tIngresa el valor del alto del rectangulo: "); alto_rectangulo = Single.Parse(Console.ReadLine());
            //Creación del objeto
            Rectangulo miRectangulo = new Rectangulo(ancho_rectangulo, alto_rectangulo);
            //Ejecucion de métodos
            Console.WriteLine("\tEl área del rectangulo es de {0:f2}.",miRectangulo.calcularArea(ancho_rectangulo,alto_rectangulo));
            miRectangulo.calcularPerimetro(ancho_rectangulo,alto_rectangulo);
            Console.Write("\tEl programa ha finalizado.\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}