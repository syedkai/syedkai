using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace WorkWithInterfaces
{
    public class AvgAlgorithm : IMyInterface
    {

        private double sum;
        private double _avg;
        //public double sum1 { get; set; }
      //  public double avg1 { get; set; }
        public AvgAlgorithm()
        {
            this._avg = 0;
            this.sum = 0;
        }

        public object GetResult()
        {
            Console.WriteLine("average of result is : " + this._avg);
            return this._avg;
            

        }

        public void Train(double[] data)
        {
            foreach (var value in data)
            {
                this.sum += value;
            }
             _avg = sum / data.Length;
        }

        
    }
}
