using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa28_Interfaz_Volumenes
{
    internal class Program
    {
        //Declaración de interfaz 
        public interface IFiguras
        {   //Declaración de métodos abstractos
            double calcularVolumen();
            void desplegarVolumen(double result);
        }

        //Declaración de clases derivada Esfera
        class Esfera : IFiguras
        {
            //Declaración de campos
            float radio;

            //Declaración de métodos
            public double calcularVolumen()
            {
                return (4 / 3f) * Math.PI * Math.Pow(this.radio, 3);
            }
            public void desplegarVolumen(double result)
            {
                Console.WriteLine("\tEL radio es de: {0}" +
                                  "\n\tEl volumen es de: {1:f4}", this.radio,result);
            }

            //Declaración de constructores y destructores
            public Esfera(float radio)
            {
                this.radio = radio;
            }
            ~Esfera()
            {
                Console.WriteLine("\n\tMemoria Liberada Objeto Esfera");
            }
        }
        
        //Declaración de clases derivada Cubo
        class Cubo : IFiguras
        {
            //Declaración de campos
            float lado;

            //Declaración de métodos
            public double calcularVolumen()
            {
                return Math.Pow(this.lado, 3);
            }
            public void desplegarVolumen(double result)
            {
                Console.WriteLine("\tEL lado es de: {0}" +
                                  "\n\tEl volumen es de: {1:f4}", this.lado, result);
            }

            //Declaración de constructores y destructores
            public Cubo(float lado)
            {
                this.lado = lado;
            }
            ~Cubo()
            {
                Console.WriteLine("\n\tMemoria Liberada Objeto Cubo");
            }
        }

        //Declaración de clases derivada Cilindro
        class Cilindro : IFiguras
        {
            //Declaración de campos
            float radio, altura;

            //Declaración de métodos
            public double calcularVolumen()
            {
                return Math.PI*Math.Pow(this.radio,2)*this.altura;
            }
            public void desplegarVolumen(double result)
            {
                Console.WriteLine("\tEL radio es de: {0}" +
                                  "\n\tLa altura es de: {1}" +
                                  "\n\tEl volumen es de: {2:f4}", this.radio, this.altura, result);
            }

            //Declaración de constructores y destructores
            public Cilindro(float radio, float altura)
            {
                this.radio = radio;
                this.altura = altura;
            }
            ~Cilindro()
            {
                Console.WriteLine("\n\tMemoria Liberada Objeto Cilindro");
            }
        }

        //Declaración de clases derivada Cono
        class Cono : IFiguras
        {
            //Declaración de campos
            float radio, altura;

            //Declaración de métodos
            public double calcularVolumen()
            {
                return (1/3f) * Math.PI * Math.Pow(radio,2)*altura;
            }
            public void desplegarVolumen(double result)
            {
                Console.WriteLine("\tEL radio es de: {0}" +
                                  "\n\tLa altura es de: {1}" +
                                  "\n\tEl volumen es de: {2:f4}", this.radio, this.altura, result);
            }

            //Declaración de constructores y destructores
            public Cono(float radio, float altura)
            {
                this.radio = radio;
                this.altura = altura;
            }
            ~Cono()
            {
                Console.WriteLine("\n\tMemoria Liberada Objeto Cono");
            }
        }
        static void Main(string[] args)
        {
            //Declaración de variables auxiliares
            float radio, altura, lado;
            double result;

            //Captura de datos esfera
            Console.WriteLine("\n\t\t\t*** Esfera ***");
            Console.WriteLine("\n\tPara continuar ingrese los siguientes datos...\n\n");
            Console.Write("\tRadio: "); radio = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\tDatos capturados correctamente.");
            Console.Write("\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Creación de objeto esfera y llamada a métodos
            Esfera MiEsfera = new Esfera(radio);
            Console.WriteLine("\n\t\t\t*** Esfera ***");
            result = MiEsfera.calcularVolumen();
            MiEsfera.desplegarVolumen(result);
            Console.WriteLine("\n\tDatos mostrados correctamente.");
            Console.Write("\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Captura de datos Cubo
            Console.WriteLine("\n\t\t\t*** Cubo ***");
            Console.WriteLine("\n\tPara continuar ingrese los siguientes datos...\n\n");
            Console.Write("\tLado: "); lado = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\tDatos capturados correctamente.");
            Console.Write("\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Creación de objeto cubo y llamada a métodos
            Cubo MiCubo = new Cubo(lado);
            Console.WriteLine("\n\t\t\t*** Cubo ***");
            result = MiCubo.calcularVolumen();
            MiCubo.desplegarVolumen(result);
            Console.WriteLine("\n\tDatos mostrados correctamente.");
            Console.Write("\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Captura de datos Cilindro
            Console.WriteLine("\n\t\t\t*** Cilindro ***");
            Console.WriteLine("\n\tPara continuar ingrese los siguientes datos...\n\n");
            Console.Write("\tRadio: "); radio = float.Parse(Console.ReadLine());
            Console.Write("\tAltura: "); altura = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\tDatos capturados correctamente.");
            Console.Write("\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Creación de objeto Cilindro y llamada a métodos
            Cilindro MiCilindro = new Cilindro(radio, altura);
            Console.WriteLine("\n\t\t\t*** Cilindro ***");
            result = MiCilindro.calcularVolumen();
            MiCilindro.desplegarVolumen(result);
            Console.WriteLine("\n\tDatos mostrados correctamente.");
            Console.Write("\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Captura de datos Cono
            Console.WriteLine("\n\t\t\t*** Cono ***");
            Console.WriteLine("\n\tPara continuar ingrese los siguientes datos...\n\n");
            Console.Write("\tRadio: "); radio = float.Parse(Console.ReadLine());
            Console.Write("\tAltura: "); altura = float.Parse(Console.ReadLine());
            Console.WriteLine("\n\tDatos capturados correctamente.");
            Console.Write("\n\tPresione la tecla <Enter> para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();

            //Creación de objeto Cono y llamada a métodos
            Cono MiCono = new Cono(radio, altura);
            Console.WriteLine("\n\t\t\t*** Cono ***");
            result = MiCono.calcularVolumen();
            MiCono.desplegarVolumen(result);
            Console.WriteLine("\n\tDatos mostrados correctamente.");
            Console.Write("\n\tPresione la tecla <Esc> para salir del programa...");
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}