using System;

namespace Interfaceandclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double[] data = new double[] { 22.5, 55.5, 27.5, 10.5 };
            // int n = data.Length;

            SumAlgorithm sum = new SumAlgorithm();
            sum.Train(data);
            var output = sum.GetResult();

            Result avg = new Result();
            avg.Train(data);
            var resoutput = avg.GetResult();

            Console.WriteLine(output);
            Console.WriteLine(resoutput);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
