using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lbrVolumenes
{   //Clase Esfera
    public class clsEsfera
    {
        //campo
        float radio;
        //constructor
        public clsEsfera(float radio)
        { 
            this.radio = radio; 
        }
        //métodos
        public double calcularVolumen()
        {
            return (4 / 3f) * Math.PI * Math.Pow(radio, 3);
        }
        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("El Radio de la Esfera es: {0}", this.radio);
            Console.WriteLine("El Volumen de la Esfera es: {0}", volumen);
        }
        //destructor
        ~clsEsfera()
        { 
            Console.WriteLine("Memoria Objeto Clase Esfera Liberada"); 
        }
    }//fin clase Esfera

    //Clase Cubo
    public class clsCubo
    {
        //campo
        float lado;
        //constructor
        public clsCubo(float lado)
        {
            this.lado = lado;
        }
        //métodos
        public double calcularVolumen()
        {
            return Math.Pow(this.lado, 3);
        }
        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("El Lado del Cubo es: {0}", this.lado);
            Console.WriteLine("El Volumen del Cubo es: {0}", volumen);
        }
        //destructor
        ~clsCubo()
        { 
            Console.WriteLine("Memoria Objeto Clase Cubo Liberada"); 
        }
    }//fin clase Cubo

    //Clase Cilindro
    public class clsCilindro
    {
        //campo
        float radio, altura;
        //constructor
        public clsCilindro(float radio, float altura)
        {
            this.radio = radio;
            this.altura = altura;
        }
        //métodos
        public double calcularVolumen()
        {
            return Math.PI * Math.Pow(this.radio, 2) * this.altura;
        }
        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("El Lado del Cilindro es: {0}", this.radio);
            Console.WriteLine("La Altura del Cilindro es: {0}", this.altura);
            Console.WriteLine("El Volumen del Cilindro es: {0}", volumen);
        }
        //destructor
        ~clsCilindro()
        {
            Console.WriteLine("Memoria Objeto Clase Cilindro Liberada");
        }
    }//fin clase Cono

    //Clase Cono
    public class clsCono
    {
        //campo
        float radio, altura;
        //constructor
        public clsCono(float radio, float altura)
        {
            this.radio = radio;
            this.altura = altura;
        }
        //métodos
        public double calcularVolumen()
        {
            return (1 / 3f) * Math.PI * Math.Pow(radio, 2) * altura;
        }
        public void desplegarVolumen(double volumen)
        {
            Console.WriteLine("El Lado del Cono es: {0}", this.radio);
            Console.WriteLine("La Altura del Cono es: {0}", this.altura);
            Console.WriteLine("El Volumen del Cono es: {0}", volumen);
        }
        //destructor
        ~clsCono()
        {
            Console.WriteLine("Memoria Objeto Clase Cono Liberada");
        }
    }//fin clase Cono
}
