using System;
namespace Interfaceandclasses
{
    public class SumAlgorithm : IMyInterface
    {
        private double m_sum;
        public SumAlgorithm()
        {
            this.m_sum = 0;
        }
        public object GetResult()
        {
            return m_sum;
        }

        public void Train(double[] data)
        {

            foreach (var number in data)
            {
                this.m_sum = m_sum + number;
            }
            if (this.m_sum > 100)
            {
                this.m_sum = 1;
            }
            else

            {
                this.m_sum = 0;
            }


        }
    }
}
