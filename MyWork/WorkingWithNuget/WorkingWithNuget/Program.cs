using System;
using MyLibrary;

namespace WorkingWithNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary.Mylib refLib = new MyLibrary.Mylib();
            var res = refLib.calculate(2.2 , 4.4);
            Console.WriteLine("The result for the caluculation is: "+ res);
        }
    }
}
