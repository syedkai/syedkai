using System;

namespace InterfaceAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ///Sample1();
            double[] data = new double[] { 1.05, 33.2, 44.2, 12.6, 11.21 };

            IMyInterface SumAlgo = new SummationAlgo();

            Sample2(SumAlgo, data);

            Sample2(new AverageMedVar(), data);

            Console.WriteLine("Press any key to quit the party");

            Console.ReadLine();
        }
        ///Implementing interface for the classes
        public static void Sample1()
        {
            double[] data = new double[] { 12.05, 13.2, 44.2, 1.6, 11.21 };

            AverageMedVar average = new AverageMedVar();

            average.Train(data);

            SummationAlgo sum = new SummationAlgo();

            sum.Train(data);


            var result_average = average.GetResult();

            var result = sum.GetResult();

            Console.WriteLine("Average: ");
            Console.WriteLine(result_average);

            Console.WriteLine("SumResult: ");
            Console.WriteLine(result);
        }

        public static void Sample2(IMyInterface algo, double[] data)
        {
            algo.Train(data);

            var SumResult = algo.GetResult();

            Console.WriteLine("Anwser: ");

            Console.WriteLine(SumResult);


        }
    }
}
