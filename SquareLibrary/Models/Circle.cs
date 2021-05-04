using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareLibrary.Models
{
    class Circle : IShape
    {
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
