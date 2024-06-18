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
    public partial class frmFormaC : Form
    {
        public frmFormaC()
        {
            InitializeComponent();
        }
        private void btnname_Click(object sender, EventArgs e){ 
            txtname.Text = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su nombre completo", "TECTIJUANA", "", 200, 200);}
        private void btnedad_Click(object sender, EventArgs e){
            txtage.Text = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su edad", "TECTIJUANA", "", 200, 200);}
        private void btnresultado_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600            
            String name, cat; int age;            
            name = txtname.Text; age = Convert.ToInt16(txtage.Text);
            // Inicio de selectiva anidada
            // Primer bloque de instrucciones. Se inicia cuando se cumple la condición
            if (age < 15){txtresult.Text = name + ", no aplicas para participar en el evento, tu edad es: " + age + " y no pertenece a ninguna categoría";}
            // Los demas bloques de instrucciones. Se inician cuando se cumple alguna de las condiciones
            else if (age >= 15 && age <= 20){cat = "A";
                txtresult.Text = name + ", aplicas para participar en el evento, tu edad es: " + age + " y perteneces a la categoría " + cat;}
            else if (age > 20 && age <= 25){cat = "B";
                txtresult.Text = name + ", aplicas para participar en el evento, tu edad es: " + age + " y perteneces a la categoría " + cat;}
            else if (age > 25 && age <= 45){cat = "C";
                txtresult.Text = name + ", aplicas para participar en el evento, tu edad es: " + age + " y perteneces a la categoría " + cat;}
            // Bloque de instrucción por si no se cumple ningúna condición
            else { txtresult.Text = name + ", no aplicas para participar en el evento, tu edad es: " + age + " y no pertenece a ninguna categoría";}}
        private void btnlimpiar_Click(object sender, EventArgs e){
            txtname.Text = "Aquí aparecerá el nombre";
            txtage.Text = "Aquí aparecerá la edad";
            txtresult.Text = "Aquí aparecerá el resultado";}
        private void btnsalir_Click(object sender, EventArgs e){ Application.Exit(); }
        private void frmFormaC_Load(object sender, EventArgs e){
            this.Location = new System.Drawing.Point(300, 300);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.WindowState = FormWindowState.Minimized;}}}