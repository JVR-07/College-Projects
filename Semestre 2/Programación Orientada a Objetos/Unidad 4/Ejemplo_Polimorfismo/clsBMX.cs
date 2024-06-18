using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Polimorfismo
{
    internal class clsBMX : clsBicicleta
    {
        //Campos de la clase
        bool frenos_bmx;

        //Métodos de la clase
        public override void Acelerar()
        {
            Console.WriteLine("\tLa BMX {0} pedalea para aumentar su velocidad.",base.modelo_bicicleta);
        }
        public override void Frenar()
        {
            if (frenos_bmx)
            {
                Console.WriteLine("\tLa BMX {0} utiliza los frenos de pastilla para detenerse",base.modelo_bicicleta);
            }
            else
            {
                Console.WriteLine("\tLa BMX {0} no tiene frenos, por lo que sigue avanzando " +
                                  "\n\thasta que la fuerza de friccion haga su trabajo.",base.modelo_bicicleta);
            }
        }
        public override void Girar()
        {
            Console.WriteLine("\tLa BMX {0} utiliza el manubrio para girar", base.modelo_bicicleta);
        }
        public override void Saltar()
        {
            Console.WriteLine("\tLa BMX {0} salta haciendo acrobacias", base.modelo_bicicleta);
        }

        //Constructores y destructor de la clase
        public clsBMX(string modelo_bicicleta, string color_bicicleta, float altura_bicicleta, float tamaño_rueda, float precio_bicicleta, bool frenos_bmx) :
                 base(modelo_bicicleta, color_bicicleta, altura_bicicleta, tamaño_rueda, precio_bicicleta)
        {
            this.frenos_bmx = frenos_bmx;
        }
        ~clsBMX()
        {
            Console.WriteLine("\n\tMemoria Liberada del Objeto BMX " + base.modelo_bicicleta);
        }
    }
}