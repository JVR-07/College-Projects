using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class miforma : Form
    {
        public miforma()
        {
            InitializeComponent();
        }
        private void btnname_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            txtname.Text = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su nombre completo", "TECTIJUANA", "", 200, 200);}
        private void btnedad_Click(object sender, EventArgs e){
            txtage.Text = Microsoft.VisualBasic.Interaction.InputBox("Ingrese su edad", "TECTIJUANA", "", 200, 200);}
        private void btnresultado_Click(object sender, EventArgs e){
            // Inicialización de selectiva intenta
            try
            {// Operación que se desea realizar
                string name, cat; int age; name = txtname.Text; age = Convert.ToInt16(txtage.Text);
                if(age<15){txtresult.Text=name+", no aplicas para participar en el evento, tu edad es: "+age+" y no pertenece a ninguna categoría"; }
                else if (age >= 15 && age <= 20){
                    cat = "A"; txtresult.Text = name + ", aplicas para participar en el evento, tu edad es: " + age + " y perteneces a la categoría " + cat;}
                else if (age > 20 && age <= 25){
                    cat = "B"; txtresult.Text = name + ", aplicas para participar en el evento, tu edad es: " + age + " y perteneces a la categoría " + cat;}
                else if (age > 25 && age <= 45){
                    cat = "C"; txtresult.Text = name + ", aplicas para participar en el evento, tu edad es: " + age + " y perteneces a la categoría " + cat;}
                else { txtresult.Text = name + ", no aplicas para participar en el evento, tu edad es: " + age + " y no pertenece a ninguna categoría"; }}
            catch (System.FormatException)// Mensaje en caso de no poder ejercutarse la acción
            { MessageBox.Show("Se detectó un dato con un formato incorrecto. Por favor, verifique los datos ingresados.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            catch (System.OverflowException)// Mensaje en caso de no poder ejercutarse la acción
            {MessageBox.Show("El número ingresado tiene demasiados caracteres. Por favor, ingrese una edad real.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);}}
        private void btnlimpiar_Click(object sender, EventArgs e){
            txtname.Text = "Aquí aparecerá el nombre"; txtage.Text = "Aquí aparecerá la edad"; txtresult.Text = "Aquí aparecerá el resultado";}
        private void btnsalir_Click(object sender, EventArgs e){
            DialogResult salir;
            salir = MessageBox.Show("¿Está seguro de que desea salir del programa?", "ATENCIÓN el programa se cerrará", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes){ Application.Exit(); }}
        private void miforma_Load(object sender, EventArgs e){
            this.Location = new System.Drawing.Point(400, 300);
            this.ControlBox = false;}}}