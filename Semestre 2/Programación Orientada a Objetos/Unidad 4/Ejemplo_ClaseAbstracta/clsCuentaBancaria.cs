using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_ClaseAbstracta
{   //Declaración de clase base abstracta
    internal abstract class clsCuentaBancaria
    {
        //Declaración de campos 
        protected string nombre_cuenta, direccion_cuenta;
        protected long numero_telefono_cuenta;
        protected float saldo_cuenta, saldo_inicial_cuenta, utilidad_anual_cuenta;
        protected bool status_cuenta, cuenta_gold;
        //Declaración de constructor
        public clsCuentaBancaria(string nombre_cuenta, string direccion_cuenta,
                                 long numero_cuenta, float saldo_inicial_cuenta)
        {
            this.nombre_cuenta = nombre_cuenta;
            this.direccion_cuenta = direccion_cuenta;
            this.numero_telefono_cuenta = numero_cuenta;
            this.saldo_cuenta = 0.0f;
            this.saldo_inicial_cuenta = saldo_inicial_cuenta;
            this.status_cuenta = false;
            this.cuenta_gold = false;
        }
        //Declaración de métodos abstractos
        public abstract void AbrirCuenta();
        public abstract void CalcularUtilidad();
        //Declaración de métodos 
        public void Retirar(float cantidad)
        {
            this.saldo_cuenta -= cantidad;
            Console.WriteLine("\tSe han retirado {0:C} de la cuenta bancaria de nombre {1}.\n\tEl saldo actual de la cuenta es de: {2:C}",cantidad,this.nombre_cuenta,this.saldo_cuenta);
        }
        public void Depositar(float cantidad) 
        {
            this.saldo_cuenta += cantidad;
            Console.WriteLine("\tSe han depositado {0:C} de la cuenta bancaria de nombre {1}.\n\tEl saldo actual de la cuenta es de: {2:C}", cantidad, this.nombre_cuenta, this.saldo_cuenta);
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("\tNombre de la cuenta: {0}\n\tDirección: {1}\n\tNúmero telefónico asociado a esta cuenta: {2}",this.nombre_cuenta,this.direccion_cuenta,this.numero_telefono_cuenta);
            Console.WriteLine("\tSaldo de la cuenta: {0:C}",this.saldo_cuenta);
            if (this.status_cuenta && this.cuenta_gold)
            {
                Console.WriteLine("\tEstado de cuenta: Gold Activa");
            }
            else if (this.status_cuenta && (this.cuenta_gold == false))
            {
                Console.WriteLine("\tEstado de cuenta: Regular Activa");
            }
            else if(this.status_cuenta == false)
            {
                Console.WriteLine("\tEstado de cuenta: Inactiva");
            }
        }
    }
}