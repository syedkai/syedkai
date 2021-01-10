using System;

namespace InterfacesAndClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            ///Sample1();
          
            double[] data = new double[] { 1.2, 22.3, 42.22, 13.65, 44.76 };

            IMyMLAlgorithm sumAlg = new SumAlgorithm();
            Sample2(sumAlg, data);

            Sample2(new AverageAlgorithm(), data);

            Console.WriteLine("Press any key to exit");

            Console.ReadLine();
        }

        /// <summary>
        /// Demonstrate how to implement and use two classes, that implement some math algorithms.
        /// </summary>
        private static void Sample1()
        {
            double[] data = new double[] { 1.2, 22.3, 42.22, 13.65, 44.76 };

            //Sum Algorithm (total sum of all datas)
            SumAlgorithm sum = new SumAlgorithm();

            sum.Train(data);

            var sumRes = sum.GetResult();

            Console.WriteLine(sumRes);

            //Average Algorithm (total avg of all datas)
            AverageAlgorithm avg = new AverageAlgorithm();

            avg.Train(data);

            var averageRes = avg.GetResult();

            Console.WriteLine(averageRes);
        }

        /// <summary>
        /// Demonstrates how to use interfaces
        /// </summary>
        private static void Sample2(IMyMLAlgorithm alg, double[] data)
        {
            alg.Train(data); 
            
            var result = alg.GetResult();

             Console.WriteLine(result);      
        }
    }
}
