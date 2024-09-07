using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Entities
{
    public class Line
    {
        #region Fields

        public Vector2 StartPoint { get; set; }
        public Vector2 EndPoint { get; set; }
        private double Thickness { get; set; }

        #endregion

        #region Constructor

        public Line(Vector2 start, Vector2 end) 
        {
            StartPoint = start;
            EndPoint = end;
        }

        #endregion
    }
}
