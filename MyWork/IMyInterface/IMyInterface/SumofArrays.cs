using System;
using System.Collections.Generic;
using System.Text;

namespace IMyInterface
{
    class SumofArrays : InterfaceAlgo
    {

        private double sum;

        public SumofArrays()                                // Default Constructor
        {
            this.sum = 0;
        }

        public void DivideofArraySum(double[] data)
        {
            throw new NotImplementedException();
        }

        public object getResult()
        {
            return this.sum;
        }

        public void SumofArray(double[] data)
        {
            foreach (double m in data)        // m is the element and data is the array
            {
                this.sum += m;                  // sum = sum + m ;
            }

        }

        public void AverageofArray(double[] data)
        {

            foreach (double m in data)        // m is the element and data is the array
            {
                this.sum += m;                  // sum = sum + m ;
            }

            this.sum = this.sum / data.Length;    // taking average by dividing with the number of array
        }





    }
}





