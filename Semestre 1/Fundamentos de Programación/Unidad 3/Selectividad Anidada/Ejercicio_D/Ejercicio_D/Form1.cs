using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e){
            this.Location = new System.Drawing.Point(500, 500);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;}
        private void button1_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            int ang; ang = Convert.ToInt32(txtang.Text);
            // Primer bloque de instrucciones. Se inicia cuando se cumple la condición 
            if (ang == 0 || ang == 90 || ang == 180 || ang == 270 || ang == 360) { txtresult.Text = "El ángulo " + ang + " no pertenece a ningún cuadrante, sino a un eje."; }
            // Los demas bloques de instrucciones. Se inician cuando se cumple alguna de las condiciones
            else if (ang > 90 && ang < 180) { txtresult.Text = "El ángulo " + ang + " pertenece al cuadrante II"; }
            else if (ang > 180 && ang < 270) { txtresult.Text = "El ángulo " + ang + " pertenece al cuadrante III"; }
            else if (ang > 270 && ang < 360) { txtresult.Text = "El ángulo " + ang + " pertenece al cuadrante IV"; }
            else if (ang > 0 && ang < 90) { txtresult.Text = "El ángulo " + ang + " pertenece al cuadrante I"; }
            // Bloque de instrucción por si no se cumple ningúna condición
            else{txtresult.Text = "El ángulo " + ang + " no existe.";}}
        private void btnlimpiar_Click(object sender, EventArgs e){
            txtang.Text = "Aquí aparecerá el ángulo ingresado";
            txtresult.Text = "Aquí aparecerá el cuadrante correspondiente";}
        private void btnang_Click(object sender, EventArgs e){
            txtang.Text = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ángulo del eje positivo de X", "TECNOLOGICO NACIONAL DE MEXICO", "", 200, 200);}
        private void btnsalir_Click(object sender, EventArgs e){ Application.Exit(); }}}