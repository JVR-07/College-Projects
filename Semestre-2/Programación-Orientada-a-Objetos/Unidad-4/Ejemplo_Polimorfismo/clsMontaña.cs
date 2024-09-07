using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Polimorfismo
{
    internal class clsMontaña : clsBicicleta
    {
        //Campos de la clase
        int marcha, marcha_maxima;
        float recorrido_suspension;

        //Métodos de la clase
        public override void Acelerar()
        {
            Console.WriteLine("\tLa bicicleta de montaña {0} pedalea en la marcha {1} hasta aumentar su velocidad y subir de marcha", base.modelo_bicicleta, this.marcha);
            if (this.marcha < this.marcha_maxima)
            {
                this.marcha++;
            }
            else
            {
                this.marcha = this.marcha_maxima;
            }
            Console.WriteLine("\tLa bicicleta de montaña ahora va en la marcha {0}", this.marcha);
        }
        public override void Frenar()
        {
            Console.WriteLine("\tLa bicicleta de montaña {0} utiliza los frenos y baja de marcha para detenerse", base.modelo_bicicleta);
            if (this.marcha > 0)
            {
                this.marcha--;
            }
            else
            {
                this.marcha = 0;
            }
            Console.WriteLine("\tLa bicicleta de montaña ahora va en la marcha {0}", this.marcha);
        }
        public override void Girar()
        {
            Console.WriteLine("\tLa bicicleta de montaña {0} utiliza el manubrio y se inclina al lado contrario para girar con mayor estabilidad",base.modelo_bicicleta);
        }
        public override void Saltar()
        {
            Console.WriteLine("\tLa bicicleta de montaña {0} salta para evitar los obstaculos y la suspensión de {1} cm amortigua la caída",base.modelo_bicicleta,this.recorrido_suspension);
        }

        public new void GetInfo()
        {
            Console.WriteLine("\tEl modelo de la bicicleta es: {0}" +
                              "\n\tEl color de la bicicleta es: {1}" +
                              "\n\tLa altura de la bicicleta es: {2} cm" +
                              "\n\tEl recorrido de la suspensión es de: {3} " +
                              "\n\tEl tamaño de la rueda es de: {4} pulgadas" +
                              "\n\tEl precio de la bicicleta es: {5:C} dólares"
                              , base.modelo_bicicleta, base.color_bicicleta, base.altura_bicicleta, this.recorrido_suspension, base.tamaño_rueda, base.precio_bicicleta);
        }

        //Constructores y destructor de la clase
        public clsMontaña(string modelo_bicicleta, string color_bicicleta, float altura_bicicleta, float tamaño_rueda, float precio_bicicleta, int marcha, int marcha_maxima, float recorrido_suspension) :
                 base(modelo_bicicleta, color_bicicleta, altura_bicicleta, tamaño_rueda, precio_bicicleta)
        {
            this.marcha = marcha;
            this.marcha_maxima = marcha_maxima;
            this.recorrido_suspension = recorrido_suspension;
        }
        ~clsMontaña()
        {
            Console.WriteLine("\n\tMemoria Liberada del Objeto Montaña " + base.modelo_bicicleta);
        }
    }
}