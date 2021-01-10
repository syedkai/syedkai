using System;

namespace WorkWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Exercise with Class and Interface");
            Console.WriteLine();

         //    MethodForClass();

            double[] data = new double[] { 5, 7, 9, 9, 11 };

            //for interfaces


            //IMyInterface sumAlg = new SumAlgorithm();
            MethodForInterface(new SumAlgorithm(), data);
            //IMyInterface avgAlg = new AvgAlgorithm();
           MethodForInterface(new AvgAlgorithm(), data);

            MethodForInterface(new MedianAlgorithm(), data);


            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        //use of Classes

        private static void MethodForClass()
        {
            double[] data = new double[] { 10, 10, 10, 10, 10 };

            //use of two classes

            SumAlgorithm sum = new SumAlgorithm();
            sum.Train(data);
            var sumResult = sum.GetResult();
            //Console.WriteLine("It will print 1 if sum is greater than 100 otherwise 0.So result is : " + sumResult);


            AvgAlgorithm avg = new AvgAlgorithm();
            avg.Train(data);
            var avgResult = avg.GetResult();
           // Console.WriteLine("Average result is : " + avgResult);

        }

        //use of interfaces

        private static void MethodForInterface(IMyInterface alg, double[] data)
        {
            alg.Train(data);
            var result = alg.GetResult();
            
            
        }


    }
}
