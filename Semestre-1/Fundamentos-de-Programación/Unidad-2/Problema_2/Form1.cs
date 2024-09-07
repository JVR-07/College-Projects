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
// Problema #2 a código C#
// ~ En base al valor de los catetos de un triángulo calcular la hipotenusa. ~
namespace Problema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            cata.Text = ""; // Limpia el texto de cateto a
            catb.Text = ""; // Limpia el texto de cateto b
            Resultado.Text = "Esperando resultado..."; // Limpia el resultado
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double a, b, hipo; // Declaracion de variables 
            a = Convert.ToDouble(cata.Text); // Convierte el dato tipo string del usuario a tipo double
            b = Convert.ToDouble(catb.Text); // Convierte el dato tipo string del usuario a tipo double
            hipo = Math.Pow(a, 2 ) + Math.Pow(b, 2); // Proceso
            hipo = Math.Sqrt(hipo); // Raiz cuadrada 
            hipo = Math.Round(hipo, 2); // Redondeo de decimales
            Resultado.Text = hipo.ToString(); // Resultado en tipo String
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close(); // Cierra el programa 
        }
    }
}
