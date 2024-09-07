using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Polimorfismo
{
    internal class clsBicicleta //Declaración de clase base
    {
        //Campos de la clase base
        protected string modelo_bicicleta, color_bicicleta;
        protected float altura_bicicleta, precio_bicicleta, tamaño_rueda;

        //Métodos de la clase base
        public virtual void Acelerar()
        {
            //Vacio para redefinirse después
        }
        public virtual void Frenar()
        {
            //Vacio para redefinirse después
        }
        public virtual void Girar()
        {
            //Vacio para redefinirse después
        }
        public virtual void Saltar()
        {
            //Vacio para redefinirse después
        }
        public void GetInfo()
        {
            Console.WriteLine("\tEl modelo de la bicicleta es: {0}" +
                              "\n\tEl color de la bicicleta es: {1}" +                               
                              "\n\tLa altura de la bicicleta es: {2} cm" +
                              "\n\tEl tamaño de la rueda es de: {3} pulgadas" +
                              "\n\tEl precio de la bicicleta es: {4:C} dólares"
                              , this.modelo_bicicleta, this.color_bicicleta, this.altura_bicicleta, this.tamaño_rueda, this.precio_bicicleta);
        }

        // Constructor y destructor de la clase base
        public clsBicicleta(string modelo_bicicleta, string color_bicicleta, float altura_bicicleta, float tamaño_rueda, float precio_bicicleta)
        {
            this.modelo_bicicleta = modelo_bicicleta;
            this.color_bicicleta = color_bicicleta;
            this.altura_bicicleta = altura_bicicleta;
            this.tamaño_rueda = tamaño_rueda;
            this.precio_bicicleta = precio_bicicleta;
        }

        ~clsBicicleta()
        {
            Console.WriteLine("\n\tMemoria Liberada del Objeto Bicicleta " + this.modelo_bicicleta);
        }
    }
}