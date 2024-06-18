using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Machado Sanchez Javier 22211600
// Problema_8 a código C#
// ~ Mostrar al usuario únicamente tú nombre. ~

namespace Problema_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            resultado.Text = "Mi nombres es: Machado Sanchez Javier"; // Muestra en pantalla el nombre
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close(); // Finaliza el programa 
        }
    }
}
