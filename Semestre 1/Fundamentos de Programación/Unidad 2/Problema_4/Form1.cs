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
// Problema #4 a código C#
// ~ Un automóvil cuya masa es de 600 kg acelera a razón de 1.2 m/s2 ¿Qué fuerza lo impulsó? Resultado en N y Dinas. ~
namespace Problema_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double n, d; // Declaracion de variables 
            n = 600 * 1.2; // Proceso
            d = n * 100000; // Proceso
            N.Text = n.ToString(); // Convertir a cadena el dato y mostrar
            D.Text = d.ToString(); // Convertir a cadena el dato y mostrar
        }
    }
}
