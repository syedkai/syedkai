﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex8
{
    public class Class2 : IInterface2
    {
        private double m_sum;

        // private double med;

        public Class2()
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
