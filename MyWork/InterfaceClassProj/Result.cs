using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceClassProj
{
    class Result : IMyInterface
    {
        private double m_sum;

        // private double med;

        public Result()
        {
            this.m_sum = 0;

            // this.med = 0;
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
            m_sum = m_sum / data.Length;

           
           

        }
    }
}

