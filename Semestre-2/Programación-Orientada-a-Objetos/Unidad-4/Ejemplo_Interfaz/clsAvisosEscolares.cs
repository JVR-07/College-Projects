using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Interfaz
{
    internal abstract class clsAvisosEscolares
    {
        //Campos de la clase
        protected string nombre_alumno;
        protected int numero_control_alumno;
        protected bool alumno_es_hombre;

        //Métodos de la clase
        public abstract void CancelarClases(string fecha);

        //Declaración de constructores
        public clsAvisosEscolares(string nombre_alumno, int numero_control_alumno, bool alumno_es_hombre)
        {
            this.nombre_alumno = nombre_alumno;
            this.numero_control_alumno = numero_control_alumno;
            this.alumno_es_hombre = alumno_es_hombre;
        }
    }
}