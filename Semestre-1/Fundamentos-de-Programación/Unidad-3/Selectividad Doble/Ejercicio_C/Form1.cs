using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();}
        private void btncapturar_Click(object sender, EventArgs e){}
        private void btnverificar_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            double temp; // Declaracion de variable
            temp = Convert.ToDouble(txttemp.Text);
            // Selectividad doble
            if (temp >= 100){ // Condición para inicializar bloque de instrucciones
                MessageBox.Show("La temperatura está por arriba del punto de ebullición","PUNTO EBULLICION", MessageBoxButtons.OK, MessageBoxIcon.Stop);}
            else{ // inicializa el bloque de instrucciones si la condición no se cumple
                MessageBox.Show("La temperatura está por debajo del punto de ebullición", "PUNTO EBULLICION", MessageBoxButtons.OK, MessageBoxIcon.Information);}}
        private void btnlimpiar_Click(object sender, EventArgs e)
        {   // Limpiar datos del usuario
            txtmensaje.Text = "";
            txttemp.Text = Convert.ToString(txttemp.Text);
            txttemp.Text = "";}
        private void btnsalir_Click(object sender, EventArgs e)
        {   DialogResult salir; // Declaracion de variable
            //Proceso para pedir confirmación al cerrar el programa
            salir = MessageBox.Show("¿Quiere cerrar el programa?", "Salir del programa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (salir == DialogResult.Yes)
            {   // Comando para cerrar aplicación
                Application.Exit();}}}}