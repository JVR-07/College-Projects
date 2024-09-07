using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4_Redefinicion_de_Metodos
{
    internal class clsHexapoda
    {   //campos de la clase
        protected string nombre_cientifico, patron_corporal;
        protected short numero_segmentos, numero_apendices, numero_antenas, numero_alas;
        protected float tamaño;
        protected bool reina;
        //Constructor de la clase
        public clsHexapoda(short numero_segmentos, short numero_apendices, short numero_antenas, short numero_alas)
        {
            this.numero_segmentos = numero_segmentos;
            this.numero_apendices = numero_apendices;
            this.numero_antenas = numero_antenas;
            this.numero_alas = numero_alas;
        }
        //Métodos virtuales de la clase para permitir su redefinición
        public virtual void Caminar()
        {
            Console.WriteLine("\t{0} utiliza sus {1} apéndices para caminar.",this.nombre_cientifico,this.numero_apendices);
        }
        public void Descansar()
        {
            Console.WriteLine("\t{0} disminuye su metabolismo y actividad neuronal para ahorrar energía.",this.nombre_cientifico);
        }
        public virtual void Reproducirse()
        {
                Console.WriteLine("\t{0} ha logrado tener descendencia, su objetivo a sido cumplido.", this.nombre_cientifico);
        }
        public virtual void Defenderse()
        {
            Console.WriteLine("\t{0} utiliza sus mecanismos de defensa para escapar del peligro.",this.nombre_cientifico);
        }
        public virtual void Alimentarse()
        {
            Console.WriteLine("\t{0} Utiliza su sistema digestivo para alimentarse",this.nombre_cientifico);
        }
        public void DesplegarInformacion()
        {
            Console.WriteLine("\tEl nombre es: {0}\n\tEl patrón corporal es: {1}", this.nombre_cientifico, this.patron_corporal);
            Console.WriteLine("\tEl número de segmentos es: {0}\n\tEl número de apéndices es: {1}\n\tEl número de alas es: {2}\n\tEl número de antenas es:", this.numero_segmentos, this.numero_apendices, this.numero_alas, this.numero_antenas);
            Console.WriteLine("\tEl tamaño total es: {0} cm", this.tamaño);
            if (reina)
            {
                Console.WriteLine("\tLa posición social es: Reina");
            }
            else
            {
                Console.WriteLine("\tLa posición social es: Distinto de reina");
            }
        }
        //Destructor de la clase
        ~clsHexapoda()
        {
            Console.WriteLine("\n\tMemoria liberada del objeto " + this.nombre_cientifico);
        }
    }
}