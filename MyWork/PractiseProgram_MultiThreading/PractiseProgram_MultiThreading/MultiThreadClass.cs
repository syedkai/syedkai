using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace PractiseProgram_MultiThreading
{
    class MultiThreadClass
    {
        static void test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1: " +i);

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
            
       static void test4(object max)
       {
           int a = Convert.ToInt32(max);
           for (int i = 0; i < a; i++)
           {
               Console.WriteLine("Test4: " + i);
           }

       }
       


        


        static void Main(string[] args)

        {
            


            
              ThreadStart obj = new ThreadStart(test1);
              Thread T1 = new Thread(obj);

              ThreadStart obj2 = test2;
              Thread T2 = new Thread(obj2);

              Thread T3 = new Thread(test3);

             // ParameterizedThreadStart obj3 = new ParameterizedThreadStart(test4);
             // Thread T4 = new Thread(obj3);

              Stopwatch obj4 = new Stopwatch();
              obj4.Start();
              T3.Start();
              T1.Start();
              T2.Start();
             // T4.Start(50);
              T1.Join();
              T2.Join();
              T3.Join();
           //   T4.Join();


              obj4.Stop();
            

              /*
            test1();
            test2();
            test3();
            test4(50);

              */

            Console.WriteLine(obj4.ElapsedMilliseconds);
             



        }
    }
}
