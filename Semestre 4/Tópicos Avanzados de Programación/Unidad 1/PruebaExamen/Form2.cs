using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaExamen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre; float sueldo_hora, sueldo_neto, ahorro, sueldo_final, horas_trabajadas;

            nombre = txtbxNombre.Text;
            sueldo_hora = float.Parse(txtbxSueldoHora.Text);
            horas_trabajadas = float.Parse(txtbxHorasTrabajadas.Text);

            //Calculando sueldo
            sueldo_neto = horas_trabajadas * sueldo_hora;

            ahorro = sueldo_neto * 0.1f;

            sueldo_final = sueldo_neto - ahorro;

            //Mostrando resultados

            lblSueldoNeto.Visible = true; lblAhorro.Visible = true;
            lblSueldoFinal .Visible = true; txtSueldoNeto.Visible = true;
            txtAhorro.Visible = true; txtSueldoFinal.Visible = true;
            btnLimpiar.Visible = true;lblTrabajador.Visible = true;

            lblTrabajador.Text += nombre;
            txtSueldoNeto.Text = sueldo_neto.ToString();
            txtAhorro.Text = ahorro.ToString();
            txtSueldoFinal.Text = sueldo_final.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblSueldoNeto.Visible = false; lblAhorro.Visible = false;
            lblSueldoFinal.Visible = false; txtSueldoNeto.Visible = false;
            txtAhorro.Visible = false; txtSueldoFinal.Visible = false;
            btnLimpiar.Visible = false; lblTrabajador.Visible = false;

            txtbxNombre.Text = string.Empty; txtbxSueldoHora.Text = string.Empty;
            txtbxHorasTrabajadas.Text = string.Empty;
            lblTrabajador.Text = "Trabajador: ";
        }
    }
}
