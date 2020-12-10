using System;

namespace MyMathLibrary
{
    public class MyMathLib
    {
        public Double SquareRoot(double a)
        {
            Double b = Math.Sqrt(a);
            return b;
        }
        public Double Exponentof2(float a)
        {
            Double b = Math.Pow(2,a);
            return b;
        }
        public Double NaturalLogarithm (double a)
        {
            Double b = Math.Log(a);
            return b;
        }


    }
}
