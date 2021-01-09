using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoolLibrary
{
    /*private / internal public*/ 
    public class MyApi
    {
        public static double GetLength(string input)       /*Static Method of class*/
        {
            return input.Length;                  /*length of a string*/
        }
        public double Divide(int a, int b)  /*Instance Method*/
        {
            return (double)a / (double)b;
        }
    }
}
