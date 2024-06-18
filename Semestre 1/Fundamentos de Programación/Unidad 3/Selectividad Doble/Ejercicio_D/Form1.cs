using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Ejercicio_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();}
        private void btnnumero_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            double num; // Declaracion de variable
            num = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número que desea verificar", "VERIFICADOR DE NUMEROS", "", 200, 200));
            txtnum.Text = "Número capturado exitosamente";
            txtnum.Visible = true;
            btnnumero.Text = Convert.ToString(num);}
        private void btnverificar_Click(object sender, EventArgs e)
        {   double num; // Declaracion de variable
            num = Convert.ToDouble(btnnumero.Text); num = num % 2;
            // Selectiva Doble
            if (num == 0){ // Condición para inicializar bloque de instrucciones
                MessageBox.Show("El número es par", "INSTITUTO TECNOLOGICO DE TIJUANA", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            else{ // inicializa el bloque de instrucciones si la condición no se cumple
                MessageBox.Show("El número es impar", "INSTITUTO TECNOLOGICO DE TIJUANA", MessageBoxButtons.OK, MessageBoxIcon.Error);}}
        private void btnlimpiar_Click(object sender, EventArgs e)
        {   // Limpiar datos del usuario 
            btnnumero.Text = "Ingresar número";
            MessageBox.Show("Programa limpiado exitosamente", "INSTITUTO TECNOLOGICO DE TIJUANA", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
        private void btnsalir_Click(object sender, EventArgs e)
        {   DialogResult salir; // Declaracion de variable
            salir = MessageBox.Show("¿Desea cerrar el programa?", "INSTITUTO TECNOLOGICO DE TIJUANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes){   // Comando para cerrar aplicación
               Application.Exit();}}}}