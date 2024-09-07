using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Ejercicio1
{
    public partial class frmMiforma : Form
    {
        public frmMiforma()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e) { //Machado Sanchez Javier 22211600
            btnMostrar.Enabled = false;
            txtaviso.Text = "El proceso ha iniciado con éxito";
            int NumT, resultado; 
            try {NumT = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la tabla de múltiplicar que desea mostrar", "CAPTURADOR DE DATOS", "", 855, 475));
                for (int i = 0; i <= 10; i++) // Ciclo for, se repite mientras la condición sea verdadera. Este ciclo, permite inicializar una variable,
                { resultado = NumT * i;    // poner una condición e incluso llevar un contador de vueltas, todo dentro de la misma estructura del ciclo.
                    txtResultado.Text = txtResultado.Text + NumT + " * " + i + " = " + resultado + "\r\n";
                } txtaviso.Text = "El proceso ha finalizado con éxito. Si desea cálcular otra tabla, limpie el programa"; }
            catch(FormatException){ MessageBox.Show("Ingrese un dato válido, por favor", "ERROR DE FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaviso.Text = "El proceso se ha detenido, cierre el programa o limpielo para continuar.";} }
        private void btnClear_Click(object sender, EventArgs e)
        {txtResultado.Clear();
            txtaviso.Text = "De click en \"Mostrar tabla\" para comenzar el proceso";
            btnMostrar.Enabled = true;}
        private void btnExit_Click(object sender, EventArgs e)
        { DialogResult salir;
            salir = MessageBox.Show("¿Está seguro de querer salir del programa?","EL PROGRAMA SE CERRARÁ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (salir == DialogResult.Yes) { Application.Exit();}}
        private void frmMiforma_Load(object sender, EventArgs e){this.Location = new System.Drawing.Point(425, 275);}}}