using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mostrar_Frase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            resultado.Text = frase.Text; // Muestra el texto de la Textbox en el Label del resultado
            // Machado Sanchez Javier 22211600
        }
    }
}
