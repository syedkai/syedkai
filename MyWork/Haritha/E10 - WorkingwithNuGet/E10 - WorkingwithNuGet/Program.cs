using System;
using Humanizer;


namespace E10___WorkingwithNuGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I have added few nice" +
                " functionalities from NuGet packages!");
            /* added accounting.js through packet manager in VS
             
             added humanizer through Command Line Interface 
            eg : dotnet add package Humanizer --version 2.8.26 
            
            deleted accounting.js through editing .csproj file*/

            int userinput;
            Console.WriteLine("Enter value in milliseconds and I will make it easier for you");
            userinput = int.Parse(Console.ReadLine());
            Console.WriteLine(TimeSpan.FromMilliseconds(userinput).Humanize(5));
            // humanize (5) represents no. of units to describe
        }
    }
}
