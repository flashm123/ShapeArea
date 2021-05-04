using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareLibrary.Models
{
    /// <summary>
    /// The rectangle shape
    /// </summary>
    class Rectangle : IShape
    {
        private double a;
        private double b;
        
        internal Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        
        public double GetArea()
        {
            return a * b;
        }
    }
}
