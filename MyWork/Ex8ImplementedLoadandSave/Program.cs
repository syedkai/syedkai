using System;

namespace Interfaceandclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double[] data = new double[] { 22.5, 55.5, 27.5, 10.5, 15.1 };
            // int n = data.Length;

            SumAlgorithm sum = new SumAlgorithm();
            sum.Train(data);
            var output = sum.GetResult();

            sum.save();
            sum.load();

            Average avg = new Average();
            avg.Train(data);
            var resoutput = avg.GetResult();

            avg.save();
            avg.load();

            Console.WriteLine("sum " + output );
            Console.WriteLine("avg " + resoutput);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        
    }
}
