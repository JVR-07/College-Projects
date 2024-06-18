using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4_Redefinicion_de_Metodos
{
    internal class clsAbeja : clsHexapoda
    {
        //Declaración de constructor
        public clsAbeja(string nombre_cientifico, string patron_corporal, float tamaño, bool reina, short numero_segmentos, short numero_apendices, short numero_antenas, short numero_alas) : base(numero_segmentos, numero_apendices, numero_antenas, numero_alas)
        {
            base.nombre_cientifico = nombre_cientifico;
            base.patron_corporal = patron_corporal;
            base.tamaño = tamaño;
            base.reina = reina;
        }
        //Declaración de métodos override para redefinir los métodos virtuales
        public override void Caminar()
        {
            Console.WriteLine("\t{0} utiliza sus {1} apéndices para caminar y sus {2} alas para volar", this.nombre_cientifico, this.numero_apendices, this.numero_alas);
        }
        public override void Alimentarse()
        {
            Console.WriteLine("\t{0} Utiliza su glosa o lengua para alcanzar el polen de las flores.",this.nombre_cientifico);
        }
        public override void Reproducirse()
        {
            if (reina)
            {
                Console.WriteLine("\t{0} ha salido a volar con un especimen macho para reproducirse.", this.nombre_cientifico);
            }
            else
            {
                Console.WriteLine("\tSolamente las abejas reina pueden reproducirse.");
            }
        }
        public override void Defenderse()
        {
            Console.WriteLine("\t{0} utiliza su aguijón para penetrar e inyectar veneno esperando escapar del peligro.", this.nombre_cientifico);
        }
        //Destructor de la clase
        ~clsAbeja()
        {
            Console.WriteLine("\n\tMemoria liberada de la clase abeja");
        }
    }
}