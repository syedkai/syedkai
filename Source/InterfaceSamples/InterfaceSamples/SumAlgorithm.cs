using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSamples
{
    public class SumAlgorithm : IMyMLAlgorithm
    {
        private double m_Sum;

        public SumAlgorithm()
        {
            this.m_Sum = 0;

        }

        public object SomeOtherMethod()
        {
            return this.m_Sum;
        }

        public object GetResult()
        {
            return this.m_Sum;
        }

        public void Train(double[] data)
        {
            foreach (var number in data)
            {
                this.m_Sum += number;
            }
        }
    }
}
