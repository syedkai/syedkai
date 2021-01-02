using System;
namespace ExerciseE10
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyLibrary.MyLib referencedLib = new MyLibrary.MyLib();
            var res = referencedLib.Calculate(11, 23);

            Console.WriteLine(res);
            Console.WriteLine(referencedLib.divide(10, 2));
        }


    }
}