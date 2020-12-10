using System;
// using MyMathLibrary;
using Humanizer;


namespace E10___WorkingwithNuGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I have added few nice" +
                " functionalities from NuGet packages!");
            
            int userinput;
            float value;

            // NuGet package copied and packed from local library
            Console.WriteLine("Enter value in milliseconds and I will make it easier for you");
            userinput = int.Parse(Console.ReadLine());
            Console.WriteLine(TimeSpan.FromMilliseconds(userinput).Humanize(5));
            // humanize (5) represents no. of units to describe



            // Referencing from Own Local Library
            // add existing library to solution and add project reference
            Console.WriteLine("Enter a value and I will give you its square root");
            value = float.Parse(Console.ReadLine());

            // Creating instance of class from Local Library
         //  MyMathLib MathLibinstance = new MyMathLib();
            // also can give MyMathLibrary.MyMath........
        //    Console.WriteLine(MathLibinstance.SquareRoot(value));
            
            /* added accounting.js through packet manager in VS
             
             added humanizer through Command Line Interface 
            eg : dotnet add package Humanizer --version 2.8.26 
            
            deleted accounting.js through editing .csproj file*/
        }
    }
}
