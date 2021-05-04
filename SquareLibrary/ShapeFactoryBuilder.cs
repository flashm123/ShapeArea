using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquareLibrary.Models;

namespace SquareLibrary
{
    /// <summary>
    /// Add state and build the shape by the condition
    /// </summary>
    public class ShapeFactoryBuilder
    {
        private double[] sides = null;
        private double? radius = null;

        /// <summary>
        /// Set the sides of the shape
        /// </summary>
        /// <param name="sides">The sides of the shape</param>
        /// <returns>ShapeFactoryBuilder instance</returns>
        public ShapeFactoryBuilder Sides(params double[] sides)
        {
            this.sides = sides;

            return this;
        }

        /// <summary>
        /// Set the radius of the shape
        /// </summary>
        /// <param name="radius">The radius of the shape</param>
        /// <returns>ShapeFactoryBuilder instance</returns>
        public ShapeFactoryBuilder Radius(double radius)
        {
            this.radius = radius;

            return this;
        }

        /// <summary>
        /// Find area of the shape
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Build().GetArea();
        }

        /// <summary>
        /// Create shape by the provided state properties
        /// </summary>
        /// <returns></returns>
        internal IShape Build()
        {
        	if (radius != null)
            {
            	if (sides == null)
            	{
                	return new Circle(radius.Value);
            	}
            }

            if (sides != null)
            {
            	if (radius == null)
            	{
	                if (sides.Length.Equals(2))
	                {
	                    return new Rectangle(sides[0], sides[1]);
	                }
	
	                if (sides.Length.Equals(3))
	                {
	                    return new Triangle(sides[0], sides[1], sides[2]);
	                }
            	}
            }

            throw new NotSupportedException();
        }
    }
}
