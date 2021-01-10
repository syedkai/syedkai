using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace WorkWithInterfaces
{
    public class SumAlgorithm : IMyInterface
    {

        private double sum;
       // public double sum1 { get; set; }
        
        public SumAlgorithm()
        {
            this.sum=0;
        }
        


        public object GetResult()
        {
            this.sum = ( this.sum >  100) ? 1 : 0;
            Console.WriteLine("It will print 1 if sum is greater than 100 otherwise 0.So result is : " + this.sum);
            return this.sum;
                 }
      

        public void Train(double[] data)
        {
            foreach (var value in data)
            {
                this.sum += value;
            }
     
        }
       
        
    }
}
