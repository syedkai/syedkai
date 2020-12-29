
using System;
using System.Diagnostics;
using System.Threading;


namespace ParallelProcessing
{
    class Program
    {
        static int numThreads = 150;


        static void Main(string[] args)
        {
            Console.WriteLine("Press any Key to start.");
            Console.ReadKey();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            ParallelClass exe = new ParallelClass();

            // 1. Executes all tasks sequentianally
           //exe.StartSequenced(numThreads, workerFunction);

            // 2.  Executes with spaning of every worker on a single thread. (parallel)
            //exe.StartMultithreadedNative(numThreads, workerFunction);

            // 3. First creates all threads and the run them.
            exe.StartMultithreadedNativeV2(numThreads, workerFunction);

            // 4. Creates Tasks, then starts tasks with waiting on all of them to complete.
            //exe.StartWithTpl(numThreads, workerFunction);

            sw.Stop();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} ms", sw.ElapsedMilliseconds);

        }


        private static void workerFunction(object onFinishDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");

            double r = 202020203030442;
            for (int i = 0; i < 35000000; i++)
            {
                r = r * 1.94536;
            }

            if (onFinishDelegate != null)
            {
                ((Action<string>)onFinishDelegate)(Thread.CurrentThread.Name);
            }

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Stopped thread: {0}", Thread.CurrentThread.Name);
        }
    }
}
