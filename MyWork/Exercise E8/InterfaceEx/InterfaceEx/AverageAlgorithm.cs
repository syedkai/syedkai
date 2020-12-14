using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceEx
{
    public class AverageAlgorithm : INewzMLAlgorithm
    {
        private double m_sum;

        public AverageAlgorithm()
        {
            this.m_sum = 0;
        }
        public object GetResult()
        {
            return this.m_sum;
        }

        public void Train(double[] data)
        {
            foreach (var number in data)
            {
                this.m_sum = this.m_sum + number;
            }

            m_sum = m_sum / data.Length;
        }
    }
}
