using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Practica1
{
    internal class Program : Form
    {
        private Button boton1;

        public Program() 
        {
            IniciarVentana();
        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        private void IniciarVentana()
        {

            this.boton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.ResumeLayout(false);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Name = "VentanaGráfica";
            this.Text = "Practica 1 Forms en Consola";
            this.Controls.Add(this.boton1);

            //Botón
            this.boton1.Size = new System.Drawing.Size(800,400);
            this.boton1.Text = "Da click aqui";
            this.boton1.Name = "boton1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Location = new System.Drawing.Point(200,130);
            this.boton1.TabIndex = 0;
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20f, System.Drawing.FontStyle.Bold);
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Me has dado click", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        
        }
    }
}
