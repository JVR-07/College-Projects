using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Ejercicio1
{
    public partial class Form1 : Form
    {
        bool error = false;
        struct sistema 
        {              // Machado Sanchez Javier. 22211600
            public int velocidadviento; // Declaracion de variable.
            public string estadoclima; // Declaracion de variable.
        }
        struct tiempo // Estructura que almacena datos de varios tipos.
        {
            public sistema datosdelclima;
            public int temperatura; // Declaracion de variable.
            public string grados; // Declaracion de variable.
        }
        tiempo datosdeltiempo; // Declaracion del nombre para acceder a la estructura.
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciarregistro_Click(object sender, EventArgs e)
        {
            try
            {
                btniniciarregistro.Enabled = false;  // Captura de datos en cada variable de las estructuras
                datosdeltiempo.datosdelclima.velocidadviento = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la velocidad del viento en Km/h.", "CAPTURADOR"));
                datosdeltiempo.datosdelclima.estadoclima = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el estado del clima\nPor ejemplo: Soleado, Nublado, Humedo.", "CAPTURADOR");
                datosdeltiempo.temperatura = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la temperatura del entorno", "CAPTURADOR"));
                datosdeltiempo.grados = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el tipo de grados de la temperatura\n(Fahrenheit o Celsius)", "CAPTURADOR");
            }
            catch (FormatException)
            {
                MessageBox.Show("Se ha producido un error. Compruebe los datos ingresados.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                error = true;
            }
        }

        private void btnimprimirresultado_Click(object sender, EventArgs e)
        {
            btnimprimirresultado.Enabled = false; // Impresion en pantalla de los datos almacenados.
            txtresultado.Text = "La velocidad del viento es " + datosdeltiempo.datosdelclima.velocidadviento + " Km/h. El clima está " + datosdeltiempo.datosdelclima.estadoclima + "\r\nLa temperatura del entorno es de " + datosdeltiempo.temperatura + " grados " + datosdeltiempo.grados;
            if (error == true)
            {
                txtresultado.Clear();
                txtresultado.ForeColor = Color.Red;
                txtresultado.Text = txtresultado.Text + "\r\nEl proceso se ha detenido debido a un error. Reinicie el programa para realizar otro registro";
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("¿Está seguro de querer limpiar el programa? Los datos se borrarán", "ESPERANDO CONFIRMACIÓN",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes)
            {
                error = false;
                btniniciarregistro.Enabled = true;
                btnimprimirresultado.Enabled = true;
                txtresultado.Clear();
                datosdeltiempo.datosdelclima.estadoclima = "";
                datosdeltiempo.datosdelclima.velocidadviento = 0;
                datosdeltiempo.grados = "";
                datosdeltiempo.temperatura = 0;
                txtresultado.ForeColor = Color.FromArgb(255, 239, 133, 3);
                MessageBox.Show("El programa ha sido limpiado","",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("La limpieza ha sido cancelada","",MessageBoxButtons.OK);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult salir;
            salir = MessageBox.Show("¿Está seguro de querer salir del programa? Los datos se borrarán", "ESPERANDO CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("La salida ha sido cancelada", "", MessageBoxButtons.OK);
            }
        }
    }
}