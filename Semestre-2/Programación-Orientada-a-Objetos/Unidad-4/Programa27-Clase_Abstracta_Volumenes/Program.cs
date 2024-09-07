using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa27_Clase_Abstracta_Volumenes
{
    internal class Program
    {   //Declaración de clase base abstracta
        public abstract class Figuras
        {  //campos
            public float radio, altura, lado;
            public double volumen;
            //métodos
            abstract public double calcularVolumen();
            abstract public void desplegarVolumen();
            //destructor
            ~Figuras()
            {
                Console.WriteLine("Memoria Objeto Clase Abstracta Figuras Liberada");
            }
        }
        //Declaración clase derivada esfera
        public class Esfera : Figuras
        {
            //Constructor
            public Esfera(float radio)
            {
                this.radio = radio;
            }
            // Implementación de Métodos Abstractos
            public override double calcularVolumen()
            {
                return this.volumen = (4 / 3f) * Math.PI * Math.Pow(radio, 3);
            }
            public override void desplegarVolumen()
            {
                Console.WriteLine("El radio de la Esfera es: " + this.radio);
                Console.WriteLine("El Volumen de la Esfera es: " + this.volumen);
            }
            //destructor
            ~Esfera()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Esfera Liberada");
            }
        }
        //Declaración clase derivada Cubo
        public class Cubo : Figuras
        {
            //Constructor
            public Cubo(float lado)
            {
                this.lado = lado;
            }
            // Implementación de Métodos Abstractos
            public override double calcularVolumen()
            {
                return this.volumen = Math.Pow(lado,3);
            }
            public override void desplegarVolumen()
            {
                Console.WriteLine("El lado del Cubo es: " + this.lado);
                Console.WriteLine("El Volumen del Cubo es: " + this.volumen);
            }
            //destructor
            ~Cubo()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Cubo Liberada");
            }
        }
        //Declaración clase derivada Cilindro
        public class Cilindro : Figuras
        {
            //Constructor
            public Cilindro(float radio, float altura)
            {
                this.radio = radio;
                this.altura = altura;
            }
            // Implementación de Métodos Abstractos
            public override double calcularVolumen()
            {
                return this.volumen = Math.PI*Math.Pow(radio,2)*altura;
            }
            public override void desplegarVolumen()
            {
                Console.WriteLine("El radio del Cilindro es: " + this.radio);
                Console.WriteLine("La altura del Cilindro es: " + this.altura);
                Console.WriteLine("El Volumen del Cilindro es: " + this.volumen);
            }
            //destructor
            ~Cilindro()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Cilindro Liberada");
            }
        }
        //Declaración clase derivada Cono
        public class Cono : Figuras
        {
            //Constructor
            public Cono(float radio, float altura)
            {
                this.radio = radio;
                this.altura = altura;
            }
            // Implementación de Métodos Abstractos
            public override double calcularVolumen()
            {
                return this.volumen = (1/3f)*Math.PI*Math.Pow(radio,2)*altura;
            }
            public override void desplegarVolumen()
            {
                Console.WriteLine("El radio del Cono es: " + this.radio);
                Console.WriteLine("La altura del Cono es: " + this.altura);
                Console.WriteLine("El Volumen del Cono es: " + this.volumen);
            }
            //destructor
            ~Cono()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Cono Liberada");
            }
        }

        //Declaración de función auxiliar para captura de datos
        static float CapturaFloat(string texto_pantalla)
        {
            Console.Write("\tIngrese {0} : ", texto_pantalla);
            return float.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {   //Declaración de variables
            float radio, altura, lado;
           
            //Objeto Esfera

            Console.WriteLine("\n\t\t\t*** Esfera ***\n");
            radio = CapturaFloat("el radio de la esfera"); //Función auxiliar
            Esfera MiEsfera = new Esfera(radio);
            MiEsfera.calcularVolumen();
            MiEsfera.desplegarVolumen();
            Console.WriteLine("\n\tProceso terminado exitosamente.");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            
            //Objeto Cubo

            Console.WriteLine("\n\t\t\t*** Cubo ***\n");
            lado = CapturaFloat("el lado del cubo"); //Función auxiliar
            Cubo MiCubo = new Cubo(lado);
            MiCubo.calcularVolumen();
            MiCubo.desplegarVolumen();
            Console.WriteLine("\n\tProceso terminado exitosamente.");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Objeto Cilindro

            Console.WriteLine("\n\t\t\t*** Cilindro ***\n");
            radio = CapturaFloat("el radio del cilindro"); //Función auxiliar
            altura = CapturaFloat("la altura del cilindro"); //Función auxiliar
            Cilindro MiCilindro = new Cilindro(radio,altura);
            MiCilindro.calcularVolumen();
            MiCilindro.desplegarVolumen();
            Console.WriteLine("\n\tProceso terminado exitosamente.");
            Console.Write("\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Objeto Cono

            Console.WriteLine("\n\t\t\t*** Cono ***\n");
            radio = CapturaFloat("el radio del cono"); //Función auxiliar
            altura = CapturaFloat("la altura del cono"); //Función auxiliar
            Cono MiCono = new Cono(radio,altura);
            MiCono.calcularVolumen();
            MiCono.desplegarVolumen();
            Console.WriteLine("\n\tProceso terminado exitosamente.");
            Console.Write("\tPresione la tecla <Esc> para salir...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}