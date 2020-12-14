using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceEx
{
    public class SumAlgorithm : INewzMLAlgorithm
    {
        private double m_sum;

        public SumAlgorithm()
        {
            this.m_sum = 0;
        }

        public object SumOtherMethod()
        {
            return this.m_sum;
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

        }
    }
}
