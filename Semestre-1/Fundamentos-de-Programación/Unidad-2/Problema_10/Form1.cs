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
// Problema 10 a código C# 
// ~ Convertir grados F a grados C y mostrar resultado. ~

namespace Problema_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertir_Click(object sender, EventArgs e)
        {
            double F, C; // Declaracion de variables
            F = Convert.ToDouble(txtF.Text); // Convertir a tipo Double el dato String
            C = (F - 32) / 1.8; // Proceso 
            C = Math.Round(C, 1); // Redondea a una decima 
            resultado.Text = C.ToString(); // Muestra en tipo String el resultado 
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtF.Text = ""; // Limpia los grados F
            resultado.Text = ""; // Limpia el resultado 
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close(); // Cierra el programa
        }
    }
}
