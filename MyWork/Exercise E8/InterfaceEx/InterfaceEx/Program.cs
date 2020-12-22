using System;

namespace InterfaceEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Universe!");

            //Example1();

            ///Crating Interface of Database inorder to store data. 
            //IDatabase dal;
            //dal.SaveData(data);
            //data = dal.QueryData("Best data");


            double[] data = new double[] { 2.3, 23.4, 33.3, 22.11, 45.33 };

            INewzMLAlgorithm alg = new SumAlgorithm();
            
            Example2(alg, data);

            Example2(new AverageAlgorithm(), data);

            // Demonstrates casting

            if (alg is SumAlgorithm)
            {
                SumAlgorithm castedSum = (SumAlgorithm)alg;
            }

            if (alg is AverageAlgorithm)
            {
                AverageAlgorithm avgAlg = (AverageAlgorithm)alg;
            }

            Console.WriteLine("Press any key to exit.");

            Console.ReadLine();
        }


        /// <summary>
        /// Shows how to use and implement two classes, that implements some math Algorithms.
        /// </summary>
        private static void Example1()
        {
            double[] data = new double[] { 2.3, 23.4, 33.3, 22.11, 45.33 };

            SumAlgorithm sum = new SumAlgorithm();
            
            sum.Train(data);

            var sumRes = sum.GetResult();

            Console.WriteLine(sumRes);

            AverageAlgorithm avg = new AverageAlgorithm();

            avg.Train(data);

            var averageRes = avg.GetResult();

            Console.WriteLine(averageRes);
        }


        /// <summary>
        /// How to use interfaces.
        /// </summary>
        private static void Example2(INewzMLAlgorithm alg, double[] data)
        {
            alg.Train(data);

            var result = alg.GetResult();

            Console.WriteLine(result);
        }
    }
}
