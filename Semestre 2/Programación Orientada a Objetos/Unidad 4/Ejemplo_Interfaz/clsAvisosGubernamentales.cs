using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Interfaz
{
    internal abstract class clsAvisosGubernamentales
    {
        //Campos de la clase
        protected string nombre_destinatario, curp_destinatario, firma_electronica;
        protected bool sexo_masculino;
        
        //Métodos de la clase
        public abstract void FirmaRecibido(string firma_electronica); 

        //Declaración de constructores
        public clsAvisosGubernamentales(string nombre_destinatario, string curp_destinatario, bool sexo_masculino)
        {
            this.nombre_destinatario = nombre_destinatario;
            this.curp_destinatario = curp_destinatario;
            this.sexo_masculino = sexo_masculino;
        }
    }
}