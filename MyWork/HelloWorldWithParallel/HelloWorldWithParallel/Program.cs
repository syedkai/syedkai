using System;
using System.Diagnostics;
using System.Threading;

namespace HelloWorldWithParallel
{
    class Program
    {
        static int numThreads = 100;
        //public static int rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("This a demonstration of Threading by compared methods with Threading and without Threading.");
            Console.WriteLine("Press any key to start");
            Console.ReadLine();

            // timer
            Stopwatch sw = new Stopwatch();

            ParallelClass task = new ParallelClass();

            // 1. Single Thread
            sw.Start();
            task.StartJob(numThreads, workerFunction);
            sw.Stop();

            // 2. Job in its own Thread
            //sw.Start();
            //task.StartJobInItsThread(numThreads, workerFunction);
            //sw.Stop();

            // 3. Jobs in parallel
            //sw.Start();
            //task.StartJobParallel(numThreads, workerFunction);
            //sw.Stop();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Elapsed time : {0} ms", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        /// <summary>
        /// run a random function
        /// </summary>
        /// <param name="OnfinishDelegate"></param>
        private static void workerFunction(object OnFinishDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");

            double r = 202020203030442;
            int loop = 350000000;
            double factor = 1.5;

            for (int i = 1; i < loop; i++)
            {
                r = r * factor;
            }

            if (OnFinishDelegate != null)
            {
                ((Action<string>)OnFinishDelegate)(Thread.CurrentThread.Name);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Stop Thread: {0}", Thread.CurrentThread.Name);
        }
    }
}
