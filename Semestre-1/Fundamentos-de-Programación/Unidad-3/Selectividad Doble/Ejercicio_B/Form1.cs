using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_B{
    public partial class Form1 : Form{
        public Form1(){InitializeComponent();}
        private void button1_Click(object sender, EventArgs e){ // Machado Sanchez Javier 22211600
            string name; // Declaracion de variable
            name = Microsoft.VisualBasic.Interaction.InputBox("Capturador de nombres", "EMPRESA SA de CV", "Ingrese su nombre aqui", 200, 200);
            txtname.Text = name;}
        private void btndep_Click(object sender, EventArgs e){   
            string dep; // Declaracion de variable
            dep = Microsoft.VisualBasic.Interaction.InputBox("Capturador de departamentos", "EMPRESA SA de CV", "Ingrese su departamento aqui", 200, 200);
            txtdep.Text = dep;}
        private void btncod_Click(object sender, EventArgs e){
            string cod; // Declaracion de variable
            cod = Microsoft.VisualBasic.Interaction.InputBox("Capturador de códigos", "EMPRESA SA de CV", "Ingrese su código aqui", 200, 200);
            txtcod.Text = cod;}
        private void btnsueldo_Click(object sender, EventArgs e){   
            double sueldo; // Declaracion de variable
            sueldo = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Capturador de sueldos mensuales", "EMPRESA SA de CV", "Ingrese su sueldo mensual aqui", 200, 200));
            //Selectividad Doble
            if (sueldo >= 1500){ // Condición para inicializar bloque de instrucciones
                MessageBox.Show("Usted gana 1500 pesos mensuales o más; no aplica para recibir un aumento","EMPRESA SA de CV",MessageBoxButtons.OK,MessageBoxIcon.Warning);}
            else{txtsueldo.Text = Convert.ToString(sueldo);}} // inicializa el bloque de instrucciones si la condición no se cumple
        private void btnresult_Click(object sender, EventArgs e)
        {   string name, dep, cod; // Declaracion de variables
            double sueldo, aumento; // Declaracion de variables
            name = txtname.Text;
            dep = txtdep.Text;
            cod = txtcod.Text;
            sueldo = Convert.ToDouble(txtsueldo.Text);
            aumento = sueldo * 0.08;
            sueldo = sueldo + aumento;
            MessageBox.Show(name + ", del departamento: " + dep + " con código " + cod + ", su nuevo sueldo mensual es: " + sueldo, "EMPRESA SA de CV", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}
        private void btnsalir_Click(object sender, EventArgs e)
        {   DialogResult salir;
            salir = MessageBox.Show("¿Está seguro de querer salir del programa?", "EMPRESA SA de CV", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes){Application.Exit();}}
        private void btnlimpiar_Click(object sender, EventArgs e){
            txtname.Text = "Esperando nombre...";
            txtdep.Text = "Esperando departamento...";
            txtcod.Text = "Esperando código...";
            txtsueldo.Text = Convert.ToString(txtsueldo.Text);
            txtsueldo.Text = "Esperando sueldo mensual...";}}}