using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertir_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
                                                                  // Inicialización de selectiva intenta
            try{ // Operación que se desea realizar 
                double F, C;
                F = Convert.ToDouble(txtF.Text); C = (F - 32) / 1.8; C = Math.Round(C, 1); resultado.Text = C.ToString();}
            catch (System.FormatException){ // Mensaje en caso de no poder ejercutarse la acción
                MessageBox.Show("Ingrese un dato válido, por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}}
        private void limpiar_Click(object sender, EventArgs e){ txtF.Text = ""; resultado.Text = "Esperando resultado...";}
        private void salir_Click(object sender, EventArgs e){ Application.Exit(); }}}