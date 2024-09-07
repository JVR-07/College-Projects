using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Entities
{
    public class Point
    {
        #region Fields

        public Vector2 Position { get; set; }
        private double Thickness { get; set; }

        #endregion

        #region Constructors

        public Point() 
        {
            Position = Vector2.NullVector;
            Thickness = 0.0;
        }

        public Point(Vector2 position)
        {
            Position = position;
            Thickness = 0.0;
        }

        #endregion
    }
}
