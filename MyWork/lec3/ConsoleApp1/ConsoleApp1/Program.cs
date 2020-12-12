using MyApplication;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //await LoopSample();
            RunClassSample();
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        public static void RunClassSample() {
            Console.WriteLine("WRITE SOMETHING to find the length");
            var txt=Console.ReadLine();
            double tx=MyClass.GetLength(txt);

            Console.WriteLine($"Length={tx}");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>N.A</returns>
        private static async Task LoopSample()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Counter{n}.");
                await Task.Delay(1000);

            }
        }
        /*static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");

                int n = 5;
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Counter{n}.");
                Task.Delay(500).ContinueWith((t)=> {
                    Console.WriteLine("Done with Delay");
                });

            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
         }*/

    }
}
