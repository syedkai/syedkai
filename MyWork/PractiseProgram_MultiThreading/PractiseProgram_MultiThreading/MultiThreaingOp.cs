using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PractiseProgram_MultiThreading
{
    class MultiThreaingOp
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
            ThreadStart obj1 = new ThreadStart(test1);
            Thread T1 = new Thread(obj1);


            ThreadStart obj2 = new ThreadStart(test2);
            Thread T2 = new Thread(obj2);

            ThreadStart obj3 = new ThreadStart(test3);
            Thread T3 = new Thread(obj3);



            Stopwatch obj = new Stopwatch();
            obj.Start();

            T1.Start();
            T2.Start();
            T3.Start();
            T1.Join();
            T2.Join();
            T3.Join();
            obj.Stop();
            Console.ResetColor();
            Console.WriteLine(obj.ElapsedMilliseconds);
          
        }
    }
}
