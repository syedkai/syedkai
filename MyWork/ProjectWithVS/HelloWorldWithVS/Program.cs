using System;
using System.Threading;

namespace HelloWorldWithVS
{
    class Program
    {
        static void Main(string[] args)
        {


            for(int i=0;i<10;i++)
            {
            Console.WriteLine($"Hello World!: {i}");
            Thread.Sleep(500);
                
            }
        }
    }
}
