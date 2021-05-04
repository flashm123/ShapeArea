using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareLibrary
{
    public interface IShape
    {
        /// <summary>
        /// The name of the shape
        /// </summary>
        string Calling
        {
            get;
        }

        /// <summary>
        /// Count the area of the shape
        /// </summary>
        /// <returns>The area value</returns>
        double GetArea();
    }
}
