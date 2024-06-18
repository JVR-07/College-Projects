using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Ejercicio2
{
    public partial class frmMiforma : Form
    {
        public frmMiforma()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e) { // Machado Sanchez Javier 22211600
            int age, MaE = 0, MeE = 0, TMaE = 0, TMeE = 0; btnIngresar.Enabled = false;
            /* El Ciclo For, se repite mientras la condición sea verdadera. Este ciclo, permite inicializar una variable,poner una condición 
               e incluso llevar un contador de vueltas, todo dentro de la misma estructura del ciclo.*/
            try{for (int i = 1; i <= 15; i++){ 
             age = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la edad", "REGISTRADOR", "", 200, 200));
              if (age >= 0 && age <= 105){txtResultado.Text = txtResultado.Text + i + ". " + age + "\r\n";
                     if (age < 18){MeE++;TMeE++; txtResultado3.Text = txtResultado3.Text + TMeE + ". " + age + "\r\n";}
                     else{MaE++;TMaE++; txtResultado2.Text = txtResultado2.Text + TMaE + ". " + age + "\r\n";}}
              else{MessageBox.Show("Ingrese una edad real, por favor", "NADA DE BROMAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);i--;}}
            txtResultado2.Text = txtResultado2.Text + "El total de Mayores de edad es: " + TMaE;
            txtResultado3.Text = txtResultado3.Text + "El total de Menores de edad es: " + TMeE;
            txtaviso.Visible = true;txtaviso.Text = "El proceso ha terminado exitosamente";}
            catch(FormatException) { MessageBox.Show("Ingrese una dato válido", "ERROR DE FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaviso.Visible = true;txtaviso.Text = "El proceso se ha detenido. Por favor reinicie o cierre el programa";}} 
        private void btnLimpiar_Click(object sender, EventArgs e)
        {txtResultado.Clear();txtResultado2.Clear();txtResultado3.Clear();
         btnIngresar.Enabled = true; txtaviso.Visible = false;}
        private void btnSalir_Click(object sender, EventArgs e)
        {   DialogResult salir;
            salir = MessageBox.Show("El programa se cerrará. ¿Desea salir?", "CLOSE WINDOW", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(salir == DialogResult.Yes) { Application.Exit(); }}}}