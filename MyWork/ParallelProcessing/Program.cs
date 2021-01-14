
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
            Console.WriteLine("Type any key to start");
            Console.ReadKey();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            ParallelClass exe = new ParallelClass();


        
            exe.StartMultithreadedNativeV2(numThreads, workerFunction);

         

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
