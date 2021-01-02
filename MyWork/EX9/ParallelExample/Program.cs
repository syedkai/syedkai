using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Linq;
namespace ParallelExample
{
    class Program
    {
        static Random random = new Random();
        static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10000000; i++)
            {
                var num = random.Next(1, 10);
                numbers.Add(num);
            }

            Stopwatch sw = new Stopwatch();
            

            ParallelExample sample = new ParallelExample();
            sw.Start();
            sample.StartSequenced(15, randomFunction);
            sw.Stop();
            Console.WriteLine("Sequence {0} ms", sw.ElapsedMilliseconds);
            sw.Reset();

            sw.Start();
            sample.StartMultithreadedNative(15, randomFunction);
            sw.Stop();
            Console.WriteLine("optimal 1 {0} ms", sw.ElapsedMilliseconds);
            sw.Reset();

            sw.Start();
            sample.StartWithTpl(15, randomFunction);
            sw.Stop();
            Console.WriteLine("task {0} ms", sw.ElapsedMilliseconds);
            

        }

        private static void randomFunction(object onFinishDelegate)
        {
            var x= numbers.Sum();
            if (onFinishDelegate != null)
            {
                ((Action)onFinishDelegate)();
            }
        }
    }
}
