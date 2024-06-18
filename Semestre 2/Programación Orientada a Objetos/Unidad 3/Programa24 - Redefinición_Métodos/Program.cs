using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa24___Redefinición_Métodos
{
    internal class Program
    {
        //Declaración de clase base
        class Areas
        {
            //Campos de la clase base
            public float radio;
            //Constructor de la clase base
            public Areas(float radio)
            {
                this.radio = radio;
            }
            //Métodos virtuales de la clase base
            public virtual double CalcularArea()
            {
                return 0.0;
            }
            public virtual void ImprimirArea(double area)
            {
                //Vacío
            }
            //Destructor de la clase base
            ~Areas()
            {
                Console.WriteLine("\n\tMemoria Liberada del Objeto Base Areas ");
            }
        }
        //Declaración de primer clase derivada
        class Circulo : Areas
        {
            //Constructor de la clase derivada
            public Circulo(float radio) : base(radio)
            {
                base.radio = radio;
            }
            //Métodos override de la clase derivada
            public override double CalcularArea()
            {
                return Math.PI * Math.Pow(radio,2);
            }
            public override void ImprimirArea(double area)
            {
                Console.WriteLine("\n\t\t*** Despliegue de resultado ***");
                Console.WriteLine("\n\tEl radio del círculo es de {0:f4},\n\tpor lo tanto, su área es de {1:f4}.",base.radio, area);
            }
            //Destructor de la clase
            ~Circulo()
            {
                Console.WriteLine("\n\tMemoria Liberada del Objeto Derivada Círculo ");
            }
        }
        //Declaración de segunda clase derivada
        class Esfera : Areas
        {
            //Constructor de la clase derivada
            public Esfera(float radio) : base(radio)
            {
                base.radio = radio;
            }
            //Métodos override de la clase derivada
            public override double CalcularArea()
            {
                return 4 * Math.PI * Math.Pow(radio, 2);
            }
            public override void ImprimirArea(double area)
            {
                Console.WriteLine("\n\t\t*** Despliegue de resultado ***");
                Console.WriteLine("\n\tEl radio de la esfera es de {0:f4},\n\tpor lo tanto, su área es de {1:f4}.", base.radio, area);
            }
            //Destructor de la clase
            ~Esfera()
            {
                Console.WriteLine("\n\tMemoria Liberada del Objeto Derivada Esfera ");
            }
        }
        //Declaración de tercera clase derivada
        class Cilindro : Areas
        {
            //Declaración de campos de la clase derivada
            public float altura;
            //Constructor de la clase derivada
            public Cilindro(float radio, float altura) : base(radio)
            {
                base.radio = radio;
                this.altura = altura;
            }
            //Métodos override de la clase derivada
            public override double CalcularArea()
            {
                return 2 * Math.PI * base.radio * (base.radio + this.altura);
            }
            public override void ImprimirArea(double area)
            {
                Console.WriteLine("\n\t\t*** Despliegue de resultado ***");
                Console.WriteLine("\n\tEl radio del cilindro es de {0:f4} y su altura es de {1:f4},\n\tpor lo tanto, su área es de {2:f4}.", base.radio, this.altura, area);
            }
            //Destructor de la clase
            ~Cilindro()
            {
                Console.WriteLine("\n\tMemoria Liberada del Objeto Derivada Cilindro ");
            }
        }
        //Declaración de función auxiliar para capturar datos
        static double CapturaDouble(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return Convert.ToDouble(Console.ReadLine());
        }
        static float CapturaFloat(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return float.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            //Declaración de variables
            float radio, altura;
            double area;
            Console.WriteLine("\n\t\t*** Bienvenido ***");
            Console.Write("\n\tPresione la tecla <Enter o Intro> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Captura de datos para la clase base
            Console.WriteLine("\n\t\t~~~ CAPTURA DE DATOS ~~~\n\t\t    Círculo\n");
            radio = CapturaFloat("el radio del círculo");
            Console.WriteLine("\n\tDatos capturados correctamente.");
            Console.Write("\n\tPresione la tecla <Enter o Intro> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de instancia de la clase base
            Areas MiArea = new Areas(radio);
            //Creación de la instancia derivada círculo con herencia
            Circulo MiCirculo = new Circulo(MiArea.radio);
            //Calculo y despliegue de resultados
            area = MiCirculo.CalcularArea();
            Console.WriteLine("\n\t\t*** Círculo ***");
            MiCirculo.ImprimirArea(area);
            Console.WriteLine("\n\tCalculos realizados.\n\tEl proceso ha terminado.");
            Console.Write("\n\tPresione la tecla <Enter o Intro> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de la instancia derivada esfera con herencia
            Esfera MiEsfera = new Esfera(MiArea.radio);
            //Calculo y despliegue de resultados
            area = MiEsfera.CalcularArea();
            Console.WriteLine("\n\t\t*** Esfera ***");
            MiEsfera.ImprimirArea(area);
            Console.WriteLine("\n\tCalculos realizados.\n\tEl proceso ha terminado.");
            Console.Write("\n\tPresione la tecla <Enter o Intro> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Captura de datos para la clase derivada cilindro
            Console.WriteLine("\n\t\t~~~ CAPTURA DE DATOS ~~~\n\t\t    Cilindro\n");
            altura = CapturaFloat("la altura del cilindro");
            Console.WriteLine("\n\tDatos capturados correctamente.");
            Console.Write("\n\tPresione la tecla <Enter o Intro> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            //Creación de la instancia derivada cilindro con herencia
            Cilindro MiCilindro = new Cilindro(MiArea.radio,altura);
            //Calculo y despliegue de resultados
            area = MiCilindro.CalcularArea();
            Console.WriteLine("\n\t\t*** Cilindro ***");
            MiCilindro.ImprimirArea(area);
            Console.WriteLine("\n\tCalculos realizados.\n\tEl proceso ha terminado.");
            Console.Write("\n\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}