using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_G
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btngen_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            string gen; // Declaracion de variable
            gen = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la instruccion para el generador", "EMPRESA PEQUEÑA", "Ingrese el comando aqui", 200, 200);
            btngen.Text = gen;}
        private void btnrun_Click(object sender, EventArgs e)
        {   string gen; gen = btngen.Text;
            // Selectiva Doble
            if (gen == "S"){ // Condición para inicializar bloque de instrucciones
                MessageBox.Show("Se puso en marcha el generador pequeño", "EMPRESA PEQUEÑA", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            else{ // inicializa el bloque de instrucciones si la condición no se cumple
                MessageBox.Show("Se puso en marcha el generador grande", "EMPRESA PEQUEÑA", MessageBoxButtons.OK, MessageBoxIcon.Information);}}
        private void btnlimpiar_Click(object sender, EventArgs e){
            btngen.Text = "Instrucción para el generador";
            MessageBox.Show("Se ha limpiado la instrucción del generador","EMPRESA PEQUEÑA",MessageBoxButtons.OK, MessageBoxIcon.Information);}
        private void btnsalir_Click(object sender, EventArgs e)
        {   DialogResult salir; // Declaracion de variable
            salir = MessageBox.Show("¿Desea salir del programa?", "EMPRESA PEQUEÑA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes){ Application.Exit(); }}}}