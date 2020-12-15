using System;
using System.Threading.Tasks;

namespace HelloWorldWithPublish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Counting {0}", i);
                Task.Delay(1000);
            }
            Console.WriteLine("Please enter some character to exit");

            Console.ReadLine();

        }
    }
}
