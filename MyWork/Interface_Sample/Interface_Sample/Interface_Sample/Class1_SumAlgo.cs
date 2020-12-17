using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Sample
{
    public class Class1_SumAlgo : IMyInterface
    {
        private double m_sum;

        public Class1_SumAlgo()
        {
            this.m_sum = 0;
        }

        public object GetResult()
        {
            return this.m_sum;
        }

        public void Train(double[] data)
        {
            foreach(var num in data)
            {
                this.m_sum += num;
            }
        }

        public void save()
        {
            //varr = m_sum;
           // return varr;
        }

        public void load()
        {
           // m_sum = varr;
        }
    }
}
