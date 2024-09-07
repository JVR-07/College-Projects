using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modularidad
{
    public partial class Form1 : Form
    {
        public double numero1, numero2, resultado;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnsumar_Click(object sender, EventArgs e) // Machado Sanchez Javier. 22211600
        {
            try
            {
                cancelbuttons();
                numero1 = Convert.ToDouble(txtnumero1.Text);
                numero2 = Convert.ToDouble(txtnumero2.Text);
                sumar(numero1, numero2); // Llamada del modulo y utilizacion de los datos de las variables
            }
            catch (FormatException)
            {
                MessageBox.Show("Ha ocurrido un error con los datos ingresados, por lo que el programa se ha detenido","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnrestar_Click(object sender, EventArgs e)
        {
            try
            {
                cancelbuttons();
                numero1 = Convert.ToDouble(txtnumero1.Text);
                numero2 = Convert.ToDouble(txtnumero2.Text);
                restar(numero1, numero2); // Llamada del modulo y utilizacion de los datos de las variables
            }
            catch (FormatException)
            {
                MessageBox.Show("Ha ocurrido un error con los datos ingresados, por lo que el programa se ha detenido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                cancelbuttons();
                numero1 = Convert.ToDouble(txtnumero1.Text);
                numero2 = Convert.ToDouble(txtnumero2.Text);
                multiplicar(numero1, numero2); // Llamada del modulo y utilizacion de los datos de las variables
            }
            catch (FormatException)
            {
                MessageBox.Show("Ha ocurrido un error con los datos ingresados, por lo que el programa se ha detenido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btndividir_Click(object sender, EventArgs e)
        {
            try
            {
                cancelbuttons();
                numero1 = Convert.ToDouble(txtnumero1.Text);
                numero2 = Convert.ToDouble(txtnumero2.Text);
                dividir(numero1, numero2); // Llamada del modulo y utilizacion de los datos de las variables
            }
            catch (FormatException)
            {
                MessageBox.Show("Ha ocurrido un error con los datos ingresados, por lo que el programa se ha detenido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir entre cero, por lo que el programa se ha detenido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnelevar_Click(object sender, EventArgs e)
        {
            try
            {
                cancelbuttons();
                lblnumero1.Text = "Número 1 (Base)";
                lblnumero2.Text = "Número 2 (Potencia)";
                numero1 = Convert.ToDouble(txtnumero1.Text);
                numero2 = Convert.ToDouble(txtnumero2.Text);
                elevar(numero1, numero2); // Llamada del modulo y utilizacion de los datos de las variables
            }
            catch (FormatException)
            {
                MessageBox.Show("Ha ocurrido un error con los datos ingresados, por lo que el programa se ha detenido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            DialogResult limpiar;
            limpiar = MessageBox.Show("¿Está seguro de querer limpiar el programa? El resultado no se borrará." , "ESPERANDO CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (limpiar == DialogResult.Yes)
            {
                btnsumar.Enabled = true;
                btnrestar.Enabled = true;
                btnmultiplicar.Enabled = true;
                btndividir.Enabled = true;
                btnelevar.Enabled = true;
                txtnumero1.Clear();
                txtnumero2.Clear();
                lblconsola.Visible = false;
                lblnumero1.Text = "Número 1:";
                lblnumero2.Text = "Número 2:";
            }
            else
            {
                MessageBox.Show("Limpieza cancelada", "CANCELACION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult limpiar;
            limpiar = MessageBox.Show("¿Está seguro de querer cerrar el programa?", "ESPERANDO CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (limpiar == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Salida cancelada", "CANCELACION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void sumar(double num1, double num2) // Declaracion del modulo sumar, con dos variables double
        {
            resultado = num1 + num2;
            txtresultado.Text = resultado.ToString(); // Bloque de codigo que se ejecuta en el modulo
            lblconsola.Visible = true;
        }
        void restar(double num1, double num2) // Declaracion del modulo restar, con dos variables double
        {
            resultado = num1 - num2;
            txtresultado.Text = resultado.ToString(); // Bloque de codigo que se ejecuta en el modulo
            lblconsola.Visible = true;
        }
        void multiplicar(double num1, double num2) // Declaracion del modulo multiplicar, con dos variables double
        {
            resultado = num1 * num2;
            txtresultado.Text = resultado.ToString(); // Bloque de codigo que se ejecuta en el modulo
            lblconsola.Visible = true;
        }
        void dividir(double num1, double num2) // Declaracion del modulo dividir, con dos variables double
        {
            resultado = num1 / num2;
            txtresultado.Text = resultado.ToString(); // Bloque de codigo que se ejecuta en el modulo
            lblconsola.Visible = true;
        }
        void elevar(double num, double potencia) // Declaracion del modulo elevar, con dos variables double
        {
            resultado = Math.Pow(num, potencia);
            txtresultado.Text = resultado.ToString(); // Bloque de codigo que se ejecuta en el modulo
            lblconsola.Visible = true;
        }
        void cancelbuttons() // Declaracion del modulo cancelbuttons, que desabilita todos los botones
        {
            btnsumar.Enabled = false;
            btnrestar.Enabled = false;
            btnmultiplicar.Enabled = false; // Bloque de codigo que se ejecuta en el modulo
            btndividir.Enabled = false;
            btnelevar.Enabled = false;
        }
    }
}