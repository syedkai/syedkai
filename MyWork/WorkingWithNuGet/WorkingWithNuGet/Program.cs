using System;

namespace WorkingWithNuGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with nuget");



            MyLibrary.MyLib ReferencedLib = new MyLibrary.MyLib();
            var result =ReferencedLib.Add(12, 2);

            Console.WriteLine(result);

            Console.ReadLine();


           

        }
    }
}
