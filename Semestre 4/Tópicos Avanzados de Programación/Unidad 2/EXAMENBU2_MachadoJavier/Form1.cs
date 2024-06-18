using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EXAMENBU2_MachadoJavier
{
    public partial class Form1 : Form
    {
        //-------------------------------------- PARAMETROS DE LA CLASE ------------------------------------------
        public static List<Docente> DocentesRegistrados = new List<Docente>();
        private int row;
        //--------------------------------------------------------------------------------------------------------

        //------------------------------------------- MÉTODOS ---------------------------------------------------
        
        //Evento Bótón Imprimir Docentes
        private void btnImprimirDocentes_Click(object sender, EventArgs e)
        {
            string materias_aux = "", horas_aux = ""; //Variables auxiliares

            row = DgvTablaDocentes.Rows.Add(); //Obteniendo número de filas

            Docente docente = DocentesRegistrados[row]; //Instancia de clase docente

            DgvTablaDocentes.Rows[row].Cells[0].Value = docente.GetNoEmpleado();
            DgvTablaDocentes.Rows[row].Cells[1].Value = docente.GetNombreCompleto();
            DgvTablaDocentes.Rows[row].Cells[2].Value = docente.GetCarreraUniversitaria();
            DgvTablaDocentes.Rows[row].Cells[3].Value = docente.GetNivelEstudio();

            //------------------------------------------------------------------------------------------------------
            //Foreach para imprimir tanto el nombre de las materias como las horas
            foreach (string materia in docente.GetNombresMaterias())
            {
                materias_aux += $"{materia}\r\n";
            }

            DgvTablaDocentes.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True; //Propiedad para permitir multilinea
            DgvTablaDocentes.Rows[row].Cells[4].Value = materias_aux;

            foreach (int horas in docente.GetHorasMaterias())
            {
                horas_aux += $"{horas}\r\n";
            }

            DgvTablaDocentes.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True; //Propiedad para permitir multilinea
            DgvTablaDocentes.Rows[row].Cells[5].Value = horas_aux;
            
            //------------------------------------------------------------------------------------------------------
            
            DgvTablaDocentes.Rows[row].Cells[6].Value = docente.GetSueldoTotal();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnadirDocente_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}
