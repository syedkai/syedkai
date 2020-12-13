using System;

namespace HelloWorldWithInterface
{
    public class SumAlgorithm : IMyInterface
    {
        private double sum;

        /// <summary>
        /// constructor
        /// </summary>
        public SumAlgorithm()
        {
            this.sum = 0;
        }

        /// <summary>
        /// return sum value
        /// </summary>
        /// <returns></returns>
        public double GetResult()
        {
            return this.sum;
        }

        /// <summary>
        /// implement train with sum algorithm
        /// </summary>
        /// <param name="data"></param>
        public void Train(double[] data)
        {
            foreach(var number in data)
            {
                this.sum += number;
            }
        }

        public void Save()
        {

        }

        public void Load()
        {

        }

    }
}
