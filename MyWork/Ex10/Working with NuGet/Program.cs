using LocalNugetPackage;
using System;

namespace Working_with_NuGet
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 100;
            int b = 200;
            int result;
            CalculateMax ob = new CalculateMax();
            //calling the FindMax method from local Nuget library
            result = ob.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", result);
        }
    }
}
