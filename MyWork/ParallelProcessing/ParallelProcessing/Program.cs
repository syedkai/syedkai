using ParallelProcessing.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ParallelProcessing
{
    class Program
    {
        private static string path = $"{Directory.GetCurrentDirectory()}/output.csv";
        static void Main(string[] args)
        {

            var numOfThreads = 50;
            var repetition = 20;

            List<Result> records = new List<Result>();
            for (int i = 0; i < repetition; i++)
            {
                var record = new Result();

                // Initialize and start the stopwatch
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                Console.WriteLine("------------------Using Squential--------------------------");
                Parallel parallel = new Parallel();
                parallel.sequenceTask(numOfThreads, callback);

                stopWatch.Stop();
                record.Sequential = stopWatch.ElapsedMilliseconds;

                Console.WriteLine("Total Elapsed Time = {0} ms", stopWatch.ElapsedMilliseconds);
                Console.WriteLine("--------------------------End--------------------------");


                Console.WriteLine("------------------Using New Thread--------------------------");
                stopWatch.Restart();
                parallel.ownThreadTask(numOfThreads, callback);

                stopWatch.Stop();
                record.Thread = stopWatch.ElapsedMilliseconds;

                Console.WriteLine("Total Elapsed Time = {0} ms", stopWatch.ElapsedMilliseconds);
                Console.WriteLine("--------------------------End--------------------------");


                Console.WriteLine("------------------Using Task--------------------------");
                stopWatch.Restart();
                parallel.parallelTask(numOfThreads, callback);
                
                stopWatch.Stop();
                record.Parallel = stopWatch.ElapsedMilliseconds;

                Console.WriteLine("Total Elapsed Time = {0} ms", stopWatch.ElapsedMilliseconds);
                Console.WriteLine("--------------------------End--------------------------");

                records.Add(record);
            }

            // Initialize our CSV class (Helper class to write to csv)
            var csv = new CSV<Result>(path);
            csv.save(records);
            Console.ReadLine();
        }

        private static void callback(object onComplete)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} : Start Thread name {1}", Thread.CurrentThread.ManagedThreadId,Thread.CurrentThread.Name);
            Console.ResetColor();

            Random random = new Random();
            long count = 9999;
            long total = 0;
            for (int i = 0; i < count; i++) {
                total += random.Next(100);
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
