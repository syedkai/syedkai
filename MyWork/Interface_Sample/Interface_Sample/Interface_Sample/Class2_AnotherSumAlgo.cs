using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Sample
{
    class Class2_AnotherSumAlgo:IMyInterface
    {
        private double m_sum;

        public Class2_AnotherSumAlgo()
        {
            this.m_sum = 0;
        }

        public object GetResult()
        {
            return this.m_sum;
        }

        public void Train(double[] data)
        {
            foreach (var num in data)
            {
                this.m_sum += num;
            }
            m_sum = m_sum / data.Length;
        }
    }
}
