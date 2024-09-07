using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_Herencia
{
    internal class clsAracnidos : clsArtropodos
    {
        //Campos de la clase
        string patron_abdomen;
        float tamaño_apendices, tamaño_queliceros;
        bool veneno;
        //Constructor de la clase
        //Se utilizan los campos de la clase actual pero también de la clase base "clsArtropodos".
        public clsAracnidos(string nombre_cientifico, string color_general, string patron_abdomen, short numero_segmentos, short numero_apendices, float tamaño_apendices, float tamaño_queliceros ,float tamaño_total, bool hembra, bool veneno) : base(nombre_cientifico,color_general,numero_segmentos,numero_apendices,tamaño_total,hembra)
        {
            this.patron_abdomen = patron_abdomen;
            this.tamaño_apendices = tamaño_apendices;
            this.tamaño_queliceros = tamaño_queliceros;
            this.veneno = veneno;
        }
        //Métodos de la clase
        public void Morder()
        {
            if (veneno)
            {
                Console.WriteLine(this.nombre_cientifico + " ha mordido a su presa. El veneno fue inyectado.");
            }
            else 
            {
                Console.WriteLine(this.nombre_cientifico + " ha mordido a su presa. No se inyectó veneno.");
            }
        }
        public void CrearTelaraña()
        {
            Console.WriteLine(this.nombre_cientifico + " ha fabricado una telaraña con patrones geométricos");
        }
        public void Mudar()
        {
            Console.WriteLine(this.nombre_cientifico + " ha mudado su exoesqueleto.");
        }
        public void Cortejo()
        {
            this.pareja = true;
            Console.WriteLine(this.nombre_cientifico + " ha realizado la danza de cortejo exitosamente. Ha conseguido pareja.");
        }
        public void DespliegueInformacion()
        {
            Console.WriteLine("\nNombre científico: " + this.nombre_cientifico);
            Console.WriteLine("\nColor general: " + this.color_general);
            Console.WriteLine("\nPatrón del abdomen: " + this.patron_abdomen);
            Console.WriteLine("\nNúmero de segmentos: " + this.numero_segmentos);
            Console.WriteLine("\nNúmero de apéndices(patas): " + this.numero_apendices);
            Console.WriteLine("\nTamaño apéndices(patas): " + this.tamaño_apendices);
            Console.WriteLine("\nTamaño queliceros(colmillos): " + this.tamaño_queliceros);
            Console.WriteLine("\nTamaño total: " + this.tamaño_total);
            if (hembra)
            {
                Console.WriteLine("\nSexo: Hembra");
            }
            else
            {
                Console.WriteLine("\nSexo: Macho");
            }
            if (veneno)
            {
                Console.WriteLine("\nVenenosa: Sí");
            }
            else
            {
                Console.WriteLine("\nVenenosa: No");
            }
        }
        //Destructor de la clase
        ~clsAracnidos()
        {
            Console.WriteLine("Memoria liberada del objeto " + this.nombre_cientifico);
        }
    }
}