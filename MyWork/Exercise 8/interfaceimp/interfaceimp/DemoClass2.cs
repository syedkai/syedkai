using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace interfaceimp
{
    class DemoClass2 : IMyinterface1
    {
        double sum, mean, median;
        double variance = 0;
        public void methodtrain(int s, double[] myArray) // Calculate Mean, Median and Vraiance
        {
          
            for (int i = 0; i < s; i++)
            {
                sum = sum + myArray[i];
            }

            mean = sum / s;
            double[] sortedArray = myArray;
            Array.Sort(sortedArray);
            if(s%2==0)
            { 
            median = (sortedArray[(s-1) / 2] + sortedArray[((s-1) / 2) + 1]) / 2;
            }
            else if(s%2==1)
            {
                int indx = (s-1 + 1) / 2;
                 median = sortedArray[indx];
            }
        
            for (int i=0;i<s;i++)
            {
                variance = variance + (Math.Pow((myArray[i] - mean), 2)) / (s - 1);
            
            }
          
        }
            public void save()
        {
            Console.WriteLine("The mean of the data set is {0} ",+mean);
            Console.WriteLine("The Median of the data set is {0}", +median);
            Console.WriteLine("The Variance of the data set is {0} ", +variance);
            string concString ="Mean is " +  mean.ToString() + "\n " + "Median is " + median.ToString() + "\n " + "Variance is " + variance.ToString();
            File.WriteAllText("SavedFile22.txt", concString);
        }

       
       public   void load()
        {
            string[] so = File.ReadAllLines("SavedFile22.txt");
            foreach (string lines in so)
            {
                Console.WriteLine(lines);
            }

          
        }
    }
}
