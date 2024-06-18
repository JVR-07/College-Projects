using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalArea_Click(object sender, EventArgs e)
        {
            double b, h, r; // Declaracion de variables
            b = Convert.ToDouble(txtbase.Text); // Conversion de tipo cadena a tipo numerico
            h = Convert.ToDouble(txtaltura.Text); // Conversion de tipo cadena a tipo numerico 
            r = (b * h) / 2; // Proceso
            r = Math.Round(r, 2); // Redondea decimales
            resultado.Text = r.ToString(); // Muestra el resultado
            // Machado Sanchez Javier 22211600


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbase.Text = ""; // Limpia la base
            txtaltura.Text = ""; // Limpia la altura
            resultado.Text = "Esperando resultado..."; // Limpia el resultado 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close(); // Sale del programa
        }
    }
}
