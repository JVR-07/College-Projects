using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_ReutilizaciónMiembrosHeredados
{
    internal class clsTrenCargaSolidos
    {
        //Campos de la clase
        public string nombre_tren, color_tren;
        public float carga;
        //Constructores de la clase
        public clsTrenCargaSolidos()
        {
        }
        public clsTrenCargaSolidos(string nombre_tren, string color_tren, float carga)
        {
            this.nombre_tren = nombre_tren;
            this.color_tren = color_tren;
            this.carga = carga;
        }
        //Métodos de la clase
        public void SubirCarga(float nueva_carga)
        {
            this.carga += nueva_carga;
            Console.WriteLine("\n\tSe han añadido {0} kg de carga. La carga actual es de {1} kg",nueva_carga,this.carga);
        }
        public void DesplegarInformacion()
        {
            Console.WriteLine("\n\tEl nombre del tren es: " + this.nombre_tren);
            Console.WriteLine("\tEl color del tren es: " + this.color_tren);
            Console.WriteLine("\tLa carga actual es: {0} kg",this.carga);
        }
        //Destructor de la clase
        ~clsTrenCargaSolidos()
        {
            Console.WriteLine("\n\tMemoria liberada del objeto " + this.nombre_tren);
        }
    }
}