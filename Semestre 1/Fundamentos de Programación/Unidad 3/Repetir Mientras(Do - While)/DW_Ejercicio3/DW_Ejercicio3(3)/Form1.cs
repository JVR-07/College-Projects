using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_Ejercicio3
{
    public partial class frmMiforma : Form
    {
        public frmMiforma()
        {
            InitializeComponent();
        }
        private void btnMostrar_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            int Num = 198, Sum = 200;
            do{ // Ciclo Do While. Corre el bloque de instrucciones y si la condición es verdadera, lo vuelve a correr
                Num = Num + 2;Sum = Sum + Num;
                if (Num == 300){txtResultado.Text = txtResultado.Text + Num.ToString() + ". ";}
                else{txtResultado.Text = txtResultado.Text + Num.ToString() + ", ";}} 
            while (Num < 300); // Condicion. Si es verdadera, se repite el bloque de instrucciones; si no, sigue su curso
            txtResultado.Text = txtResultado.Text + "\r\n La suma de los números pares es: " + Sum.ToString();}
        private void btnSalir_Click(object sender, EventArgs e){
            DialogResult salir;
            salir = MessageBox.Show("¿Está seguro de querer salir del programa", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(salir == DialogResult.Yes){ Application.Exit(); }}}}