using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EXAMENBU2_MachadoJavier
{
    public partial class Form2 : Form
    {
        //----------------------------------------- CAMPOS DE LA CLASE ---------------------------------------------
        private int no_empleado;
        private string nombre_completo, carrera_universitaria, nivel_estudio;
        private int row;

        private List<string> nombre_materia = new List<string>();
        private List<int> horas_materia = new List<int>();
        //----------------------------------------------------------------------------------------------------------


        //---------------------------------------- MÉTODOS DE LA CLASE ---------------------------------------------
        public Form2()
        {
            InitializeComponent();
        }

        //Evento para añadir una materia y cantidad de horas
        private void btnAnadirMateria_Click(object sender, EventArgs e)
        {
            this.row = DgvMaterias.Rows.Add();

            this.nombre_materia.Add(txtbxNombreMateria.Text);
            this.horas_materia.Add(int.Parse(txtbxHorasMateria.Text));

            DgvMaterias.Rows[this.row].Cells[0].Value = nombre_materia[this.row];
            DgvMaterias.Rows[this.row].Cells[1].Value = horas_materia[this.row];
        }
        //Evento para crear instancia de clase docente y añadirla a una lista
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.no_empleado = int.Parse(txtbxNoEmpleado.Text);
            this.nombre_completo = txtbxNombreCompleto.Text;
            this.carrera_universitaria = txtbxCarreraUniversitaria.Text;
            this.nivel_estudio = cmbxNivelEstudio.Text;

            Docente NuevoDocente = new Docente(no_empleado, nombre_completo, carrera_universitaria, nivel_estudio, nombre_materia, horas_materia);
            Form1.DocentesRegistrados.Add(NuevoDocente);

            MessageBox.Show("Docente registrado con exito, presione el botón imprimir docente para mostrarlo en pantalla", "Docente Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
