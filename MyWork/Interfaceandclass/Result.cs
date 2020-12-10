using System;
namespace Interfaceandclasses
{
    public class Result : IMyInterface
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

            /*   Array.Sort(data);

               if (n % 2 != 0)
               {
                   med = data[n / 2];
               }

               else

               {
                  med = (data[(n - 1) / 2] + data[n / 2]) / 2.0;
               }
           */

        }
    }
}    