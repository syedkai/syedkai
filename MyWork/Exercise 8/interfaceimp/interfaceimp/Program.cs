using System;
using System.Threading;

namespace interfaceimp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arbitraryArray = new double [] { 0 };
            Console.WriteLine("Enter the number of elements");
            int elements = int.Parse(Console.ReadLine());
            Democlass myObj = new Democlass();
            myObj.methodtrain(elements, arbitraryArray);
            double[] fetchedArray = myObj.InputArray;
            myObj.save();
            Thread.Sleep(10000);
            myObj.load();
            
            DemoClass2 myObj2 = new DemoClass2();
            myObj2.methodtrain(elements, fetchedArray);
            myObj2.save();
            myObj2.load();

        }
    }
}
