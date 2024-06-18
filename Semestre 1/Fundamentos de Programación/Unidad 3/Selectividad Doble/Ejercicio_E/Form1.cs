using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_E
{
    public partial class Form1 : Form
    {   
        public Form1()
        {InitializeComponent();}
        private void btncalcular_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            double num1, num2; // Declaracion de variable
            num1 = Convert.ToDouble(txtnum1.Text); num2 = Convert.ToDouble(txtnum2.Text);
            // Selectiva Doble
            if (num1 > num2){ // Condición para inicializar bloque de instrucciones
                MessageBox.Show(num1 + " es mayor que " + num2, "TEC TIJUANA",MessageBoxButtons.OK, MessageBoxIcon.Information);}
            else{ // inicializa el bloque de instrucciones si la condición no se cumple
                MessageBox.Show(num2 + " es mayor que " + num1, "TEC TIJUANA", MessageBoxButtons.OK, MessageBoxIcon.Information);}}
        private void btnlimpiar_Click(object sender, EventArgs e)
        {   // Limpiar datos del usuario
            txtnum1.Text = "";
            txtnum2.Text = "";}
        private void btnsalir_Click(object sender, EventArgs e)
        {   DialogResult salir; // Declaracion de variable
            // Despliegue de una caja de mensaje personalizada
            salir = MessageBox.Show("¿Está seguro de que desea salir?", "TEC TIJUANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( salir == DialogResult.Yes){
                Application.Exit();}}}} // Comando para cerrar aplicación