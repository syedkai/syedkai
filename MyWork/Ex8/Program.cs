using System;

namespace Ex8
{
    public class Program
    {
        static void Main (string[] args)
        {           
        Interface sum = new sum();
        double result = sum.Train();
        Console.WriteLine("SUM = {0}", result);        
        Interface avg = new avg();
        result = avg.Train();
        Console.WriteLine("AVG = {0}", result);
        Console.ReadLine();
        }
    }
}
