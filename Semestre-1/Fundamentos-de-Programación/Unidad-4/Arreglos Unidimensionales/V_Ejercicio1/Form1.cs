using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Ejercicio1
{
    public partial class frmMain : Form
    {
        public frmMain(){InitializeComponent();}

        private void btnCalcular_Click(object sender, EventArgs e)
        {   // Machado Sanchez Javier. 22211600
            btnCalcular.Enabled = false;
            int[] numeros = new int[20]; // Declaración de array, con una capacidad para almacenar 20 datos de tipo int
            int temp = 0, contador = 20;
            double mediana;
            try
            {
                for (int i = 0; i < numeros.Length; i++)
                {  // Bucle, donde el valor de la variable i determina la posicion en donde se guardará el dato(de 0 hasta 19)
                    numeros[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un número entero positivo", "LECTOR DE DATOS", ""));
                    txtNumeros.Text = txtNumeros.Text + numeros[i].ToString() + "\r\n";
                }
                for (int j = 1; j < contador; j++)
                {
                    for (int k = contador - 1; k >= j; k--)
                    { 
                        if (numeros[k - 1] > numeros[k]) // El segundo bucle se encarga de comparar la posicion de la variable k, con el valor
                        {                                // que esté en la posición anterior(k - 1), si la posición k es más pequeña, se intercambian los
                            temp = numeros[k - 1];       // valores. Por otra parte, el segundo bucle se encarga de realizar el proceso anterior durante
                            numeros[k - 1] = numeros[k]; // la cantiadad de ciclos necesarios para asegurarnos de comparar todas las posiciones del array.
                            numeros[k] = temp;           
                        }
                    }
                }
                for (int a = 0; a < numeros.Length; a++)
                {
                    txtResultado.Text = txtResultado.Text + numeros[a].ToString() + "\r\n"; // Ciclo sencillo para mostrar datos del array
                }
                mediana = (numeros[9] + numeros[10]); mediana = mediana / 2; // Se suman las posiciones centrales del array y se dividen entre 2
                txtResultado.Text = txtResultado.Text + "\r\n La mediana de los números ingresados es: " + mediana.ToString();
                MessageBox.Show("El proceso ha finalizado. Si desea realizar otra operación, limpie el programa", "Mensaje Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(FormatException){ MessageBox.Show("Por favor, ingrese un dato válido", "CONTROLADOR DE ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("El proceso ha finalizado. Si desea realizar otra operación, limpie el programa", "Mensaje Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
            txtNumeros.Clear();
            txtResultado.Clear();
            MessageBox.Show("El programa ha sido limpiado exitosamente", "Limpiador", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult exit; exit = MessageBox.Show("El programa se cerrará, ¿Está seguro que desea salir?", "IT'S ME, DIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit == DialogResult.Yes) { Application.Exit(); }
        }
    }
}