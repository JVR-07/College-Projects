using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_ReutilizaciónMiembrosHeredados
{
    internal class clsTrenCargaLiquidos : clsTrenCargaSolidos
    {
        //Campos de la clase. Uso del operador new para ocultar método de la clase base
        new float carga;
        //Constructor de la clase
        public clsTrenCargaLiquidos(string nombre_tren, string color_tren, float carga) : base(nombre_tren,color_tren,carga)
        {
            this.carga = carga;
        }
        //Método de la clase. Uso de operador new para ocultar método de la clase base
        new public void SubirCarga(float nueva_carga)
        {
            this.carga += nueva_carga;
            Console.WriteLine("\n\tSe han añadido {0} L de carga. La carga actual es de {1} L", nueva_carga, this.carga);
        }
        //Uso del operador new para ocultar método de la clase base
        new public void DesplegarInformacion()
        {
            Console.WriteLine("\n\tEl nombre del tren es: " + this.nombre_tren);
            Console.WriteLine("\tEl color del tren es: " + this.color_tren);
            Console.WriteLine("\tLa carga actual es: {0} L", this.carga);
        }
        //Destructor de la clase
        ~clsTrenCargaLiquidos()
        {
            Console.WriteLine("\n\tMemoria liberada del objeto " + this.nombre_tren);
        }
    }
}