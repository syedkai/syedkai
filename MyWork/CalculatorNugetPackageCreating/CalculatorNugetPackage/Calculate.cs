using System;

namespace CalculatorNugetPackage
{
    public class Calculate
    {
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Divide(double a, double b)
        {
            return (double)a / b;
        }
    }
}
