using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Vector2
    {
        #region Fields

        private double X { get; set; }
        private double Y { get; set; }

        public System.Drawing.PointF ToPointF
        {
            get
            {
                return new System.Drawing.PointF((float)X, (float)Y);
            }
        }

        public static Vector2 NullVector
        {
            get
            {
                return new Vector2(0.0, 0.0);
            }
        }

        #endregion

        #region Constructor

        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        #endregion

        #region Methods

        

        #endregion
    }
}
