using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int a = 22;
            double b = 39.01;
            decimal d = 40.123M;


            double ANS = (double)a * (double)b / (double)d;


            Console.WriteLine($"Answer  = {ANS}");

        }
    }
}
