using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DW_Ejercicio4
{
    public partial class frmMiForma : Form
    {
        public frmMiForma()
        {
            InitializeComponent();
        }
        private void frmMiForma_Load(object sender, EventArgs e){}
        private void btnIniciar_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            string Name,Dep, Code; double HorasT, SxH, SN; int c = 0;
            frmDatos LeerDatos = new frmDatos();
            try{do{ // Ciclo Do While. Corre el bloque de instrucciones y si la condición es verdadera, lo vuelve a correr
                    c++; // Contador de vueltas
                    btnIniciar.Enabled = false;
                    if (LeerDatos.ShowDialog() == DialogResult.OK){
                        Name = LeerDatos.txtName.Text;Dep = LeerDatos.txtDep.Text;Code = LeerDatos.txtCode.Text;
                        HorasT = Convert.ToDouble(LeerDatos.txtHorasT.Text);
                        SxH = Convert.ToDouble(LeerDatos.txtSxH.Text);SN = HorasT * SxH;
                        txtResultado.Text = txtResultado.Text+Name+", del departamento de " + Dep + ", con código " + Code + ", su sueldo por hora es $" + SxH + " y sus horas trabajadas son " + HorasT + " horas.\r\n"+Name+", su sueldo neto es $" + SN + "\r\n";}
                    else if (LeerDatos.ShowDialog() == DialogResult.Cancel){
                        MessageBox.Show("El proceso ha sido cancelado exitosamente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtResultado.Text = txtResultado.Text + "Reinicie el proceso o cierre el programa.\r\n";break;}} 
                while (c < 5);} // Condicion. Si es verdadera, se repite el bloque de instrucciones; si no, sigue su curso
            catch (FormatException)
            {MessageBox.Show("Se han detectado uno o más datos inválidos. Por favor, revise los datos ingresados.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = txtResultado.Text + "Reinicie el proceso o cierre el programa.\r\n";}
            finally{txtResultado.Text = txtResultado.Text + "El proceso finalizó con exito.\r\n";}}
        private void btnReiniciar_Click(object sender, EventArgs e){
            btnIniciar.Enabled = true;txtResultado.Clear();}
        private void btnCancelar_Click(object sender, EventArgs e){
            DialogResult salir;
            salir = MessageBox.Show("El programa se cerrará. ¿Desea continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(salir == DialogResult.Yes){ Application.Exit(); }}}}