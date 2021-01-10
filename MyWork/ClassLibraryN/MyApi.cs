using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryN
{
    public class MyApi
    {
        public static double GetLength(string input)
        {
            return input.Length;
        }

        public double Divide(int a, int b)
        {
            return a / b;
        }
    }
}
