using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Interfaz
{
    internal class clsAvisosTrafico : clsAvisosGubernamentales,IAvisos
    {
        //Campos de la clase
        private string mensaje, nombre_remitente, fecha;

        //Declaración de metodos de interfaz
        public void MostrarAviso()
        {
            if (base.sexo_masculino)
            {
                Console.WriteLine("Estimado Sr. {0}, con clave única de registro de población {1}," +
                                  "\nse hace entrega del siguiente mensaje: " +
                                  "\n\"{2}\"" +
                                  "\nEnviado por {3} el día {4}", base.nombre_destinatario, base.curp_destinatario, this.mensaje, this.nombre_remitente, this.fecha);
            }
            else
            {
                Console.WriteLine("Estimada Sra. {0}, con clave única de registro de población {1}," +
                                  "\nse hace entrega del siguiente mensaje: " + 
                                  "\n\"{2}\"" +
                                  "\nEnviado por {3} el día {4}", base.nombre_destinatario, base.curp_destinatario, this.mensaje, this.nombre_remitente, this.fecha);
            }
        }

        //Declaración de metodos de clase abstracta
        public override void FirmaRecibido(string firma_electronica)
        {
            base.firma_electronica = firma_electronica;
            Console.WriteLine("El aviso ha sido recibido y firmado con la siguiente cadena de texto: " + base.firma_electronica);
        }

        // Constructores y destructores de la clase
        public clsAvisosTrafico(string mensaje, string fecha, //Parametros clase derivada
                                string nombre_destinatario, string curp_destinatario, bool sexo_masculino) : //Parametros clase base 
                           base(nombre_destinatario, curp_destinatario, sexo_masculino)
        {
            this.nombre_remitente = "La Dirección General de Policía y Tránsito Municipal(DGPTM)";
            this.mensaje = mensaje;
            this.fecha  = fecha;
        }

        ~clsAvisosTrafico()
        {
            Console.WriteLine("Memoria Liberada del objeto clsAvisoTrafico " + this.nombre_remitente);
        }
    }
}