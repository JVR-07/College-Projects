using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Excepciones
{
    // Declaración de la clase
    internal class Computadora
    {
        // atributos
        private int _tamañoGB; // privado para que el usuario no pueda modificar el tamaño de los GB que ingresa o elimina.
        private int _tamañoMaxGB; // privado para que solo los métodos de la clase puedan modificar el tamaño máximo del disco
        private bool _powerButton; // publico para que el usuario pueda modificar el estado de la computadora

        //Constructor de la clase
        public Computadora(int _tamañoMaxGB)
        {
            this._tamañoGB = 0;
            this._powerButton = false;
            if (_tamañoMaxGB <= 0)
            {
                this._tamañoMaxGB = 250;
            }
            else
            {
                this._tamañoMaxGB = _tamañoMaxGB;
            }
        }
        //Declaración de todos los métodos
        public void añadirDatos(int datos)
        {
            if (this._powerButton)
            {
                if (datos < 0)
                {
                    Console.WriteLine("\tLos GB no pueden ser negativos");
                }
                else
                {
                    if (this._tamañoGB + datos >= this._tamañoMaxGB)
                    {
                        this._tamañoGB = this._tamañoMaxGB;
                        Console.WriteLine("\tEl disco se ha llenado. Ahora el disco tiene un total de {0} GB usados.", this._tamañoGB);
                    }
                    else
                    {
                        this._tamañoGB += datos;
                        Console.WriteLine("\tSe han añadido {0} GB. Ahora el disco tiene un total de {1} GB usados.", datos, this._tamañoGB);
                    }
                }
            }
            else
            {
                Console.WriteLine("\tLa computadora debe estar encendida.");
            }
        }
        public void eliminarDatos(int datos)
        {
            if (this._powerButton)
            {
                if (datos < 0)
                {
                    Console.WriteLine("\tLos GB no pueden ser negativos");
                }
                else
                {
                    if (this._tamañoGB - datos <= 0)
                    {
                        this._tamañoGB = 0;
                        Console.WriteLine("\tEl disco está vacio. Ahora el disco tiene un total de {0} GB usados.", this._tamañoGB);
                    }
                    else
                    {
                        this._tamañoGB -= datos;
                        Console.WriteLine("\tSe han eliminado {0} GB. Ahora el disco tiene un total de {1} GB usados.", datos, this._tamañoGB);
                    }
                }
            }
            else
            {
                Console.WriteLine("\tLa computadora debe estar encendida.");
            }
        }
        public void encender()
        {
            this._powerButton = true;
        }
        public void apagar()
        {
            this._powerButton = false;
        }
        //Declaración de propiedad para obtener valor de campo privado sin necesidad de modificar su acceso directamente.
        public bool PpowerButton
        {
            get { return this._powerButton; }
        }

        public int GetTamañoGB()
        {
            return this._tamañoGB;
        }

        public int GetTamañoMaxGB()
        {
            return _tamañoMaxGB;
        }
        //Destructor de la clase
        ~Computadora()
        {
            Console.WriteLine("\n\tSe ha borrado la clase y la memoria ha sido liberada.");

        }
    }
}   