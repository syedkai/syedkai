using System;

namespace HelloWorldWithInterface
{
    public class AverageAlgorithm : IMyInterface
    {
        private double avg;
        private double sum;
        /// <summary>
        /// constructor
        /// </summary>
        public AverageAlgorithm()
        {
            this.avg = 0;
        }

        /// <summary>
        /// return value for average method
        /// </summary>
        /// <returns></returns>
        public double GetResult()
        {
            return this.avg;
        }

        /// <summary>
        /// train a model in data
        /// </summary>
        /// <param name="data"></param>
        public void Train(double[] data)
        {
            foreach (var number in data)
            {
                this.sum += number;
            }

            avg = sum / data.Length;
        }

        public void Save()
        {
            
        }

        public void Load()
        {

        }
    }
}
