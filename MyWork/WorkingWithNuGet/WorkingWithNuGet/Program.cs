using System;

namespace WorkingWithNuGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise for creating NuGet and referencing");



            MyLibrary.MyLib ReferencedLib = new MyLibrary.MyLib();
            var result =ReferencedLib.Add(12, 2);

            Console.WriteLine(result);

            Console.ReadLine();


           

        }
    }
}
