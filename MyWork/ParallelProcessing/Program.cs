using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParalleProcessing
{
    class Program
    {
        static int numThreads = 50;

        static void Main(string[] args)
        {
            //var result = await AddAsync(1, 2);

            //DoSomething().Wait();

            Console.WriteLine("Press any Key to start.");
            Console.ReadKey();
            //Console.ReadLine();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            ParallelSamples sample = new ParallelSamples();

            // 1. Executes all tasks sequentianally
            //sample.StartSequenced(numThreads, workerFunction);

            // 2.  Executes with spaning of every worker on a single thread.st
            //sample.StartMultithreadedNative(numThreads, workerFunction);

            // 3
            //sample.StartMultithreadedNativeV2(numThreads, workerFunction);

            // 4.
            sample.StartWithTpl(numThreads, workerFunction);

            sw.Stop();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} ms", sw.ElapsedMilliseconds);

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "50Threads3net.txt"), true))  // For 50 threads running in dotnet3.1
            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "100Threads3net.txt"), true)) // For 100 threads running in dotnet 3.1
            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "150Threads3net.txt"), true)) // For 150 threads running in dotnet3.1
            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "50Threads5net.txt"), true))  // For 150 threads running in dotnet 5.0
            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "100Threads5net.txt"), true)) //For 100 threads running in dotnet 5.0

           
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "50ThreadsNet5.txt"), true))   // For 50 Threads running in dotnet 5.0
            {
                outputFile.WriteLine("{0} ms", sw.ElapsedMilliseconds);
            }
            Console.ReadLine();
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


        public static Task<int> AddAsync(int i, int j)
        {
            var result = Task<int>.Run(() =>
            {
                return i + j;
            });

            return result;
        }

        public static async Task DoSomething()
        {
            await new Task(() =>
            {
                Task.Delay(50).Wait();
            });

            await Task.Run(() =>
            {
                Task.Delay(50).Wait();
            });
        }
    }

}