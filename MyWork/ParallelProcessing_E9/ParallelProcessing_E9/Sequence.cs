using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ParallelProcessing_E9
{
    class Sequence
    {
        static void test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor
          = ConsoleColor.Blue;
                Console.WriteLine("Test1: " + i);
                Task.Delay(50).Wait();

            }



        }

        static void test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor
          = ConsoleColor.Red;
                Console.WriteLine("Test2: " + i);
                Task.Delay(100).Wait();
            }

        }

        static void test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor
          = ConsoleColor.Green;
                Console.WriteLine("Test3: " + i);
                Task.Delay(100).Wait();
            }

        }

        static void Main()
        {
            Stopwatch obj = new Stopwatch();
            obj.Start();
            test1();
            test2();
            test3();
            obj.Stop();
            Console.WriteLine(obj.ElapsedMilliseconds);
            Console.ResetColor();
        }


    }
}
