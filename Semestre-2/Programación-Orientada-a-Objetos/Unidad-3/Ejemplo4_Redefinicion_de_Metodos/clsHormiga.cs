using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4_Redefinicion_de_Metodos
{
    internal class clsHormiga : clsHexapoda
    {   //Declaración de constructor
        public clsHormiga(string nombre_cientifico, string patron_corporal, float tamaño, bool reina, short numero_segmentos, short numero_apendices, short numero_antenas, short numero_alas) : base (numero_segmentos, numero_apendices, numero_antenas, numero_alas)
        {
            base.nombre_cientifico = nombre_cientifico;
            base.patron_corporal = patron_corporal;
            base.tamaño = tamaño;
            base.reina = reina;
        }
        //Declaración de métodos override para redefinir los métodos virtuales
        public override void Reproducirse()
        {
            if (reina)
            {
                Console.WriteLine("\t{0} se ha reproducido con un especimen macho.",this.nombre_cientifico);
            }
            else
            {
                Console.WriteLine("\tSolamente las hormigas reina pueden reproducirse.");
            }
        }
        public override void Alimentarse()
        {
            Console.WriteLine("\t{0} Utiliza sus mandíbulas para cortar y triturar todo tipo de alimentos.",this.nombre_cientifico);
        }
        public override void Defenderse()
        {
            Console.WriteLine("\t{0} Utiliza sus mandíbulas para morder e inyectar veneno para escapar del peligro.",this.nombre_cientifico);
        }
        //Declaración de constructor
        ~clsHormiga()
        {
            Console.WriteLine("\n\tMemoria liberada de la clase hormiga");
        }
    }
}