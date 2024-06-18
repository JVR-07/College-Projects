using System;
using System.Drawing;
using System.Windows.Forms;


namespace Practica2_BotonesEnMovimiento
{
    internal class Program : Form
    {
        private Random random = new Random();
        private Button btnBotonAleatorio;
        Icon icon = Icon.ExtractAssociatedIcon("Icon/Bootstrap.ico");

        public Program()
        {
            IniciarVentanaMain();
        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        private void IniciarVentanaMain()
        {

            this.btnBotonAleatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.ResumeLayout(false);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Name = "VentanaMain";
            this.Text = "Practica 2 Boton En Movimiento";
            this.Controls.Add(this.btnBotonAleatorio);
            this.BackColor = System.Drawing.Color.HotPink;
            this.Icon = icon;

            //Botón
            this.btnBotonAleatorio.Size = new System.Drawing.Size(140, 140);
            this.btnBotonAleatorio.Text = "Da click aqui para cambiar mi posición";
            this.btnBotonAleatorio.Name = "btnBotonAleatorio";
            this.btnBotonAleatorio.UseVisualStyleBackColor = true;
            this.btnBotonAleatorio.Location = new System.Drawing.Point(0,0);
            this.btnBotonAleatorio.TabIndex = 0;
            this.btnBotonAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold);
            this.btnBotonAleatorio.Click += new System.EventHandler(this.btnBotonAleatorio_Click);
            this.btnBotonAleatorio.BackColor = System.Drawing.Color.MediumPurple;
            this.btnBotonAleatorio.ForeColor = System.Drawing.Color.White;
        }

        private void btnBotonAleatorio_Click(object sender, EventArgs e)
        {
            CalcularNuevaPosicionBoton();
            MessageBox.Show("Mi posición ha cambiado de lugar", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CalcularNuevaPosicionBoton()
        {
            int posicionX = random.Next(1, 1140), posicionY = random.Next(1, 580);
            this.btnBotonAleatorio.Location = new System.Drawing.Point(posicionX, posicionY);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.SuspendLayout();
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Program";
            this.ResumeLayout(false);

        }
    }
}
