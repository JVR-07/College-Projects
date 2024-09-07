using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Clase_SA
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();}
        private void btncalcular_Click(object sender, EventArgs e)
        {   // Machado Sanchez Javier 22211600
            double n1, n2; // Declaracion de variables
            // Lectura de datos
            n1 = Convert.ToDouble(txtnum1.Text);
            n2 = Convert.ToDouble(txtnum2.Text);
            // Selectiva anidada
            if (n1 == n2){txtresultado.Text = "Los números ingresados son iguales";}
            else if (n1 > n2){txtresultado.Text = n1 + " es mayor que " + n2;}
            else{txtresultado.Text = n2 + " es mayor que " + n1;}}
        private void btnlimpiar_Click(object sender, EventArgs e)
        {   // Limpia datos del usuario
            txtresultado.Text = "";
            txtnum1.Text = "";
            txtnum2.Text = "";}
        private void btnsalir_Click(object sender, EventArgs e)
        {   // Comando para cerrar aplicacion
            Application.Exit();}}}