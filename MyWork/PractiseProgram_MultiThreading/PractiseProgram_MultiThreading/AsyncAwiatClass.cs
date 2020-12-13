using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram_MultiThreading
{
    class AsyncAwiatClass
    {

        static async void test1 ()

        {
            Console.WriteLine("Test1 is called");
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(1000);

                Console.WriteLine("Test 1 is Executing: " + i);

            }
            Console.WriteLine("Test1 is Completed");


        }
        static async void test2()

        {
            Console.WriteLine("Test2 is Called");
            await Task.Delay(10000);
            Console.WriteLine("Test2 is Completed");
            

        }
        static async void test3()

        {

            Console.WriteLine("Test3 is called");
            for (int i = 0; i < 100; i++)
            {
               await Task.Delay(1000);

                Console.WriteLine("Test 3 is Executing: " + i);

            }
            Console.WriteLine("Test3 is Completed");
        }
            
        static void Main()

        {
            test1();
            test2();
            test3();

            Console.ReadLine();
        }
    
    
    
    }

}
