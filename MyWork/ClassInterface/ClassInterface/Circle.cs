using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInterface
{
    class Circle : IArea
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
