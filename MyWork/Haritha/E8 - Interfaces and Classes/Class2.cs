using System;
using System.Collections.Generic;
using System.Text;

namespace E8___Interfaces_and_Classes
{
    class Class2 : Itestinterface
    {
        double average; int sum;
        protected Result resultinstance = new Result();
        
        public void Train(int[] data)
        {
            foreach (int o in data)
            {
                sum = sum + o;
            }
            resultinstance.Average = Convert.ToDouble(sum) / data.Length;
            
        }

        public Result GetResult()
        {
            return resultinstance;
            throw new NotImplementedException();
        }
        public void SaveResult()
        {
            Console.WriteLine("Your results have been saved successfully"); 
        }

        public void LoadResult()
        {
            Console.WriteLine($"{resultinstance.Average} is the Average.");
            Console.WriteLine($"{resultinstance.Median} is the Median.");
            Console.WriteLine($"{resultinstance.Variance} is the Variance.");
            
        }
    }
}
