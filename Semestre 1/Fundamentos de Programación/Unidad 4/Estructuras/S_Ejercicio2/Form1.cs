using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Ejercicio2
{
    public partial class Form1 : Form
    {
        double[,,] registrodepartamentos = new double[12,4,5];
        int meses = 12, years = 4, departamentos = 5;  // Machado Sanchez Javier. 22211600
        struct totaldepartamento1 // Creacion de la primer estructura
        {
            public double totalproductionyear1; 
            public double totalproductionyear2; // Contenido de la estructura 
        }
        struct totaldepartamento2 // Creacion de la segunda estructura
        {
            public double totalproductionyear1;
            public double totalproductionyear2; // Contenido de la estructura
        }
        struct totaldepartamento3 // Creacion de la tercer estructura
        {
            public double totalproductionyear1;
            public double totalproductionyear2; // Contenido de la estructura
            public double totalproductionyear4;
        }
        struct totaldepartamento4 // Creacion de la cuarta estructura
        {
            public double totalproductionyear1;
            public double totalproductionyear2; // Contenido de la estructura
        }
        struct totaldepartamento5 // Creacion de la quinta estructura
        {
            public double totalproductionyear1;
            public double totalproductionyear2; // Contenido de la estructura
        }
        totaldepartamento1 departamento1; totaldepartamento2 departamento2; // Declaracion de los identificadores 
        totaldepartamento3 departamento3; totaldepartamento4 departamento4; //       de cada estructura        
        totaldepartamento5 departamento5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciarregistro_Click(object sender, EventArgs e)
        {
            try
            {
                btniniciarregistro.Enabled = false;
                for (int i = 0; i < departamentos; i++)
                {
                    for (int j = 0; j < years; j++)
                    {
                        if ((i + 1) == 1)
                        {
                            txtproducidodepartamento1.Text = txtproducidodepartamento1.Text + "Año " + (j + 1) + ".\r\r\n";
                        }
                        else if ((i + 1) == 2)
                        {
                            txtproducidodepartamento2.Text = txtproducidodepartamento2.Text + "Año " + (j + 1) + ".\r\n";
                        }
                        else if ((i + 1) == 3)
                        {
                            txtproducidodepartamento3.Text = txtproducidodepartamento3.Text + "Año " + (j + 1) + ".\r\n";
                        }
                        else if ((i + 1) == 4)
                        {
                            txtproducidodepartamento4.Text = txtproducidodepartamento4.Text + "Año " + (j + 1) + ".\r\n";
                        }
                        else if ((i + 1) == 5)
                        {
                            txtproducidodepartamento5.Text = txtproducidodepartamento5.Text + "Año " + (j + 1) + ".\r\n";
                        }
                        for (int k = 0; k < meses; k++)
                        {
                            registrodepartamentos[k, j, i] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el total producido en el mes " + (k + 1) + ", del año " + (j + 1) + ", del departamento " + (i + 1) + ".", "REGISTRADOR", ""));
                            if ((i + 1) == 1)
                            {
                                txtproducidodepartamento1.Text = txtproducidodepartamento1.Text + (k + 1) + ".- " + Convert.ToString(registrodepartamentos[k, j, i]) + "\r\n";
                            }
                            else if ((i + 1) == 2)
                            {
                                txtproducidodepartamento2.Text = txtproducidodepartamento2.Text + (k + 1) + ".- " + Convert.ToString(registrodepartamentos[k, j, i]) + "\r\n";
                            }
                            else if ((i + 1) == 3)
                            {
                                txtproducidodepartamento3.Text = txtproducidodepartamento3.Text + (k + 1) + ".- " + Convert.ToString(registrodepartamentos[k, j, i]) + "\r\n";
                            }
                            else if ((i + 1) == 4)
                            {
                                txtproducidodepartamento4.Text = txtproducidodepartamento4.Text + (k + 1) + ".- " + Convert.ToString(registrodepartamentos[k, j, i]) + "\r\n";
                            }
                            else if ((i + 1) == 5)
                            {
                                txtproducidodepartamento5.Text = txtproducidodepartamento5.Text + (k + 1) + ".- " + Convert.ToString(registrodepartamentos[k, j, i]) + "\r\n";
                            }
                        }
                    }
                }

                lblregistrocompletado.Text = "El registro se ha completado exitosamente";
                lblregistrocompletado.Visible = true;
            }
            catch (FormatException)
            {
                DialogResult exception; 
                exception = MessageBox.Show("Se ha detectado un error con los datos ingresados. ¿Desea salir del programa?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(exception == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Reinicie el programa para continuar", "", MessageBoxButtons.OK);
                    btniniciarregistro.Enabled = false;
                    btncalculartotalmensual.Enabled = false;
                    btncalculartotalyear1.Enabled = false;
                    btntotaldepartamento3.Enabled = false;
                }
            }
        }
        private void btncalculartotalmensual_Click(object sender, EventArgs e)
        {
            btncalculartotalmensual.Enabled = false;
            int secondyear = years - 3;
            double sumameses = 0;
            for(int i = 0; i < departamentos; i++) 
            {
                sumameses = 0;
                for(int j = 0; j < meses; j++)
                {
                    sumameses = sumameses + registrodepartamentos[j, secondyear, i];
                }
                if((i + 1) == 1)
                {
                    departamento1.totalproductionyear2 = sumameses;
                }
                else if ((i + 1) == 2)
                {
                    departamento2.totalproductionyear2 = sumameses;
                }
                else if ((i + 1) == 3)
                {
                    departamento3.totalproductionyear2 = sumameses;
                }
                else if ((i + 1) == 4)
                {
                    departamento4.totalproductionyear2 = sumameses;
                }
                else if ((i + 1) == 5)
                {
                    departamento5.totalproductionyear2 = sumameses;
                }
            }
            for(int i = 0; i < departamentos; i++)
            {
                if ((i + 1) == 1)
                {
                    txttotalmensualdepartamento1.Text = "El total mensual durante el segundo año es de:\r\n" + departamento1.totalproductionyear2;
                }
                else if ((i + 1) == 2)
                {
                    txttotalmensualdepartamento2.Text = "El total mensual durante el segundo año es de:\r\n" + departamento2.totalproductionyear2;
                }
                else if ((i + 1) == 3)
                {
                    txttotalmensualdepartamento3.Text = "El total mensual durante el segundo año es de:\r\n" + departamento3.totalproductionyear2;
                }
                else if ((i + 1) == 4)
                {
                    txttotalmensualdepartamento4.Text = "El total mensual durante el segundo año es de:\r\n" + departamento4.totalproductionyear2;
                }
                else if ((i + 1) == 5)
                {
                    txttotalmensualdepartamento5.Text = "El total mensual durante el segundo año es de:\r\n" + departamento5.totalproductionyear2;
                }
            }
            lbltotalmensual.Text = "La operación ha terminado exitosamente";
            lbltotalmensual.Visible = true;
        }
        private void btncalculartotalyear1_Click(object sender, EventArgs e)
        {
            btncalculartotalyear1.Enabled = false;
            double sumadepartamento = 0, sumayear1 = 0;
            int year = years - 4;
            for(int i = 0; i < departamentos; i++)
            {
                for(int j = 0; j < meses; j++)
                {
                    sumadepartamento = sumadepartamento + registrodepartamentos[j, year, i];
                }
                if((i + 1) == 1)
                {
                    departamento1.totalproductionyear1 = sumadepartamento;
                }
                else if((i + 1) == 2)
                {
                    departamento2.totalproductionyear1 = sumadepartamento;
                }
                else if ((i + 1) == 3)
                {
                    departamento3.totalproductionyear1 = sumadepartamento;
                }
                else if ((i + 1) == 4)
                {
                    departamento4.totalproductionyear1 = sumadepartamento;
                }
                else if ((i + 1) == 5)
                {
                    departamento5.totalproductionyear1 = sumadepartamento;
                }
                sumadepartamento = 0;
            }
            sumayear1 = departamento1.totalproductionyear1 + departamento2.totalproductionyear1 + departamento3.totalproductionyear1 + departamento4.totalproductionyear1 + departamento5.totalproductionyear1;
            txttotalproducidoyear1.Text = "El total de producción en el primer año, es de: \r\n" + sumayear1;
            lbltotalprimeryear.Text = "La operación ha terminado exitosamente";
            lbltotalprimeryear.Visible = true;
        }
        private void btntotaldepartamento3_Click(object sender, EventArgs e)
        {
            btntotaldepartamento3.Enabled = false;
            double totalproductionyear3 = 0;
            int departamento = 2, year = years - 1;
            for(int i = 0; i < meses; i++)
            {
                departamento3.totalproductionyear4 = departamento3.totalproductionyear4 + registrodepartamentos[i, year, departamento];
            }
            totalproductionyear3 = departamento3.totalproductionyear4;
            txttotaldepartamento3.Text = "El total de producción del departamento 3 en el último año, es de: \r\n" + totalproductionyear3;
            lbltotaldepartamento3.Text = "La operación ha terminado exitosamente";
            lbltotaldepartamento3.Visible = true;
        }
        private void btnrestart_Click(object sender, EventArgs e)
        {
            DialogResult restart;
            restart = MessageBox.Show("¿Está seguro de querer reiniciar el programa? Se borrarán todos los datos", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(restart == DialogResult.Yes)
            {
                txtproducidodepartamento1.Clear();
                txtproducidodepartamento2.Clear();
                txtproducidodepartamento3.Clear();
                txtproducidodepartamento4.Clear();
                txtproducidodepartamento5.Clear();
                lblregistrocompletado.Text = "Esperando registro...";
                lblregistrocompletado.Visible = false;
                btniniciarregistro.Enabled = true;
                txttotalmensualdepartamento1.Clear();
                txttotalmensualdepartamento2.Clear();
                txttotalmensualdepartamento3.Clear();
                txttotalmensualdepartamento4.Clear();
                txttotalmensualdepartamento5.Clear();
                lbltotalmensual.Text = "Esperando registro...";
                lbltotalmensual.Visible = false;
                btncalculartotalmensual.Enabled = true;
                txttotalproducidoyear1.Clear();
                lbltotalprimeryear.Text = "Esperando registro...";
                lbltotalprimeryear.Visible = false;
                btncalculartotalyear1.Enabled = true;
                txttotaldepartamento3.Clear();
                lbltotaldepartamento3.Text = "Esperando registro...";
                lbltotaldepartamento3.Visible = false;
                btntotaldepartamento3.Enabled = true;
                MessageBox.Show("El programa ha sido reiniciado exitosamente", "PROCESO TERMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operación cancelada exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult exit; 
            exit = MessageBox.Show("¿Está seguro de querer salir del programa? Se borrarán todos los datos", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Operación cancelada exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}