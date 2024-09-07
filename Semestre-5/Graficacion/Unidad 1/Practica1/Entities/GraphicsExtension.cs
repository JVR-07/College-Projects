using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Entities
{
    public static class GraphicsExtension
    {
        #region Fields

        private static float Height;

        #endregion

        #region Methods

        public static void SetParameters(this System.Drawing.Graphics g, float height)
        {
            Height = height; 
        }

        public static void SetTransform(this System.Drawing.Graphics g)
        {
            g.PageUnit = System.Drawing.GraphicsUnit.Millimeter;
            g.TranslateTransform(0, Height);
            g.ScaleTransform(1.0f, -1.0f);
        }

        public static void DrawPoint(this System.Drawing.Graphics Grap, System.Drawing.Pen Pen, Entities.Point Point)
        {
            Grap.SetTransform();
            System.Drawing.PointF aux_point = Point.Position.ToPointF;
            Grap.DrawEllipse(Pen, aux_point.X - 1, aux_point.Y - 1, 2, 2);
            Grap.FillEllipse(new SolidBrush(Pen.Color), aux_point.X - 1, aux_point.Y - 1, 2, 2);
            Grap.ResetTransform();
        }

        public static void DrawLine(this System.Drawing.Graphics Grap, System.Drawing.Pen Pen, Line Line)
        {
            Grap.SetTransform();
            Grap.DrawLine(Pen, Line.StartPoint.ToPointF, Line.EndPoint.ToPointF);
            Grap.ResetTransform();
        }

        #endregion
    }
}
