using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_EjemploClase1
{
    public partial class frmMiforma : Form
    {
        public frmMiforma()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            int c = 0;
            string nombre;
            frmSegunda FormaCapturar = new frmSegunda();
            btnCapturar.Enabled = false;
            do
            {
                if (FormaCapturar.ShowDialog() == DialogResult.OK)
                {

                    nombre = FormaCapturar.txtNombre.Text;
                    txtNombres.Text = txtNombres.Text + nombre + "\r\n";
                    c = c + 1;
                }
            } while (c < 5);
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            btnCapturar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
