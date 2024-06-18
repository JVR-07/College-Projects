using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa25___Practica_Unidad3
{
    internal class Program
    {   //Definicion de la clase base
        class FuncionesMatematicas
        {   //Campo de la clase base 
            public float angulo;
            //Constructor de la clase base 
            public FuncionesMatematicas(float angulo)
            {
                this.angulo = angulo;
            }
            //Métodos de la clase base 
            public virtual double CalcularFuncion()
            {
                return 0;
            }
            public void DesplegarFuncion(double resultado)
            {

            }
            //Desrtructor de la clase base
            ~FuncionesMatematicas()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto FuncionesMatematicas");
            }
        }
        //Declaración clase derivada seno
        class Seno : FuncionesMatematicas
        {
            //Constructor de la clase derivada
            public Seno(float angulo) : base(angulo)
            {
                base.angulo = angulo;
            }
            //Métodos de la clase derivada
            public override double CalcularFuncion()
            {
                return Math.Sin(base.angulo);
            }
            new public void DesplegarFuncion(double resultado)
            {
                Console.WriteLine("\n\t\t*** Resultado Seno ***");
                Console.Write("\tEl valor del angulo es: " + base.angulo);
                Console.Write("\tEl resultado de la función es: {0:f4}",resultado);
            }
            //Desrtructor de la clase derivada
            ~Seno()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto Seno");
            }
        }
        //Declaración de la clase derivada coseno
        class Coseno : FuncionesMatematicas
        {
            //Constructor de la clase derivada
            public Coseno(float angulo) : base(angulo)
            {
                base.angulo = angulo;
            }
            //Métodos de la clase derivada
            public override double CalcularFuncion()
            {
                return Math.Cos(base.angulo);
            }
            new public void DesplegarFuncion(double resultado)
            {
                Console.WriteLine("\n\t\t*** Resultado Coseno ***");
                Console.Write("\tEl valor del angulo es: " + base.angulo);
                Console.Write("\tEl resultado de la función es: {0:f4}", resultado);
            }
            //Desrtructor de la clase derivada
            ~Coseno()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto Coseno");
            }
        }
        //Declaración de clase derivada tangente
        class Tangente : FuncionesMatematicas
        {
            //Constructor de la clase derivada
            public Tangente(float angulo) : base(angulo)
            {
                base.angulo = angulo;
            }
            //Métodos de la clase derivada
            public override double CalcularFuncion()
            {
                return Math.Tan(base.angulo);
            }
            new public void DesplegarFuncion(double resultado)
            {
                Console.WriteLine("\n\t\t*** Resultado Tangente ***");
                Console.Write("\tEl valor del angulo es: " + base.angulo);
                Console.Write("\tEl resultado de la función es: {0:f4}", resultado);
            }
            //Desrtructor de la clase derivada
            ~Tangente()
            {
                Console.WriteLine("\n\tMemoria liberada del objeto Tangente");
            }
        }
        //Declaración de función auxiliar para capturar datos
        static float CapturaFloat(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return float.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {   //Declaración de variables
            double resultado;
            float angulo;
            //Captura de datos
            Console.WriteLine("\n\t\t*** Captura Datos ***\n");
            angulo = CapturaFloat("ingrese el ángulo");
            Console.WriteLine("\n\tDatos capturados correctamente");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de objeto de la clase base
            FuncionesMatematicas FuncionesTrigonometricas = new FuncionesMatematicas(angulo);
            //Creación de objeto de clase derivada seno
            Seno NewSeno = new Seno(FuncionesTrigonometricas.angulo);
            //Llamada a métodos
            resultado = NewSeno.CalcularFuncion();
            NewSeno.DesplegarFuncion(resultado);
            Console.WriteLine("\n\tCalculos terminados");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de objeto de clase derivada coseno
            Coseno NewCoseno = new Coseno(FuncionesTrigonometricas.angulo);
            //Llamada a métodos
            resultado = NewCoseno.CalcularFuncion();
            NewCoseno.DesplegarFuncion(resultado);
            Console.WriteLine("\n\tCalculos terminados");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de objeto de clase derivada coseno
            Tangente NewTangente = new Tangente(FuncionesTrigonometricas.angulo);
            //Llamada a métodos
            resultado = NewTangente.CalcularFuncion();
            NewTangente.DesplegarFuncion(resultado);
            Console.WriteLine("\n\tCalculos terminados");
            Console.Write("\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}