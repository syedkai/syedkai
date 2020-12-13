using System;

namespace Interfaces
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FirstApproach first = new FirstApproach();
            SecondApproach second = new SecondApproach();
            double[] _data = { 1, 2, 4, 5, 6.5, 63.4 };
            Console.WriteLine(Train(first, _data));
            Console.WriteLine(Train(second, _data));

        }

        private static double Train(IMyInterface myInterface, double[] data)
        {
          return  myInterface.Train(data);
        }
    }
}
