using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_ClaseAbstracta
{   //Declaración de clase derivada cuenta gold
    internal class clsCuentaGold : clsCuentaBancaria
    {
        //Declaración de constructor
        public clsCuentaGold(string nombre_cuenta, string direccion_cuenta,
                                 long numero_telefonico_cuenta, float saldo_inicial_cuenta) :
                                 base(nombre_cuenta, direccion_cuenta, numero_telefonico_cuenta, saldo_inicial_cuenta)
        {
            base.utilidad_anual_cuenta = 1.06f;
        }
        //Definición de métodos abstractos heredados
        public override void AbrirCuenta()
        {
            if (base.status_cuenta)
            {
                Console.WriteLine("\tYa se ha creado una cuenta con esas características.");
            }
            else
            {
                base.saldo_cuenta = base.saldo_inicial_cuenta * 1.15f;
                Console.WriteLine("\tLa cuenta ha sido creada exitosamente. El saldo inicial con el bono del 15% es de: {0:C}", this.saldo_cuenta);
                base.status_cuenta = true;
                base.cuenta_gold = true;
            }
        }
        public override void CalcularUtilidad()
        {
            float utilidad;
            utilidad = base.saldo_cuenta * base.utilidad_anual_cuenta;
            Console.WriteLine("\tSu cuenta tiene una utilidad anual del 1% y su saldo actual es de {0:C}", base.saldo_cuenta);
            Console.WriteLine("\tPor lo tanto, al terminar el año su saldo será de {0:C}", utilidad);
        }
        //Declaración de destructor
        ~clsCuentaGold()
        {
            Console.WriteLine("\n\tMemoria liberada del objeto cuenta gold " + base.nombre_cuenta);
        }
    }
}