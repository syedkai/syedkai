using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorldWithParallel
{
    class Program
    {
        static int numThreads = 100;
        // public static int rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("This a demonstration of Threading by compared methods with Threading and without Threading.");

            Console.WriteLine("Input your expected Thead number : ");
            numThreads = Console.Read();

            Console.WriteLine("Press any key to start");
            Console.ReadLine();


            int loop = 20;

            double[] listSingleThread = new double[loop];
            double[] listMultiThread = new double[loop];

            // timer
            Stopwatch sw = new Stopwatch();

            ParallelClass task = new ParallelClass();


            for (int i = 0; i<loop; i++)
            {
                // 1. Single Thread
                sw.Start();
                task.StartJob(numThreads, workerFunction);
                sw.Stop();
                //listSingleThread[i] = sw.ElapsedMilliseconds;

                // 2. Job in its own Thread
                sw.Start();
                task.StartJobInItsThread(numThreads, workerFunction);
                sw.Stop();

                // 3. Jobs in parallel
                sw.Start();
                task.StartJobParallel(numThreads, workerFunction);
                sw.Stop();

            }

           

            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine($"time used : {sw.ElapsedMilliseconds} ms");

            Console.ReadLine();
        }

        /// <summary>
        /// run a random function
        /// </summary>
        /// <param name="OnfinishDelegate"></param>
        private static void workerFunction(object OnfinishDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");

            double r = 350000000000;
            int loop = 20000000;
            double factor = 1.5;

            for (int i = 1; i < loop; i++)
                r += r* factor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Stop Thread: {0}", Thread.CurrentThread.Name);
        }

        public static Task<int> AddAsynce(int i, int j)
        {
            var result = Task<int>.Run(() =>
            {
                return i + j;
            });

            return result;
        }

        public static async Task DelaySomething()
        {
            await new Task(() =>
            {
                Task.Delay(5000).Wait();
            });

            await Task.Run(() =>
            {
                Task.Delay(5000).Wait();
            });
        }
    }
}
