using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();}
        private void btnprueba_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            double volt; volt = Convert.ToDouble(txtvolt.Text);
            // Selectiva Doble
            if (volt >= 600){ // Condición para inicializar bloque de instrucciones
                MessageBox.Show("Felicidades, pasó la prueba de voltaje", "CFE", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            else{ // inicializa el bloque de instrucciones si la condición no se cumple
                MessageBox.Show("Lo siento, no pasó la prueba de voltaje", "CFE", MessageBoxButtons.OK, MessageBoxIcon.Error);}}
        private void btnlimpiar_Click(object sender, EventArgs e)
        {   // Limpiar datos del usuario
            txtvolt.Text = "";}
        private void btnsalir_Click(object sender, EventArgs e)
        {   DialogResult salir; // Declaracion de variable
            // Despliegue de una caja de mensaje personalizada
            salir = MessageBox.Show("¿Quire cerrar el programa?", "CFE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes){
                Application.Exit();}}}} // Comando para cerrar aplicación