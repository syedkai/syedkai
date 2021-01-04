using System;

namespace WorkingwithUnitTest1
{
    class Program
    {
     
 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyLibrary.MyLib referencedLib = new MyLibrary.MyLib();
            var res = referencedLib.sum(11, 23);

            Console.WriteLine(res);
            Console.WriteLine(referencedLib.Divide(10, 2));
        }


    }
}
