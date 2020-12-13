using System;
using System.Diagnostics;
using System.Threading;

namespace ParallelProcessing
{
    class Program
    {
        static void Main(string[] args)
        {

            var numOfThreads = 10;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Console.WriteLine("------------------Using Squential--------------------------");
            Parallel parallel = new Parallel();
            parallel.sequenceTask(numOfThreads, callback);

            stopWatch.Stop();
            Console.WriteLine("Total Elapsed Time = {0} ms", stopWatch.ElapsedMilliseconds);
            Console.WriteLine("--------------------------End--------------------------");


            Console.WriteLine("------------------Using New Thread--------------------------");
            stopWatch.Restart();
            parallel.ownThreadTask(numOfThreads, callback);
            stopWatch.Stop();
            Console.WriteLine("Total Elapsed Time = {0} ms", stopWatch.ElapsedMilliseconds);
            Console.WriteLine("--------------------------End--------------------------");


            Console.WriteLine("------------------Using Task--------------------------");
            stopWatch.Restart();
            parallel.parallelTask(numOfThreads, callback);
            stopWatch.Stop();
            Console.WriteLine("Total Elapsed Time = {0} ms", stopWatch.ElapsedMilliseconds);
            Console.WriteLine("--------------------------End--------------------------");

            Console.ReadLine();
        }

        private static void callback(object onComplete)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} : Start Thread name {1}", Thread.CurrentThread.ManagedThreadId,Thread.CurrentThread.Name);
            Console.ResetColor();

            long count = 99999999;
            long total = 0;
            for (int i = 0; i < count; i++) {
                total += (i + 1) * count / 50*16;
            }

            if (onComplete != null)
            {
                ((Action<String>) onComplete)(Thread.CurrentThread.Name);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} : Stop Thread name {1}", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.Name);
            Console.ResetColor();
        }
    }
}
