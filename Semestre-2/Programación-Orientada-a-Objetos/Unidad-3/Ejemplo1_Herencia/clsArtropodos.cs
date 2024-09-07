using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Herencia
{
    //Declaración de la clase
    internal class clsArtropodos
    {
        //Campos de la clase
        protected string nombre_cientifico, color_general;
        protected short numero_segmentos, numero_apendices;
        protected float tamaño_total;
        protected bool hembra, pareja;
        //Constructor de la clase
        public clsArtropodos(string nombre_cientifico, string color_general, short numero_segmentos, short numero_apendices, float tamaño_total, bool hembra)
        {
            this.nombre_cientifico= nombre_cientifico;
            this.color_general= color_general;
            this.numero_segmentos= numero_segmentos;
            this.numero_apendices= numero_apendices;
            this.tamaño_total = tamaño_total;
            this.hembra= hembra;
        }
        //Métodos de la clase
        public void Caminar()
        {
            Console.WriteLine(this.nombre_cientifico + " utiliza sus " + this.numero_apendices + " apéndices para caminar.");
        }
        public void Descansar()
        {
            Console.WriteLine(this.nombre_cientifico + " disminuye su metabolismo y actividad neuronal para ahorrar energía.");
        }
        public void Reproducirse()
        {
            if (this.pareja)
            {
                Console.WriteLine(this.nombre_cientifico + " ha logrado tener descendencia, su objetivo a sido cumplido.");
            }
            else
            {
                Console.WriteLine(this.nombre_cientifico + " ha tenido mala suerte, no ha encontrado pareja para reproducirse.");
            }
        }
        //Destructor de la clase
        ~clsArtropodos()
        {
            Console.WriteLine("\nMemoria liberada del objeto " + this.nombre_cientifico);
        }
    }
}