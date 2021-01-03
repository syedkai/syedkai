using System;

namespace InterfaceAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AverageMedVar average = new AverageMedVar();

            SummationAlgo sum = new SummationAlgo();

            double[] data = new double[] { 1.05, 33.2, 4.2, 1.6, 1 };

            Console.WriteLine(Train(average, data));

            Console.WriteLine(Train(sum, data));

            //Console.WriteLine("Press any key to quit the party");

            Console.ReadLine();
        }
        ///Implementing interface for the classes
        private static double Train(IMyInterface SolveInterface, double[] data)
        {
            
            return SolveInterface.Train(data);

        }

    }
}
