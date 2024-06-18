using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Clase_SDoble
{
    public partial class Form1 : Form
    {
        public Form1()
        {InitializeComponent();}
        private void btnedad_Click(object sender, EventArgs e)
        {   // Machado Sanchez Javier 22211600
            int edad, falta; // Declaracion de varaibles
            //Proceso para pedir datos con una ventana interactiva
            edad = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese su edad", "INSTITUTO NACIONAL ELECTORAL", "Edad", 200, 200));
            // Selectiva Doble
            if (edad >= 18){  // Despliegue de una caja de mensaje personalizada
                MessageBox.Show("Felicidades, tienes " + edad + " años, eres mayor de edad.", "INSTITUTO NACIONAL ELECTORAL", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            else{   // Despliegue de una caja de mensaje personalizada
                falta = 18 - edad;
                MessageBox.Show("Lo siento, tienes " + edad + " años, Vuelve en " + falta + " años.", "INSTITUTO NACIONAL ELECTORAL", MessageBoxButtons.OK, MessageBoxIcon.Error);}}
        private void btnsalir_Click(object sender, EventArgs e)
        {   DialogResult salir; // Declaracion de variable
            //Proceso para pedir confirmación al cerrar el programa
            salir = MessageBox.Show("¿Está seguro de querer salir?", "INSTITUTO NACIONAL ELECTORAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {   // Comando para cerrar aplicación
                Application.Exit();}}}}