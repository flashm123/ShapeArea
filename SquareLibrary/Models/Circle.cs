using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareLibrary.Models
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        
        public string Calling
        {
            get 
            { 
                throw new NotImplementedException(); 
            }
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
