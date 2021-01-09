using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication2
{
    /*private / internal public*/ 
    public class MyClass
    {
        public static double GetLength(string input)       /*String Method of class*/
        {
            return input.Length;                  /*length of a string*/
        }
        public double Divide(int a, int b)  /*Instance Method*/
        {
            return a / b;
        }
    }
}
