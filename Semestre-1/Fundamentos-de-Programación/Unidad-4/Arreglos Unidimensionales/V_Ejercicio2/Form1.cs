using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Ejercicio2
{
    public partial class frmMain : Form
    {  // Machado Sanchez Javier. 22211600
        int[] numeros = new int[10]; // Declaración de array con capaciadad para 10 datos tipo int.
                                     // Se hizo la declaración global para poder utilizarlo en múltiples botones
        public frmMain(){InitializeComponent();}
        private void frmMain_Load(object sender, EventArgs e){}
        private void btnIngresar_Click(object sender, EventArgs e){
            btnIngresar.Enabled = false;
            try
            {
                for (int i = 0; i < numeros.Length; i++){   // Ciclo básico para registar y mostrar datos del usuario
                    numeros[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el dato " + (i + 1), "CAPTURADOR DE DATOS C#"));
                    txtNumeros.Text = txtNumeros.Text + numeros[i] + "\r\n";}
                MessageBox.Show("Los datos han sido registrados correctamente", "DATA LOGGER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException){
                MessageBox.Show("Ingrese un dato válido, por favor", "ERROR DETECTADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("El proceso se ha detenido. Limpie o cierre el programa", "MENSAJE FINAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }}
        private void btnInvertir_Click(object sender, EventArgs e){
            btnInvertir.Enabled = false;
            int temp;
            for (int i = 0; i < 10; i++)         // Doble bucle para invertir el array. El segundo bucle, se encarga de comparar la posicion que indique el
            {                                    // contador J, respecto a una posicion anterior(J - 1). Intercambia los números.
                for (int j = 9; j > i; j--)      //El bucle anterior, solo invierte el ultimo número del array, por lo que está dentro de otro bucle que repite
                {                                // el ciclo dependiendo la cantidad de datos del array, lo que permite invertir todas las posiciones
                    temp = numeros[j];
                    numeros[j] = numeros[j - 1];
                    numeros[j - 1] = temp;
                }}
            for (int i = 0; i < numeros.Length; i++){   // Ciclo básico para mostrar el array
                txtResultado.Text = txtResultado.Text + numeros[i] + "\r\n";}
            MessageBox.Show("El proceso ha terminado exitosamente. Limpie o cierre el programa", "MENSAJE FINAL", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        private void btnClear_Click(object sender, EventArgs e){
            DialogResult confirm; confirm = MessageBox.Show("¿Desea limpiar el programa? Todo el proceso se reiniciará", "ESPERANDO CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(DialogResult.Yes == confirm)
           {    txtResultado.Clear();
                txtNumeros.Clear();
                btnIngresar.Enabled = true;
                btnInvertir.Enabled = true;
                MessageBox.Show("El programa se ha limpiado correctamente", "PROGRAMA LIMPIADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
            else{MessageBox.Show("La limpieza ha sido cancelada exitosamente", "LIMPIEZA CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);}}
        private void btnExit_Click(object sender, EventArgs e){
            DialogResult exit; exit = MessageBox.Show("¿Desea salir del programa? Todo el proceso se perderá", "ESPERANDO CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit == DialogResult.Yes) { Application.Exit(); }
            else { MessageBox.Show("La salida del programa ha sido cancelada exitosamente", "SALIDA CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Warning); }}}}