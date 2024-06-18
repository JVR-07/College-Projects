using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Programa17___Clase_Circulo
{
    internal class Program
    {
        //Declaración de campos
        class Circulo
        {
            //Campos de la clase
            private float radio_circulo;
            //Primer constructor de la clase
            public Circulo()
            {
                Console.WriteLine("\n\tObjeto creado sin valores");
            }
            //Segundo constructor de la clase
            public Circulo(float radio_circulo)
            {
                this.radio_circulo = radio_circulo;
            }
            //Métodos para calcular area
            public double CalcularAreaCirculo() 
            {
                double area_circulo;
                return area_circulo = Math.PI * Math.Pow(this.radio_circulo, 2);
            }
            //Método para calcular circunferencia
            public double CalcularCircunferenciaCirculo()
            {
                double circunferencia_circulo;
                return circunferencia_circulo = 2 * Math.PI * this.radio_circulo;
            }
            //Método para desplegar la información y resultados
            public void DesplegarInformacionCirculo(double area_circulo, double circunferencia_circulo)
            {
                Console.WriteLine("\n\t\t*** Datos ingresados ***\n\n\tEl radio ingresado para el círculo es de: " + this.radio_circulo);
                Console.WriteLine("\n\t\t*** Datos calculados ***\n\n\tEl área resultante para el círculo es de: {0}\n\tLa circunferencia resultante para el círculo es de: {1}", area_circulo,circunferencia_circulo);
            }
            //Destructor de la clase
            ~Circulo()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto Circulo");
            }
        }
        static void Main(string[] args)
        {   //Declaración de variables
            float radio_circulo;
            double area_circulo, circunferencia_circulo;
            //Bienvenida
            Console.WriteLine("\n\t\t*** Bienvenido al programa ***");
            Console.Write("\n\tPresione la tecla <Enter> o <Intro> para arrancar el proceso...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Captura de datos
            Console.Write("\tIngrese el radio del círculo: ");
            radio_circulo = float.Parse(Console.ReadLine());
            Console.Write("\n\tPresione <Enter o Intro> para confirmar los datos...");
            Console.ReadLine();
            Console.Clear();
            //Creación del objeto sin parámetros
            Circulo miCirculo = new Circulo();
            Console.Write("\n\tPresione cualquier tecla para cargar los cálculos...");
            Console.ReadLine();
            Console.Clear();
            //Creacion del objeto con parámetros
            miCirculo = new Circulo(radio_circulo);
            //Llamada a los métodos
            area_circulo = miCirculo.CalcularAreaCirculo();
            circunferencia_circulo = miCirculo.CalcularCircunferenciaCirculo();
            area_circulo = Math.Round(area_circulo,4);
            circunferencia_circulo = Math.Round(circunferencia_circulo, 4);
            miCirculo.DesplegarInformacionCirculo(area_circulo,circunferencia_circulo);
            //Mensaje final
            Console.Write("\n\tEl proceso ha terminado.\n\tPresione la tecla <Esc> para salir del programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
