using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetros
{
   
    public class Rombo //Declaración de clase derivada Rombo
    {
        //Campos de la clase
        float lado_rombo;
        //Constructor de la clase
        public Rombo(float lado_rombo)
        {
            this.lado_rombo = lado_rombo;
        }
        //Métodos de la clase derivada
        public float CalcularPerimetro()
        {
            return 4 * this.lado_rombo;
        }
        public void DesplegarPerimetro(float resultado)
        {
            Console.WriteLine("\tEl valor del lado es: {0}" +
                              "\n\tEl resultado es: {1:f4}", this.lado_rombo, resultado);
        }
        //Destructor de la clase
        ~Rombo()
        {
            Console.WriteLine("\n\tMemoria Liberada del objeto Rombo");
        }
    }

    public class Romboide //Declaración de clase derivada Romboide
    {
        //Campos de la clase
        float base_romboide, altura_romboide;
        //Constructor de la clase
        public Romboide(float base_romboide, float altura_romboide)
        {
            this.base_romboide = base_romboide;
            this.altura_romboide = altura_romboide;
        }
        //Métodos de la clase derivada
        public float CalcularPerimetro()
        {
            return (2 * this.base_romboide) + (2 * this.altura_romboide);
        }
        public void DesplegarPerimetro(float resultado)
        {
            Console.WriteLine("\tEl valor de la base es: {0}" +
                              "\n\tEl valor de la altura es: {1}" +
                              "\n\tEl resultado es: {2:f4}", this.base_romboide, this.altura_romboide, resultado);
        }
        //Destructor de la clase
        ~Romboide()
        {
            Console.WriteLine("\n\tMemoria Liberada del objeto Romboide");
        }
    }

    public class PoligonoRegular //Declaración de clase derivada PoligonoRegular
    {
        //Campos de la clase
        float lado_poligono;
        short numero_lados_poligono;
        //Constructor de la clase
        public PoligonoRegular(float lado_poligono, short numero_lados_poligono)
        {
            this.lado_poligono = lado_poligono;
            this.numero_lados_poligono = numero_lados_poligono;
        }
        //Métodos de la clase derivada
        public float CalcularPerimetro()
        {
            return this.lado_poligono * this.numero_lados_poligono;
        }
        public void DesplegarPerimetro(float resultado)
        {
            Console.WriteLine("\tEl valor del lado es: {0}" +
                              "\n\tEl número de lados es: {1}" +
                              "\n\tEl resultado es: {2:f4}", this.lado_poligono, this.numero_lados_poligono, resultado);
        }
        //Destructor de la clase
        ~PoligonoRegular()
        {
            Console.WriteLine("\n\tMemoria Liberada del objeto PoligonoRegular");
        }
    }
}