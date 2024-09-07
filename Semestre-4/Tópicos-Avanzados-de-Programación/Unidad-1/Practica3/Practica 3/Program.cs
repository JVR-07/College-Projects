using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Practica_3
{
    public class Program : Form
    {
        public Program()
        {
            InicializarComponente();
        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }

        public Form forma1 = new Form();
        public Random random = new Random();
        public Button BotonPar;
        public Button BotonImpar;
        public List<Button> Botones = new List<Button>();
        public List<PictureBox> Gatitos = new List<PictureBox>();
        public List<Label> Nombres = new List<Label>();

        public void InicializarComponente()
        {
            BotonPar = new Button();
            BotonImpar = new Button();

            SuspendLayout();


            //Propiedades del Botón Par
            BotonPar.Location = new Point(random.Next(Width - 144), random.Next(Height - 80));
            BotonPar.Size = new Size(144, 80);
            BotonPar.Text = GenerarNumerosPares(true).ToString();
            BotonPar.UseVisualStyleBackColor = true;
            BotonPar.BackColor = Color.White;

            //Propiedades del Botón Par
            BotonImpar.Location = new Point(random.Next(Width - 144), random.Next(Height - 80));
            BotonImpar.Name = "btnBotonImpar";
            BotonImpar.Size = new Size(144, 80);
            BotonImpar.Text = GenerarNumerosPares(false).ToString(); ;
            BotonImpar.UseVisualStyleBackColor = true;
            BotonImpar.BackColor = Color.White;


            //Propiedades de la Forma		
            Name = "forma1";
            Text = "Forma: Colisiones de botones (Machado Sanchez Javier)";
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            BackColor = Color.White;

            Controls.Add(BotonPar);
            Controls.Add(BotonImpar);

            ResumeLayout(false);
            PerformLayout();

            //Método para mover el botón			
            DefinirMovimiento(BotonPar, BotonImpar, DefinirVelocidad(), DefinirVelocidad(), true);
            cronometro.Start();
        }

        Stopwatch cronometro = new Stopwatch();
        public async void DefinirMovimiento(Control controlPar, Control controlImpar, Velocidad velocidadpar, Velocidad velocidadimpar, bool Main)
        {
            //
            // Botón Par
            //

            //Colisión Superior Botón Par
            if (!VelocidadPositiva(velocidadpar.y) && controlPar.Location.Y <= 0)
            {
                if (Main) BackColor = System.Drawing.Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                velocidadpar.y *= -1;
            }

            //Colisión Inferior Botón Par
            if (VelocidadPositiva(velocidadpar.y) && controlPar.Location.Y >= Size.Height - 80)
            {
                velocidadpar.y *= -1;
                if (Main)
                {
                    if(!(Botones.Count == 2 || Botones.Count == 5))
                    while (Botones.Count < 5)
                    {
                        Botones.Add(new Button()
                        {
                            Location = new Point(random.Next(Width - 144), random.Next(Height - 80)),
                            Size = new Size(80, 40),
                            Text = GenerarNumerosPares(true).ToString()
                        });
                    }
                    foreach (Button Boton in Botones)
                    {
                        Controls.Add(Boton);
                        DefinirMovimiento(Boton, controlImpar, DefinirVelocidad(), velocidadimpar, false);
                    }
                }
            }

            //Colisión Izquierda Botón Par
            if (!VelocidadPositiva(velocidadpar.x) && controlPar.Location.X <= 0)
            {
                velocidadpar.x *= -1;
                controlPar.BackColor = System.Drawing.Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            }

            //Colisión Derecha Botón Par
            if (VelocidadPositiva(velocidadpar.x) && controlPar.Location.X >= Size.Width - 80)
            {
                velocidadpar.x *= -1;
                if (Main)
                {
                    if (Nombres.Count == 0)
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            Nombres.Add(new Label()
                            {
                                Location = new Point(i * 15, i * 25),
                                Text = "JAVIER MACHADO SANCHEZ",
                                AutoSize = true,
                                AutoScrollOffset = new Point()
                            });
                        }
                        foreach (Label Nombre in Nombres)
                        {
                            Controls.Add(Nombre);
                        }
                    }
                }
            }

            //
            // Botón Impar
            //

            if (Main)
            {
                //Colisión Superior Botón Impar
                if (!VelocidadPositiva(velocidadimpar.y) && controlImpar.Location.Y <= 0)
                {
                    if (Main) BackColor = System.Drawing.Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    velocidadimpar.y *= -1;

                    if (Nombres.Count == 10)
                    {
                        foreach (Label Nombre in Nombres)
                        {
                            Controls.Remove(Nombre);
                        }
                        Nombres.RemoveAll(x => Nombres.Contains(x));
                    }
                }

                //Colisión Inferior Botón Impar
                if (VelocidadPositiva(velocidadimpar.y) && controlImpar.Location.Y >= Size.Height - 80)
                {
                    int c = 0;
                    velocidadimpar.y *= -1;
                    foreach (Button Boton in Botones)
                    {
                        if (c < 3) { Controls.Remove(Boton); c++; }
                        else break;
                    }
                }

                //Colisión Izquierda Botón Impar
                if (!VelocidadPositiva(velocidadimpar.x) && controlImpar.Location.X <= 0)
                {
                    velocidadimpar.x *= -1;

                    //Se reinicia todo
                    BackColor = Color.White;
                    controlPar.BackColor = Color.White;
                    controlImpar.BackColor = Color.White;
                        foreach (Button Boton in Botones)
                        {
                            Controls.Remove(Boton);
                        }

                    if (Nombres.Count == 10)
                    {
                        foreach (Label Nombre in Nombres)
                        {
                            Controls.Remove(Nombre);
                        }
                        Nombres.RemoveAll(x => Nombres.Contains(x));
                    }
                }

                //Colisión Derecha Botón Par
                if (VelocidadPositiva(velocidadimpar.x) && controlImpar.Location.X >= Size.Width - 80)
                {
                    velocidadimpar.x *= -1;

                    for (int i = 0; i < 5; i++)
                    {
                        BackColor = System.Drawing.Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                        await Task.Delay(35);
                    }
                }
            }


            //
            // Recursividad para generar movimiento en los botones
            //
            controlPar.Location = new Point(controlPar.Location.X + velocidadpar.x, controlPar.Location.Y + velocidadpar.y);
            if(Main) controlImpar.Location = new Point(controlImpar.Location.X + velocidadimpar.x, controlImpar.Location.Y + velocidadimpar.y);

            await Task.Delay(35);
            if (controlPar != null && controlImpar != null) DefinirMovimiento(controlPar, controlImpar, velocidadpar, velocidadimpar, Main); 
        }

        public struct Velocidad
        {
            public int x; public int y;
            public Velocidad(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        //Procedimiento que controla que los valores de velocidad no sean == 0.
        public Velocidad DefinirVelocidad()
        {
            int x = random.Next(-9, 9);
            int y = random.Next(-9, 9);
            if (Math.Abs(x) < 1 || Math.Abs(y) < 1) return DefinirVelocidad();
            return new Velocidad(x, y);
        }
        public bool VelocidadPositiva(int velocidad)
        {
            return velocidad > 0;
        }

        //Procedimiento para generar los número pares e impares
        public int GenerarNumerosPares(bool ResultadoPar)
        {
            bool flag = false;
            int numero_aleatorio = 0;
            if (ResultadoPar)
            {
                while (!flag)
                {
                    numero_aleatorio = random.Next(1,100);
                    if (numero_aleatorio % 2 == 0) flag = true;                    
                }
            }
            else
            {
                while (!flag)
                {
                    numero_aleatorio = random.Next(1, 100);
                    if (!(numero_aleatorio % 2 == 0)) flag = true;
                }
            }
            return numero_aleatorio;
        }
    }
}
