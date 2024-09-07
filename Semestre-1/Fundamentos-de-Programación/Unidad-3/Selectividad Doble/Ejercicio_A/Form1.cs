using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_A{
    public partial class Form1 : Form{
        public Form1(){InitializeComponent();}
        private void btnverificar_Click(object sender, EventArgs e){// Machado Sanchez Javier 22211600
            int cal; // Declaracion de variables
            cal = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la calificación que desea verificar","INSTITUTO TECNOLOGICO de TIJUANA","Escriba aqui...",300,400));
            // Selectividad Doble
            if(cal>=70){// Condición para inicializar bloque de instrucciones
                MessageBox.Show("Felicidades, su calificación es aprobatoria.", "INSTITUTO TECNOLOGICO de TIJUANA", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            else{ // inicializa el bloque de instrucciones si la condición no se cumple
                MessageBox.Show("Lo siento mucho, su califación no es aprobatoria","INSTITUTO TECNOLOGICO de TIJUANA", MessageBoxButtons.OK,MessageBoxIcon.Error);}}
        private void btnclose_Click(object sender, EventArgs e){
            DialogResult close; // Declaracion de variable
            //Proceso para pedir confirmación al cerrar el programa
            close = MessageBox.Show("¿Está seguro que quieres salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(close == DialogResult.Yes)
            {   // Comando para cerrar aplicación
                Application.Exit();}}}}