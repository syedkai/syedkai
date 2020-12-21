using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double[] data = new double[] { 18, 12.8, 21.5, 10, 17.5 };
            // int n = data.Length;

            Class1 sum = new Class1();
            sum.Train(data);
            var sumoutput = sum.GetResult();

            Class2 avg = new Class2();
            avg.Train(data);
            var averageoutput = avg.GetResult();

            Console.WriteLine(sumoutput);
            Console.WriteLine(averageoutput);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
