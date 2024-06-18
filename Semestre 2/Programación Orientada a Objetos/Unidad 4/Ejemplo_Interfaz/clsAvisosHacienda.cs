using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Interfaz
{
    internal class clsAvisosHacienda : clsAvisosGubernamentales, IAvisos
    {
        //Campos de la clase
        private string mensaje, nombre_remitente, rfc_destinatario, fecha;

        //Declaración de metodos de interfaz
        public void MostrarAviso()
        {
            if (base.sexo_masculino)
            {
                Console.WriteLine("Estimado Sr. {0}, con clave única de registro de población {1} y registro" +
                                  "\nfederal de contribuyentes {2}, se hace entrega del siguiente mensaje: " +
                                  "\n\"{3}\"" +
                                  "\nEnviado por {4} el día {5}", base.nombre_destinatario, base.curp_destinatario, this.rfc_destinatario, this.mensaje, this.nombre_remitente, this.fecha);
            }
            else
            {
                Console.WriteLine("Estimada Sra. {0}, con clave única de registro de población {1} y registro" +
                                  "\nfederal de contribuyentes {2}, se hace entrega del siguiente mensaje: " +
                                  "\n\"{3}\"" +
                                  "\nEnviado por {4} el día {5}", base.nombre_destinatario, base.curp_destinatario, this.rfc_destinatario, this.mensaje, this.nombre_remitente, this.fecha);
            }
        }

        //Declaración de metodos de clase base
        public override void FirmaRecibido(string firma_electronica)
        {
            base.firma_electronica = firma_electronica;
            Console.WriteLine("El aviso ha sido recibido y firmado con la siguiente cadena de texto: " + base.firma_electronica);
        }

        // Constructores y destructores de la clase
        public clsAvisosHacienda(string mensaje, string rfc_destinatario, string fecha, //Parametros clase derivada
                                string nombre_destinatario, string curp_destinatario, bool sexo_masculino) : //Parametros clase base 
                           base(nombre_destinatario, curp_destinatario, sexo_masculino)
        {
            this.nombre_remitente = "El Servicio de Administración Tributaria(SAT)";
            this.mensaje = mensaje;
            this.fecha = fecha;
            this.rfc_destinatario = rfc_destinatario;
        }

        ~clsAvisosHacienda()
        {
            Console.WriteLine("Memoria Liberada del objeto clsAvisoHacienda " + this.nombre_remitente);
        }
    }
}