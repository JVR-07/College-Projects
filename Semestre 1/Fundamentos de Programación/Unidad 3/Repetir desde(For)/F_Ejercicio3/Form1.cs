using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_Ejercicio3
{
    public partial class frmMiforma : Form
    {
        public frmMiforma(){InitializeComponent();}
        private void btnIngresar_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            int Num,SumPares = 0, SumImpares = 0, cP = 0, cI = 0;
            bool par = false;
            /* Ciclo for, se repite mientras la condición sea verdadera. Este ciclo, permite inicializar una variable, poner una condición 
               e incluso llevar un contador de vueltas, todo dentro de la misma estructura del ciclo.*/
            try{for (int i = 0; i < 10; i++){btnIngresar.Enabled = false;
                Num = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un número entero positivo", "TEC TIJUANA", "", 200, 200));
                if (Num % 2 == 0){par = true;}
                else{par = false;}
                if (par == true){ SumPares += Num; cP++;}
                else if (par == false){ SumImpares += Num; cI++;}}
                SumImpares = SumImpares / cI;
                txtResult.Text = "La suma de los pares es: " + SumPares + "\r\nEl numero total de pares es: " + cP + "\r\nLa media aritmética de los impares es: " + SumImpares;}
            catch (FormatException){
                MessageBox.Show("Por favor, ingrese un número válido", "ERROR DE FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "Proceso finalizado";}
            catch(DivideByZeroException){ MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "Proceso finalizado";}}
        private void btnClear_Click(object sender, EventArgs e)
        {txtResult.Clear(); btnIngresar.Enabled = true; 
        MessageBox.Show("El programa se ha limpiado exitosamente.", "Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        private void btnExit_Click(object sender, EventArgs e){  
           DialogResult salir;
           salir = MessageBox.Show("¿Está seguro de querer salir del programa?", "TEC TIJUANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (salir == DialogResult.Yes) { Application.Exit();}}}}