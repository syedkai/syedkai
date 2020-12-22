using System;
using System.Collections.Generic;
using System.Text;
using MyLibrary1;

namespace Helloworldwithclass
{
    class Fibonaccigenerator
    {
        internal int[] SerieseGenrator(int first_value, int second_value)
        {
            int[] fibonacci = new int[20] {first_value, second_value, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            //Console.WriteLine("from fibonacci class outside loop");
            Summation sum = new Summation();

            for (int i = 2; i < 20; i++)
            {
                //Console.WriteLine("from fibonacci class inside loop");
                int result = sum.Sum(fibonacci[i-1], fibonacci[i-2]);
                //Console.Write(result);
                fibonacci[i] = result;
            }
            //Console.WriteLine("from fibonacci class after loop");
            
            return fibonacci;
        }

    }
}
