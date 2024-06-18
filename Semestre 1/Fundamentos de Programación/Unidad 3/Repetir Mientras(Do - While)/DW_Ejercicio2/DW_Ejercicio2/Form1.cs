using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_Ejercicio2
{
    public partial class frmprimera : Form
    {
        public frmprimera()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e){}
        private void btnCalcular_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            btnCalcular.Enabled = false;
            ulong num, numfac, resultado;
            frmNum capturarnumero = new frmNum(); 
            try{if (capturarnumero.ShowDialog() == DialogResult.OK){
                    num = Convert.ToUInt64(capturarnumero.txtnum.Text);
                    resultado = num;numfac = num - 1;
                    do{ // Ciclo Do While. Corre el bloque de instrucciones y si la condición es verdadera, lo vuelve a correr
                    if (num >= 0){
                        resultado = resultado * numfac;
                        numfac = numfac - 1;}
                        // Condicion. Si es verdadera, se repite el bloque de instrucciones; si no, sigue su curso
                    } while (numfac > 1);
                    txtresultado.Text = "El factorial de " + num + " es: " + resultado + "\r\n";}
                else if (capturarnumero.ShowDialog() == DialogResult.Cancel)
                {txtresultado.Text = "La operacion ha sido cancelada.\r\n";}}
            catch(FormatException)
            {MessageBox.Show("Por favor, ingrese un número.","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtresultado.Text = "El proceso ha finalizado exitosamente.\r";}
            catch (OverflowException)
            {MessageBox.Show("Por favor, ingrese un número entero positivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtresultado.Text = "El proceso ha finalizado exitosamente.\r";}}
        private void btnlimpiar_Click(object sender, EventArgs e){
            txtresultado.Clear();btnCalcular.Enabled = true;}
        private void btnsalir_Click(object sender, EventArgs e){
            DialogResult salir;
            salir = MessageBox.Show("¿Está seguro de querer cerrar el programa?", "CERRAR PROGRAMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(salir == DialogResult.Yes){ Application.Exit(); }}}}