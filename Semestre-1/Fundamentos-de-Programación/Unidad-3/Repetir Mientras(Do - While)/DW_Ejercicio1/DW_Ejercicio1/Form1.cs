using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            int c = 0, MaE = 0, MeE = 0, edad;
            frmEdades LeerEdades = new frmEdades();
            btnCapturar.Enabled = false;
            try{ do{ // Ciclo Do While. Corre el bloque de instrucciones y si la condición es verdadera, lo vuelve a correr
                    if (LeerEdades.ShowDialog() == DialogResult.OK){
                        c++; edad = Convert.ToInt16(LeerEdades.txtedades.Text);
                        if (edad >= 18 && edad <= 105){MaE = MaE + 1;
                            txttotaledades.Text = txttotaledades.Text + "Edad " + c + ": " + edad + "\r\n";
                            txtMaE.Text = txtMaE.Text + "Edad " + c + ": " + edad + "\r\n";}
                        else if (edad >= 0 && edad < 18){MeE = MeE + 1;
                            txttotaledades.Text = txttotaledades.Text + "Edad " + c + ": " + edad + "\r\n";
                            txtMeE.Text = txtMeE.Text + "Edad " + c + ": " + edad + "\r\n";}
                        else{MessageBox.Show("Ingrese una edad real", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            c -= 1;}}
                    else if (LeerEdades.ShowDialog() == DialogResult.Cancel){
                        MessageBox.Show("La operación ha sido cancelada exitosamente", "OPERACIÓN CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;}
                 // Condicion. Si es verdadera, se repite el bloque de instrucciones; si no, sigue su curso
                }while(c < 10);
                txtMaE.Text = txtMaE.Text + "El número de mayores de edad es: " + MaE;
                txtMeE.Text = txtMeE.Text + "El número de menores de edad es: " + MeE;}
            catch (System.FormatException)
            {MessageBox.Show("Por favor, ingrese un número real", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
            catch (System.OverflowException)
            {MessageBox.Show("Ha sobrepasado los limites. Ingrese un número más corto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
            finally{txterror.Visible = true;
             txterror.Text = "Proceso terminado. Por favor, limpie el programa si desea reinicar la operación";}}
        private void Form1_Load(object sender, EventArgs e){}
        private void btnLimpiar_Click(object sender, EventArgs e){
            btnCapturar.Enabled = true;txterror.Visible = false;
            txttotaledades.Clear();txtMaE.Clear();txtMeE.Clear();}
        private void Salir_Click(object sender, EventArgs e){
            DialogResult salir;
            salir = MessageBox.Show("¿Está seguro de que desea salir del programa?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes){ Application.Exit(); }}}}