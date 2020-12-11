using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadingSampleNetCorev5._0
{
    class Program
    {


        static int numSequence = 100;

        static int numThreads= 6, coreCount = 0;
        static Stopwatch sw;
        static String runtimenetCoreVer;

        static void Main(string[] args)
        {




            Console.WriteLine("Press any Key to start.");
            Console.ReadKey();
           // var netCoreVer = System.Environment.Version;
            runtimenetCoreVer  = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
            Console.WriteLine(runtimenetCoreVer);
            SystemCoreCount();
            sw = new Stopwatch();
            sw.Start();



            ParallelSamples sample = new ParallelSamples();
            sample.StartJobInSeqence(numThreads, Workerfuntion);
            sw.Stop();
            FormatOutput(1,1);

       
            sw.Restart();
            sample.StartEachJobInOwnThread(numThreads, Workerfuntion);
            sw.Stop();
            FormatOutput(2, numThreads);

            sw.Restart();
            sample.StartJobsInParallelTask(numThreads, Workerfuntion);
            sw.Stop();
            FormatOutput(3, numThreads);

            Console.ForegroundColor = ConsoleColor.Cyan;

        }





        private static void Workerfuntion(Object onFinishDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");
            int r = 1;
      
            for (int i = 0; i < 35000899; i++)
            {
                r = r + 1; 
            }

            if (onFinishDelegate != null)
            {
                ((Action<string>)onFinishDelegate)(Thread.CurrentThread.Name);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Stopped thread: {0}", Thread.CurrentThread.Name);
           
        }


        private static void FormatOutput(int p_type,int numberOfthreds)
        {
            switch (p_type)
            {
                case 1:
                    Console.WriteLine( "Job Approach: Sequencial; framework_version: "+ runtimenetCoreVer+ " cores: " + coreCount + " total_threads: "+ numberOfthreds + " elasped time: " + " h{0} ms", sw.ElapsedMilliseconds);
                    break;
                case 2:
                    Console.WriteLine("Job Approach: Job in Each Thread; framework_version: " + runtimenetCoreVer + " cores: " + coreCount + " total_threads: " + numberOfthreds + " elasped time: " + " h{0} ms", sw.ElapsedMilliseconds);
                    break;
                case 3:
                    Console.WriteLine("Job Approach: Parallel Task; framework_version: " + runtimenetCoreVer + " cores: " + coreCount + " total_threads: " + numberOfthreds + " elasped time: " + " h{0} ms", sw.ElapsedMilliseconds);
                    break;
                 

            }
        }

        private static void SystemCoreCount()
        {
            coreCount = Environment.ProcessorCount;
        }

       



   
    }
}
