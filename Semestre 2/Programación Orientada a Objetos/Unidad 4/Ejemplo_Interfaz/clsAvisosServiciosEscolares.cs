using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Interfaz
{
    internal class clsAvisosServiciosEscolares : clsAvisosEscolares, IAvisos
    {   
        //Declaración de campos
        private string mensaje, nombre_remitente, fecha;

        //Declaración de métodos de interfaz
        public void MostrarAviso()
        {
            if (base.alumno_es_hombre)
            {
                Console.WriteLine("Estimado Alumno {0}, con número de control {1}," +
                                  "\nse hace entrega del siguiente mensaje: " +
                                  "\n\"{2}\"" +
                                  "\nEnviado por {3} el día {4}", base.nombre_alumno, base.numero_control_alumno, this.mensaje, this.nombre_remitente, this.fecha);
            }
            else
            {
                Console.WriteLine("Estimada Alumna {0}, con clave única de registro de población {1}," +
                                  "\nse hace entrega del siguiente mensaje: " +
                                  "\n\"{2}\"" +
                                  "\nEnviado por {3} el día {4}", base.nombre_alumno, base.numero_control_alumno, this.mensaje, this.nombre_remitente, this.fecha);
            }
        }
        
        //Declaración de métodos abstractos de clase base
        public override void CancelarClases(string fecha)
        {
            if (alumno_es_hombre)
            {
                Console.WriteLine("Estimado {0}, se le informa que siguiendo las indicaciones de" +
                                  "\nprotección civil, se suspenden clases para todos los niveles" +
                                  "\neducativos el día de mañana {1}"+
                                  "\nEnviado por {2} el día {3}", base.nombre_alumno, fecha, this.nombre_remitente, this.fecha);
            }
            else
            {
                Console.WriteLine("Estimada {0}, se le informa que siguiendo las indicaciones de" +
                                  "\nprotección civil, se suspenden clases para todos los niveles" +
                                  "\neducativos el día de mañana {1}" +
                                  "\nEnviado por {2} el día {3}", base.nombre_alumno, fecha, this.nombre_remitente, this.fecha);
            }
        }

        //Declaración de métodos de clase derivada
        public void EntregaCredenciales()
        {
            if (base.alumno_es_hombre)
            {
                Console.WriteLine("Estimado Alumno {0}, con número de control {1}," +
                                  "\nse hace entrega del siguiente mensaje: " +
                                  "\n\"{2}\"" +
                                  "\nEnviado por {3} el día {4}", base.nombre_alumno, base.numero_control_alumno, this.mensaje, this.nombre_remitente, this.fecha);
            }
            else
            {
                Console.WriteLine("Estimada Alumna {0}, con clave única de registro de población {1}," +
                                  "\nse hace entrega del siguiente mensaje: " +
                                  "\n\"{2}\"" +
                                  "\nEnviado por {3} el día {4}", base.nombre_alumno, base.numero_control_alumno, this.mensaje, this.nombre_remitente, this.fecha);
            }
        }

        //Constructores y destructores
        public clsAvisosServiciosEscolares(string mensaje, string fecha, // Parametros clase derivada
                                           string nombre_alumno, int numero_control_alumno, bool alumno_es_hombre) : // Parametros clase base
                                      base(nombre_alumno, numero_control_alumno, alumno_es_hombre)
        {
            this.nombre_remitente = "INSTITUTO TECNOLÓGICO DE TIJUANA(ITT)";
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        ~clsAvisosServiciosEscolares()
        {
            Console.WriteLine("Memoria liberada del objeto ServiciosEscolares " + this.nombre_alumno);
        }
    }
}