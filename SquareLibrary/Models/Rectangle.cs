using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareLibrary.Models
{
    class Rectangle : IShape
    {
        private double a;
        private double b;
        
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
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
