using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class MyClass1 : IMyInterface
    {
        
        
       
        private double sum;
        public Object GetResult()
        {
            return this.sum;
        }

        public void Train(double[] data)
        {
            foreach (double Value in data)
            {
                this.sum += Value;
            }
            if (this.sum >= 100)
            {
                this.sum = 1;
            }
            else
                this.sum = 0;

        }




        }
    }
  
