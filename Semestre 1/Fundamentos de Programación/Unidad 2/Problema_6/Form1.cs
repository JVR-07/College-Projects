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
// Problema #6 a código C#
// ~ El prensado de aceituna produce el 36% de su peso en aceite, calcular la cantidad de aceite de acuerdo a los kg de aceitunas producidos. ~
namespace Problema_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double kg, aceite; // Declaracion de variables 
            kg = Convert.ToDouble(txtkg.Text); // Convertir dato del usuario de tipo String a tipo Double 
            aceite = kg * 0.36; // Proceso
            aceite = Math.Round(aceite, 3); // Redondea a 3 decimales
            resultado.Text = aceite.ToString() + " Litros"; // Muestra el resultado de tipo Double en tipo String           
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close(); // Cierra el programa
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtkg.Text = ""; // Limpia los kilogramos
            resultado.Text = ""; // Limpia el resultado 
        }
    }
}
