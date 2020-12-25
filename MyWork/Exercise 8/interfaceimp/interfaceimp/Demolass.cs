using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace interfaceimp
{
    class Democlass : IMyinterface1
    {
        double p;
        double[] myArray;
        public void methodtrain(int s, double[] myArraynew)
        {
            myArray = new double[s];
            Console.WriteLine("Please enter the numbers");
            for (int i = 0; i < s; i++)
            {
                int g = int.Parse(Console.ReadLine());
                myArray[i] = g;
            }
           
             p = myArray[0];
            for (int i = 1; i < s; i++)
            {
             p = p + myArray[i];
            }
            if (p > 100)
            {
                int result = 1;
                Console.WriteLine(result);
            }
            else if (p < 100)
            {
                int result = 0;
                Console.WriteLine(result);
            }
           
       }

        public double[] InputArray
        {
            get
            {
                return myArray;
            }
        }
        public void save()
        {
          File.WriteAllText("SavedFile.txt",p.ToString() );
          Console.WriteLine("Result has been saved to file SavedFile.txt");
        }
        public void load()
        {
         string s = File.ReadAllText("SavedFile.txt");
            Console.WriteLine("The loaded result is {0} ",s);
       }
    }
}

