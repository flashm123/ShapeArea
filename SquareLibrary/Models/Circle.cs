using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareLibrary.Models
{
    /// <summary>
    /// The circle shape
    /// </summary>
    class Circle : IShape
    {
        private double radius;

        internal Circle(double radius)
        {
            this.radius = radius;
        }
        
        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
