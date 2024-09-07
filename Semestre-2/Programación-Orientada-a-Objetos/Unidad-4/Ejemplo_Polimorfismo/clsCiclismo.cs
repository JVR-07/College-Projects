using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Polimorfismo
{
    internal class clsCiclismo : clsBicicleta
    {
        //Campos de la clase
        int marcha, marcha_maxima;

        //Métodos de la clase
        public override void Acelerar()
        {
            Console.WriteLine("\tLa bicicleta de ciclismo {0} pedalea en la marcha {1} hasta aumentar su velocidad y subir de marcha", base.modelo_bicicleta,this.marcha);
            if(this.marcha < this.marcha_maxima ) 
            {
                this.marcha++;
            }
            else
            {
                this.marcha = this.marcha_maxima;
            }
            Console.WriteLine("\tLa bicicleta de ciclismo ahora va en la marcha {0}", this.marcha);
        }
        public override void Frenar()
        {
            Console.WriteLine("\tLa bicicleta de ciclismo {0} utiliza los frenos y baja de marcha para detenerse", base.modelo_bicicleta);
            if(this.marcha > 0)
            {
                this.marcha--;
            }
            else
            {
                this.marcha = 0;
            }
            Console.WriteLine("\tLa bicicleta de ciclismo ahora va en la marcha {0}", this.marcha);
        }
        public override void Girar()
        {
            Console.WriteLine("\tLa bicicleta de ciclismo {0} utiliza el manubrio y se inclina para girar con mayor velocidad", base.modelo_bicicleta);
        }

        //Constructores y destructor de la clase
        public clsCiclismo(string modelo_bicicleta, string color_bicicleta, float altura_bicicleta, float tamaño_rueda, float precio_bicicleta, int marcha, int marcha_maxima) :
                 base(modelo_bicicleta, color_bicicleta, altura_bicicleta, tamaño_rueda, precio_bicicleta)
        {
            this.marcha = marcha;
            this.marcha_maxima = marcha_maxima;
        }
        ~clsCiclismo()
        {
            Console.WriteLine("\n\tMemoria Liberada del Objeto Ciclismo " + base.modelo_bicicleta);
        }
    }
}