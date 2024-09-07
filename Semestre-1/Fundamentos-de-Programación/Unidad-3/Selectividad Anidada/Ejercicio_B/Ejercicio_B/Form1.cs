using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnmostrar_Click(object sender, EventArgs e){ //Machado Sanchez Javier 22211600
            int nummes; nummes = Convert.ToInt16(txtnum.Text);
            // Inicio de selectiva anidada 
            if (nummes == 1) // Primer bloque de instrucciones. Se inicia cuando se cumple la condición
            {txtresult.Text = "El mes correspondiente a " + nummes + " es: Enero";}
            // Bloque de instrucciones en caso de cumplirse alguna de las condiciones
            else if (nummes == 2) { txtresult.Text = "El mes correspondiente a " + nummes + " es: Febrero";   }
            else if (nummes == 3) { txtresult.Text = "El mes correspondiente a " + nummes + " es: Marzo";     }
            else if (nummes == 4) { txtresult.Text = "El mes correspondiente a " + nummes + " es: Abril";     }
            else if (nummes == 5) { txtresult.Text = "El mes correspondiente a " + nummes + " es: Mayo";      }
            else if (nummes == 6) { txtresult.Text = "El mes correspondiente a " + nummes + " es: Junio";     }
            else if (nummes == 7) { txtresult.Text = "El mes correspondiente a " + nummes + " es: Julio";     }
            else if (nummes == 8) { txtresult.Text = "El mes correspondiente a " + nummes + " es: Agosto";    }
            else if (nummes == 9) { txtresult.Text = "El mes correspondiente a " + nummes + " es: Septiembre";}
            else if (nummes == 10){ txtresult.Text = "El mes correspondiente a " + nummes + " es: Octubre";   }
            else if (nummes == 11){ txtresult.Text = "El mes correspondiente a " + nummes + " es: Noviembre"; }
            else if (nummes == 12){ txtresult.Text = "El mes correspondiente a " + nummes + " es: Diciembre"; }
            // Bloque de instrucción por si no se cumple ningúna condición
            else { txtresult.Text = "El mes correspondiente a " + nummes + " no existe.";}} 
        private void btnlimpiar_Click(object sender, EventArgs e){
            txtnum.Text = "";
            txtresult.Text = "Aquí aparecerá el mes del año";}
        private void btnsalir_Click(object sender, EventArgs e){ Application.Exit(); }
        private void Form1_Load(object sender, EventArgs e){
            this.Location = new System.Drawing.Point(300, 200);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false; 
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;}}}