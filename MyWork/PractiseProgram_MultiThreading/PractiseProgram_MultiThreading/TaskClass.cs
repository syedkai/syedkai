using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PractiseProgram_MultiThreading
{
    class TaskClass
    {
        static void test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1: " + i);

                if (i == 50)
                {
                    Console.WriteLine("Wait 10 Seconds in test1");
                    Task.Delay(10000).Wait();
                }
            }



        }

        static void test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2: " + i);
            }

        }

        static void test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3: " + i);
            }

        }

        

        static void Main()

        {
            Task obj = new Task(test1);
            Task obj1 = new Task(test2);
            Task obj2 = new Task(test3);

            Stopwatch obj4 = new Stopwatch();
            obj4.Start();

            obj.Start(); obj1.Start(); obj2.Start();
          //  obj.Wait(); obj1.Wait(); obj2.Wait();
            obj4.Stop();
            Console.WriteLine(obj4.ElapsedMilliseconds);












        }

    }
}
