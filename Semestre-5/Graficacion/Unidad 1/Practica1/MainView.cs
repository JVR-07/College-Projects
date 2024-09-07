using Practica1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class MainView : Form
    {
        #region Fields

        private List<Line> Lines = new List<Line>();
        private List<Entities.Point> Points = new List<Entities.Point>();

        private Vector2 CurrentPosition;
        private Vector2 FirstPosition;
        private bool IsDrawingActive = false;
        private int PointCounter = 0;

        private float Dpi
        {
            get
            {
                using (var g = CreateGraphics())
                    return g.DpiX;
            }
        }

        #endregion

        #region Constructor

        public MainView()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void MainView_Load(object sender, EventArgs e)
        {
            ClearCoordenateLabels();
        }

        private void pbxDrawZone_MouseMove(object sender, MouseEventArgs e)
        {
            CurrentPosition = PointToCartesian(e.Location);
            lblX.Text = e.Location.X.ToString();
            lblY.Text = e.Location.Y.ToString();
            pbxDrawZone.Refresh();
        }

        private void pbxDrawZone_MouseLeave(object sender, EventArgs e)
        {
            ClearCoordenateLabels();
        }

        private void pbxDrawZone_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (IsDrawingActive)
                {
                    Points.Add(new Entities.Point(CurrentPosition));

                    PointCounter++;
                    if (PointCounter == 1)
                    {
                        FirstPosition = CurrentPosition;
                    }
                    if (PointCounter > 1)
                    {
                        Lines.Add(new Line(FirstPosition, CurrentPosition));
                        FirstPosition = CurrentPosition;
                    }
                }
                pbxDrawZone.Refresh();
            }
        }

        private void pbxDrawZone_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SetParameters(PixelToMm(pbxDrawZone.Height));

            if(Points.Count > 0)
            {
                foreach(Entities.Point p in Points)
                {
                    e.Graphics.DrawPoint(new Pen(Color.DarkBlue, 1), p);
                }
            }

            if (Lines.Count > 0)
            {
                foreach (Line line in Lines)
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), line);
                 }
            }

            if (IsDrawingActive)
            {
                if (PointCounter >= 1)
                {
                    Line line = new Line (FirstPosition, CurrentPosition);
                    e.Graphics.DrawLine(new Pen(Color.Gray, 1), line);
                }
            }            
        }

        private void btnDrawLines_Click(object sender, EventArgs e)
        {
            if (!IsDrawingActive)
            {
                IsDrawingActive = true;
                Cursor = Cursors.Cross;
                btnDrawLines.Text = "Stop Drawing";
            }
            else if(IsDrawingActive)
            {
                IsDrawingActive = false;
                Cursor = Cursors.Default;
                btnDrawLines.Text = "Start Drawing";
            }
        }

        #endregion

        #region Methods

        private void ClearCoordenateLabels()
        {
            lblX.Text = null; 
            lblY.Text = null;
        }

        private Vector2 PointToCartesian(System.Drawing.Point p)
        {
            return new Vector2(PixelToMm(p.X), PixelToMm(pbxDrawZone.Height - p.Y));
        }

        private float PixelToMm(float pixel)
        {
            return pixel * 25.4f / Dpi;
        }

        #endregion
    }
}
