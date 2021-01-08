using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesandClasses
{
    public class AverageAlgorithm : IMyMLAlgorithm
    {
        private int m_Sum;

        public AverageAlgorithm()
        {
            this.m_Sum = 0;

        }

        public object GetResult()
        {
            return this.m_Sum;
        }

        public void Train(int[] data)
        {
            foreach (var number in data)
            {
                this.m_Sum += number;
            }

            m_Sum = m_Sum / data.Length;
        }
    }
}
