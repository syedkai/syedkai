using System;

namespace Calculator
{
    public class Operations
    {
        public static int Multiply(int a,int b)
        {   
            return a*b;
        }
        public int Add(int a, int b)
        {
            return a+b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public static double Divide(int a, int b)
        {
            return (double)a/b;
        }
    }
}
