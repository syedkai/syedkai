using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace WorkWithInterfaces
{
    public class MedianAlgorithm:IMyInterface
    {
        private double median;
       // public double median1 { get; set; }

        public MedianAlgorithm()
        {
            this.median = 0;
        }
        public object GetResult()
        {
            Console.WriteLine("Median of array is : " + this.median);
            return this.median;

        }




        public void Train(double[] data)
        {
           
            double[] sortedNumbers = (double[])data.Clone();
            Array.Sort(sortedNumbers);
            int size = sortedNumbers.Length;
            int mid = size / 2;
            median = (size % 2 != 0) ? (double)sortedNumbers[mid] : ((double)sortedNumbers[mid] + (double)sortedNumbers[mid - 1] )/ 2;
           


        }

        //public void save()
        //{
        //    MedianAlgorithm median2 = new MedianAlgorithm();
        //    median2.median1 = this.median;
        //    var xs = new XmlSerializer(typeof(AvgAlgorithm));

        //    using (TextWriter text = new StreamWriter(@"esult.xml"))
        //    {
        //        xs.Serialize(text, median2);
        //        text.Close();
        //    }
        //}
        //public void load()
        //{
        //    var xs = new XmlSerializer(typeof(MedianAlgorithm));
        //    using (TextReader load_result = new StreamReader(@"esult.xml"))
        //    {
        //        var temp_result = (MedianAlgorithm)xs.Deserialize(load_result);
        //        median = temp_result.median1;
        //        load_result.Close();
        //        Console.WriteLine("Add read value is" + this.median);

        //    }

        //}
    }
}

