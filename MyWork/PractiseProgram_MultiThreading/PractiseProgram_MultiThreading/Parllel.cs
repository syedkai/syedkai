using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PractiseProgram_MultiThreading
{
    class Parllel
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
            Task T1 = new Task(test1);
            Task T2 = new Task(test2);
            Task T3 = new Task(test3);


            obj.Start();

            T1.Start(); T2.Start(); T3.Start();
            T1.Wait(); T2.Wait(); T3.Wait();
            obj.Stop();
            Console.ResetColor();
            Console.WriteLine(obj.ElapsedMilliseconds);



        }
    }
}
