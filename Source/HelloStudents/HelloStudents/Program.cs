using System;
using System.Runtime.CompilerServices;
using System.Threading;

[assembly: InternalsVisibleTo("UnitTestProject")]

namespace HelloStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyLibrary.MyLib referencedLib = new MyLibrary.MyLib();
            
            var res = referencedLib.Sum(11, 23132);
            Console.WriteLine(referencedLib.Divide(10, 2));
            Console.WriteLine(res);

           /* MyAlgorithm alg = new MyAlgorithm();

            for (int i = 0; i < 10; i++)
            {
                double result = alg.Calculate(i);

                Console.WriteLine("Haritha Test \n changes");

                Console.WriteLine($"Hello Students from Windows! Iteration: {i} generated the result = {result}");

                Thread.Sleep(500);
            }

            Console.WriteLine("Press any key do exit...");
            Console.ReadLine();*/
        }
    }
}
