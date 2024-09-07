using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_A
{
    public partial class Form1 : Form
    {
        public Form1(){InitializeComponent();}
        private void btnnum_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            txtnum.Text = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número que desea determinar", "INSTITUTO TECNOLOGICO DE TIJUANA", "", 200, 200);}
        private void btndeterminar_Click(object sender, EventArgs e)
        {   double num; num = Convert.ToDouble(txtnum.Text);
            // Inicio de selectiva anidada
            if(num == 0) // Primer bloque de instrucciones. Se inicia cuando se cumple la condición
            {txtresultado.Text = num + " es un número neutro.";}
            else if(num > 0) // Segundo bloque de instrucciones. Se inicia cuando se cumple la condición
            {txtresultado.Text = num + " es un número positivo";}
            else{txtresultado.Text = num + " es un número negativo";}} // Bloque de instrucción por si no se cumple ningúna condición
        private void btnLimpiar_Click(object sender, EventArgs e){
            txtnum.Text = "Esperando número..."; txtresultado.Text = "El resultado aparecerá aquí";}
        private void btnsalir_Click(object sender, EventArgs e){ Application.Exit(); }
        private void Form1_Load(object sender, EventArgs e)
        {   // Personalizar forma 
            this.Location = new System.Drawing.Point(400, 300);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.WindowState = FormWindowState.Minimized;}}}