using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ThreadTaskExample
{
    class Program
    {
        static Random random = new Random();
        static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            

            for (int i = 0; i <= 1000; i++)
            {
                var num = random.Next(1, 1000);
                numbers.Add(num);
            }

            Stopwatch sw = new Stopwatch();
            

            ThreadTask sample = new ThreadTask();
            sw.Start();
            sample.StartSequenced(15, sortFunction);
            sw.Stop();
            Console.WriteLine("Sequence {0} ms", sw.ElapsedMilliseconds);
            sw.Reset();
            sw.Start();
            sample.StartMultithreadedNative(15, sortFunction);
            sw.Stop();
            Console.WriteLine("optimal 1 {0} ms", sw.ElapsedMilliseconds);
            sw.Reset();
            //sw.Start();
            //sample.StartMultithreadedNative(15, sortFunction);
            //sw.Stop();
            //Console.WriteLine("optimal 2 {0} ms", sw.ElapsedMilliseconds);

            sw.Start();
            sample.StartWithTpl(15, sortFunction);
            sw.Stop();
            Console.WriteLine("task {0} ms", sw.ElapsedMilliseconds);
            

        }

        private static void sortFunction(object onFinishDelegate)
        {
            //Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");

            
            List<int> tempnumber = new List<int>(numbers);
            tempnumber.Sort();

            if (onFinishDelegate != null)
            {
                ((Action)onFinishDelegate)();
            }

            //Console.WriteLine("Stopped thread: {0}", Thread.CurrentThread.Name);
        }
    }
}
