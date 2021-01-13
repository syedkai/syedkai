using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace E9___Parallel_Processing
{
    class Program
    {
        static int numThreads = 100;

        // Rotating 1 large jpeg image in Sequential, Parallel and Threading
        // Adding delay of 500 ms in each iteration.
        static string[] files = Directory.GetFiles(@"D:\Haritha\Frankfurt Uni\Schedule 1st semester\Software Engineering\se-cloud-2020-2021\MyWork\Haritha\E9 - Parallel Processing\Original", "*.jpg");
        static string newpath = @"D:\Haritha\Frankfurt Uni\Schedule 1st semester\Software Engineering\se-cloud-2020-2021\MyWork\Haritha\E9 - Parallel Processing\Modified";
       static AlgorithmforMultiSingleThreading instance = new AlgorithmforMultiSingleThreading();

        static void Main(string[] args)
        {
            Directory.CreateDirectory(newpath);
            Console.WriteLine("Press any Key to start.");
            Console.ReadKey();
            //Console.ReadLine();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Executes all jobs sequentianally
           // instance.Sequential(numThreads, workerFunction);

            // 2.  Executes with number of threads = no of cores(4)

             // instance.Multicore(2,numThreads, workerFunction); // 
            //instance.Multicore(3,numThreads, workerFunction);
            // instance.Multicore(4, numThreads, workerFunction);

            // 3. Executes rotation of image, each in one thread, so CONTEXT SWITCHING 
            // instance.Multicontextswitch(numThreads, workerFunction);

            // 4. Execute with internal scheduler parallel
             instance.Parallel(numThreads, workerFunction);
            
            sw.Stop();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} ms", sw.ElapsedMilliseconds);

            Console.ReadLine();
        }

        private static void workerFunction(object onFinishDelegate)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow");

            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");

            string fileorig = Path.GetFileName(files[0]);
            Console.WriteLine(fileorig);
                string filename = Thread.CurrentThread.ManagedThreadId+".jpg";
                var bitmap = new Bitmap(files[0]);

                bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                bitmap.Save(Path.Combine(newpath, filename));

            Task.Delay(1000);
                        
            if (onFinishDelegate != null)
            {
                ((Action<string>)onFinishDelegate)(Thread.CurrentThread.Name);
                
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue");

            Console.WriteLine("Stopped thread: {0}", Thread.CurrentThread.Name);
        }

        
    }

}
