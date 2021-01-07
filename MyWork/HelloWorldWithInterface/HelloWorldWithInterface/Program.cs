using System;
using System.IO;

namespace HelloWorldWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double[] data = new double[] { 100.0, 212.5, 12, 50.4, 21.5};

            IMyInterface sumAlg = new SumAlgorithm();

            IMyInterface avgAlg = new AverageAlgorithm();

            string sum_saveFilename = "sumTrainResult.csv";

            string avg_saveFilename = "avgTrainResult.csv";

            double prevResult = 0;

            // Try to load sum tained result from last time
            if (File.Exists(sum_saveFilename))
            {
                prevResult = sumAlg.Load(sum_saveFilename);
                Console.WriteLine($"Previous sum result is {prevResult}");
            }

            // Try to load average tained result from last time
            if (File.Exists(avg_saveFilename))
            {
                prevResult = avgAlg.Load(avg_saveFilename);
                Console.WriteLine($"Previous avg result is {prevResult}");
            }


            // Train some model
            double sumResult = TrainModel(sumAlg, data, sum_saveFilename);
            Console.WriteLine($"Train model with Sum algorithm has output : {sumResult}");

            double avgResult = TrainModel(avgAlg, data, avg_saveFilename);
            Console.WriteLine($"Train model with Average algorithm has output : {avgResult}");

            Console.WriteLine("Press any key to end session.");
            Console.ReadLine();
        }

        /// <summary>
        /// Train a model and return a value base on method
        /// </summary>
        /// <param name="alg"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private static double TrainModel(IMyInterface alg, double[] data, string saveFilename)
        {
            alg.Train(data);

            double output = alg.GetResult();

            alg.Save(saveFilename);

            return output;
        }
    }
}
