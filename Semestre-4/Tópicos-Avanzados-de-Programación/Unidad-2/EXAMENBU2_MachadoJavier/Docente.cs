using System.Collections.Generic;

namespace EXAMENBU2_MachadoJavier
{   //Clase para crear los distintos docentes
    public class Docente
    {
        //-------------------------- BLOQUE DE CAMPOS Y CONSTRUCTOR -----------------------------
        private int no_empleado;
        private string nombre_completo, carrera_universitaria, nivel_estudio;
        private float sueldo_hora;

        private List<string> nombre_materia = new List<string>();
        private List<int> horas_materia = new List<int>();

        //Constructor de la clase
        public Docente(int no_emplado, string nombre_completo, string carrera_universitaria, string nivel_estudio,
                       List<string> nombre_materia, List<int> horas_materia)
        {
            this.no_empleado = no_emplado;
            this.nombre_completo = nombre_completo;
            this.carrera_universitaria = carrera_universitaria;
            this.nivel_estudio = nivel_estudio;
            this.nombre_materia = nombre_materia;
            this.horas_materia = horas_materia;

            //Procedimiento para definir el sueldo por hora
            switch (nivel_estudio)
            {
                case "Licenciatura": { this.sueldo_hora = 100.0f; } break;
                case "Maestría": { this.sueldo_hora = 150.0f; } break;
                case "Doctorado": { this.sueldo_hora = 200.0f; } break;
            }
        }

        //---------------------------------- BLOQUE DE MÉTODOS -----------------------------------

        public float GetSueldoTotal()
        {
            float sueldo_final = 0;

            foreach (int horas in horas_materia)
            {
                sueldo_final += this.sueldo_hora * horas;
            }
            return sueldo_final;
        }

        public int GetNoEmpleado() { return no_empleado; }
        public string GetNombreCompleto() { return nombre_completo; }
        public string GetCarreraUniversitaria() { return carrera_universitaria; }
        public string GetNivelEstudio() { return nivel_estudio; }
        public List<string> GetNombresMaterias() { return nombre_materia; }
        public List<int> GetHorasMaterias() { return horas_materia; }

    }
}
