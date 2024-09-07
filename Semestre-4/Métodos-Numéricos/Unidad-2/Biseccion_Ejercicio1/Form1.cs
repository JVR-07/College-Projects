using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biseccion_Ejercicio1
{
    //Clase del formulario, derivada de la clase Form
    public partial class Form1 : Form
    {
        private static double[] Intervalo = new double[2] { 1, 1.6 }; //Campo para guardar el intervalo 
        private static double Pm; //Campo para guardar la raíz aproximada
        public Form1() //Constructor
        {
            InitializeComponent();
        }

        //Método para evaluar la ecuación con los distintos valores obtenidos
        public static double EvaluarEcuacion(double X)
        {
            double result = (4 * Math.Pow(X, 2)) - 5 * X;
            return result;
        }

        //Método para calcular el error relativo porcentual aproximado
        public static double EvaluarErrorAproximado(double Pm_anterior)
        {
            double result = Math.Abs((Pm - Pm_anterior) / Pm) * 100;
            return result;
        }

        //Método para calcular Pm
        public static double CalcularPm(double a, double b)
        {
            double result = (a + b) / 2;
            return result;
        }

        //Método para determinar el signo del número
        public static bool EsPositivo(double F1, double F2)
        {
            if ( (F1 * F2) > 0 ) return true;
            else return false;
        }

        //Método correspondiente al evento click en el  botón btnCalcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, tempFa, tempFb, tempFPm, Error = 0, Pm_anterior = 0;
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

                //Cálculo e impresión de Pm
                Pm = CalcularPm(a, b); dgvTablaIteraciones.Rows[n].Cells[5].Value = Pm;

                //Cálculo e impresión de f(Xr)
                tempFPm = EvaluarEcuacion(Pm); dgvTablaIteraciones.Rows[n].Cells[6].Value = tempFPm;

                //Cálculo e impresión del Error relativo porcentual aproximado
                Error = EvaluarErrorAproximado(Pm_anterior); dgvTablaIteraciones.Rows[n].Cells[7].Value = Error;

                //Condiciones para calcular nuevo intervalo
                if (EsPositivo(tempFa, tempFPm))
                {
                    Intervalo[0] = Pm;
                }
                else if (!EsPositivo(tempFa, tempFPm))
                {
                    Intervalo[1] = Pm;
                }

                //Impresión del nuevo intervalo
                dgvTablaIteraciones.Rows[n].Cells[8].Value = $"[ {Intervalo[0]} , {Intervalo[1]} ]";
                //Guardando el resultado para calcular el error en siguiente iteración
                Pm_anterior = Pm;
            }
            //Impresión de resultados en textbox
            txtbxResultado.Text = Pm.ToString();
            txtErrorFinal.Text = Error.ToString();
        }

        //Método para salir de la aplicación al dar click al botón
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
