using System;

//Bibliotecas importadas
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CustomElements
{
    public class CustomButton : Button
    {
        //Propiedades
        private int borderSize = 1; //Borde
        private int borderRadius = 30; //Borde del radio
        private Color borderColor = Color.MediumSlateBlue; //Color del borde

        //Constructor
        public CustomButton()
        {   //Propiedades inicializadas
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(180, 40);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        //Métodos
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            //float curveSize = radius * 2F;

            path.StartFigure(); //Inicio de la figura a dibujar
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); //Esquina superior izquierda
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90); //Esquina superior derecha
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90); //Esquina inferior derecha
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90); //Esquina inferior izquierda
            path.CloseFigure(); //Fin de la figura a dibujar
            return path; //Retorno de la forma de la figura
        }

        protected override void OnPaint(PaintEventArgs pevent) //Sobrecarga del método OnPaint para controlar el dibujado del botón
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias; //AntiAliasing para evitar malformaciones en los arcos del borde

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height); //Superficie del rectangulo base
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1); //Borde del rectangulo base

            if (borderRadius > 2) //Botón redondeado para en caso de tener un borde de radio menor a 2
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius)) //Método para obtener la figura de la superficie del rect base
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize)) //Método para obtener la figura del borde del rect base
                using (Pen penSurface = new Pen(this.Parent.BackColor,2)) //Boligrafo negro con grosor 2 para la supertficie
                using (Pen penBorder = new Pen(borderColor, borderSize)) //Boligrafo del color y borde inicializados para el borde
                {
                    
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //En caso contrario, se crea un botón normal
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e) //Método sobrecargado para la creación de un identificar de eventos
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged); //Creando evento en caso de que exista cambio en el color de fondo
        }

        private void Container_BackColorChanged(object sender, EventArgs e) //Método que se ejecuta al detectarse el evento
        {
            this.Invalidate();
        }

        //Conjuntos de gets y sets para poder modificar las propiedades encapsuladas de la clase
        [Category("Custom Properties")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom Properties")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Custom Properties")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
    }
}
