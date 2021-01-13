using System;

namespace WorkingWithUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise for Unit Test. test MyLibrary Project");



            MyLibrary.MyLib ReferencedLib = new MyLibrary.MyLib();
            var result =ReferencedLib.Sum(1.7, 2);

            Console.WriteLine(result);

            Console.ReadLine();


           

        }
    }
}
