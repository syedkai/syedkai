using System;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            stringUtility.StringLibrary clsString = new stringUtility.StringLibrary();
            Console.WriteLine(clsString.StartsWithUpper("Sts"));
        }
    }
}