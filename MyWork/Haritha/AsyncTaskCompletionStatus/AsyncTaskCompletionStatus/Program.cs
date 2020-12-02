using System;
using System.Threading.Tasks;

namespace AsyncTaskCompletionStatus
{
    class Program
    {

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Task Completion Status");
            var t1 = Task.Delay(10000);
            Console.WriteLine("Task1 initialized");
            Console.WriteLine("Task1 completed true or false?");
            Console.WriteLine(t1.IsCompleted);
            // t1 not complete , but t2 executes 
            // without await, delay happens separately
            Console.WriteLine("Task2 initialized");
            var t2 = Task.Delay(10000);
            await t2;   // await makes t2 finish and then only t3 starts
                        // 10 seconds delay 
            Console.WriteLine("Task2 completed true or false?");
            Console.WriteLine(t2.IsCompleted);
            Console.WriteLine("Task 3");
        
        
        }
    }
}
