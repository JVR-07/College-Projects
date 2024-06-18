using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace FalsaPosicion_Ejercicio2
{  
    //Clase del formulario, derivada de la clase Form
    public partial class Form1 : Form
    {
        private static double[] Intervalo = new double[2] { 1, 2}; //Campo para guardar el intervalo 
        private static double Xr; //Campo para guardar la raíz aproximada
        public Form1() //Constructor
        {
            InitializeComponent(); //Método para inicializar los componentes gráficos
        }

        //Método para evaluar la ecuación con los distintos valores obtenidos
        public static double EvaluarEcuacion(double X)
        {
            double result = Math.Pow(X, 3) + (4 * Math.Pow(X,2)) - 10;
            return result;
        }

        //Método para calcular el error relativo porcentual aproximado
        public static double EvaluarErrorAproximado(double Xr_anterior)
        {
            double result = Math.Abs( (Xr - Xr_anterior) / Xr) * 100;
            return result;
        }

        //Método para calcular Xr
        public static double CalcularXr(double a, double Fa, double b, double Fb)
        {
            double result = b - ( (Fb * (a - b)) / (Fa - Fb) );
            return result;
        }

        //Método para determinar el signo del número
        public static bool EsPositivo(double numero)
        {
            if (numero > 0) return true;
            else return false;
        }

        //Método correspondiente al evento click en el  botón btnCalcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, tempFa, tempFb, tempFXr, Error = 0, Xr_anterior = 0;
            for (int i = 0; i < 7; i++)
            {
                int n = dgvTablaIteraciones.Rows.Add();
                a = Intervalo[0]; b = Intervalo[1]; //Asignación de intervalos a variables para facilitar la lectura del código

                dgvTablaIteraciones.Rows[n].Cells[0].Value = i + 1; //Instrucción para mostrar el número de iteración

                dgvTablaIteraciones.Rows[n].Cells[1].Value = a; //Instrucción para mostrar a
                dgvTablaIteraciones.Rows[n].Cells[2].Value = b; //Instrucción para mostrar b

                //Cálculo e impresión de f(a)
                tempFa = EvaluarEcuacion(a); dgvTablaIteraciones.Rows[n].Cells[3].Value = tempFa;
                //Cálculo e impresión de f(b)
                tempFb = EvaluarEcuacion(b); dgvTablaIteraciones.Rows[n].Cells[4].Value = tempFb;

                //Cálculo e impresión de Xr
                Xr = CalcularXr(a, tempFa, b, tempFb); dgvTablaIteraciones.Rows[n].Cells[5].Value = Xr;

                //Cálculo e impresión de f(Xr)
                tempFXr = EvaluarEcuacion(Xr); dgvTablaIteraciones.Rows[n].Cells[6].Value = tempFXr;

                //Cálculo e impresión del Error relativo porcentual aproximado
                Error = EvaluarErrorAproximado(Xr_anterior); dgvTablaIteraciones.Rows[n].Cells[7].Value = Error;

                //Condiciones para calcular nuevo intervalo
                if ( ( EsPositivo(tempFXr) && !EsPositivo(tempFa) ) || ( !EsPositivo(tempFXr) && EsPositivo(tempFa) ) )
                {
                    Intervalo[0] = a;
                    Intervalo[1] = Xr;
                }
                else if ( ( EsPositivo(tempFXr) && !EsPositivo(tempFb) ) || ( !EsPositivo(tempFXr) && EsPositivo(tempFb) ) )
                {
                    Intervalo[0] = Xr;
                    Intervalo[1] = b;
                }

                //Impresión del nuevo intervalo
                dgvTablaIteraciones.Rows[n].Cells[8].Value = $"[ {Intervalo[0]} , {Intervalo[1]} ]";
                //Guardando el resultado para calcular el error en siguiente iteración
                Xr_anterior = Xr;
            }
            //Impresión de resultados en textbox
            txtbxResultado.Text = Xr.ToString();
            txtErrorFinal.Text = Error.ToString();
        }
        //Método para salir de la aplicación al dar click al botón
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
