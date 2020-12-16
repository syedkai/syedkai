using System;
using System.Collections.Generic;
using System.Text;

namespace E8___Interfaces_and_Classes
{
    // sum calculation
    public class Class1 : Itestinterface
    {
         public double sum; bool boolflag;
         Result resultinstance = new Result();

              
        public void Train(double[] dataarray)
        {
            foreach(double o in dataarray)
            {
                sum = sum + o;
            }
            if (sum > 100) boolflag = true;
            else boolflag = false;
            resultinstance.Sumflag = boolflag;
            resultinstance.Sum = sum;
        }

        public Result GetResult()         // storing values to class Result's properties
        {
            return resultinstance;
            throw new NotImplementedException();
        }

        public void LoadResult()         // printing output from class Result
        {
            Console.WriteLine($"{resultinstance.Sumflag}. The sum is {resultinstance.Sum}");
            
        }

        public void SaveResult()
        {

        }

    }
}
