using System;
using Humanizer;
using Librarynuget;
using MyMathLibrary;

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
            string hexinput,binoutput; 

            // NuGet package - created and uploaded to nuget.org- referencing online
            Console.WriteLine("Enter hexadecimal string for conversion to binary");
            hexinput = Console.ReadLine();
            CanonicalForm hexbinary = new CanonicalForm();
            binoutput = hexbinary.HexStringToBinary(hexinput);
            Console.WriteLine("The result is :" + binoutput );

            // NuGet package copied and packed from local source - offline
            Console.WriteLine("Enter value in milliseconds and I will make it easier for you");
            userinput = int.Parse(Console.ReadLine());
            Console.WriteLine(TimeSpan.FromMilliseconds(userinput).Humanize(5));
            // humanize (5) represents no. of units to describe


            Console.WriteLine("Enter a value and I will give you its square root");
            value = float.Parse(Console.ReadLine());

            // Creating instance of class from Local Library
              MyMathLib MathLibinstance = new MyMathLib();
            // also can give MyMathLibrary.MyMath........
              Console.WriteLine(MathLibinstance.SquareRoot(value));
             
           //  added humanizer through Command Line Interface 
           // eg : dotnet add package Humanizer --version 2.8.26 
            
          
        }
    }
}
