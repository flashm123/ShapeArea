using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareLibrary.Models
{
    /// <summary>
    /// The triangle shape
    /// </summary>
    class Triangle : IShape
    {
        private double a;
        private double b;
        private double c;

        internal Triangle(double a, double b, double c)
        {
        	if (((a + b > c) && (c + b > a) && (a + c > b)) == false)
        	{
        		throw new Exception("The triangle doesn't exist.");
        	}
        	
        	this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Check whether the triangle is right using Pythagorean theorem 
        /// </summary>
        /// <returns>true - right; false - not right</returns>
        internal bool IsRight()
        {
            return (a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b)
                ? true
                : false;
        }

        public double GetArea()
        {
            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
