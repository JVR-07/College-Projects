using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Ejercicio3
{
    public partial class frmMain : Form // Machado Sanchez Javier. 22211600
    {   // Declaracion de arrays tipo int con capacidad de 20 datos
        int[] Cal1 = new int[20], Cal2 = new int[20], Prom = new int[20], Promg = new int[20];
        private void btnClear_Click(object sender, EventArgs e){
            DialogResult confirm; confirm = MessageBox.Show("¿Está seguro de querer limpiar el programa? El proceso se reiniciará", "ESPERANDO CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes){
                btnCalcular.Enabled = true; btnIngresar.Enabled = true; lblconsole.Visible = false;
                txtConsole.Visible = false;
                txtCal1.BackColor = Color.White; txtCal1.ForeColor = Color.Black;
                txtCal2.BackColor = Color.White; txtCal2.ForeColor = Color.Black;
                txtNC.Clear(); txtCal1.Clear(); txtCal2.Clear(); txtName.Clear();
                txtProm.Clear(); txtPromG.Clear(); txtConsole.Clear();
                MessageBox.Show("El programa ha sido limpiado exitosamente", "PROGRAMA LIMPIADO", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            else { MessageBox.Show("La limpieza ha sido cancelada", "LIMPIEZA CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Warning); }}
        private void btnExit_Click(object sender, EventArgs e){
            DialogResult salir; salir = MessageBox.Show("¿Está seguro que desea salir? Los datos se borrarán","ESPERANDO CONFIRMACIÓN",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(salir == DialogResult.Yes) { Application.Exit(); }}
        private void btnCalcular_Click(object sender, EventArgs e){
            btnCalcular.Enabled = false;
            int PromG = 0, i;
            for(i = 0; i < Cal1.Length; i++)      // Ciclo para calcular todos los promedios y mostrarlos
            {   Prom[i] = (Cal1[i] + Cal2[i]) / 2;
                txtProm.Text = txtProm.Text + (i + 1) + ".- " + Prom[i] + "\r\n";
                PromG = PromG + Prom[i]; }
            PromG = PromG / i;
            txtPromG.Text = PromG.ToString();
            MessageBox.Show("El proceso ha finalizado con exito", "FIN DE LA OPERACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        public frmMain(){InitializeComponent();}
        private void btnIngresar_Click(object sender, EventArgs e){
            btnIngresar.Enabled = false;
            try
            {   string[] NC = new string[20], Name = new string[20]; // Declaracion de arrays tipo string con espacio para 20 datos
                for (int i = 0; i < 20; i++) // Ciclo simple para guardar los datos ingresados en la posición de la variable <i>
                {
                    Name[i] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del estudiante " + (i + 1), "SITEC");
                    NC[i] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número de control del estudiante " + (i + 1), "SITEC");
                    Cal1[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la primer calificación del estudiante " + (i + 1), "SITEC"));
                    Cal2[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la segunda calificación del estudiante " + (i + 1), "SITEC"));
                    txtNC.Text = txtNC.Text + (i + 1) + ".- " + NC[i] + "\r\n";
                    txtName.Text = txtName.Text + (i + 1) + ".- " + Name[i] + "\r\n";
                    txtCal1.Text = txtCal1.Text + (i + 1) + ".- " + Cal1[i] + "\r\n";
                    txtCal2.Text = txtCal2.Text + (i + 1) + ".- " + Cal2[i] + "\r\n";
                }}
            catch (FormatException){
                btnCalcular.Enabled = false; lblconsole.Visible = true; txtConsole.Visible = true;
                txtCal1.BackColor = Color.DarkRed; txtCal1.ForeColor = Color.White;
                txtCal2.BackColor = Color.DarkRed; txtCal2.ForeColor = Color.White;
                txtConsole.Text = "Se ha detectado un dato inválido, por lo que el programa se ha detenido.\r\nSi desea continuar, limpie el programa y verifique los datos ingresados.";}}}}