using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestSolution
{
    public class Squaremath
    {
        public double Area(double length, double breadth)
        {
            return length * breadth;
        }
        public double Perimeter(double length, double breadth)
        {
            return 2 * (length + breadth);
        }
    }
}
