using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadingSampleNetCorev5._0
{
    class Program
    {


        static int numSequence = 100;

        static void Main(string[] args)
        {

            Console.WriteLine("Press any Key to start.");
            Console.ReadKey();
           // var netCoreVer = System.Environment.Version;
            var runtimenetCoreVer = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
            Console.WriteLine(runtimenetCoreVer);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ParallelSamples sample = new ParallelSamples();
            sample.StartJobInSeqence(numSequence, Workerfuntion);
            sw.Stop();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(runtimenetCoreVer+ " has taken {0} ms to run the job in Sequence", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static void Workerfuntion(Object onFinishDelegateFunction)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");
            int r = 1;
      
            for (int i = 0; i < 35000899; i++)
            {
                r = r + 1; 
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Stopped thread: {0}", Thread.CurrentThread.Name);
           
        }



   
    }
}
