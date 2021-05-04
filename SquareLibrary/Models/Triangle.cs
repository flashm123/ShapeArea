using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareLibrary.Models
{
    class Triangle : IShape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
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
