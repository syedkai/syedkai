using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInterface
{
    class Rectangle : IArea
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }
    }
}
