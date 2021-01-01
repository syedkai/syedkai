using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyInterface sumInterface = new Sum();
            Console.ReadLine();
            Console.WriteLine("Result of Sum : {0}", sumInterface.Train(10, 22));

            IMyInterface avgInterface = new Average();
            Console.WriteLine("Result of Average : {0}", avgInterface.Train(10, 22));
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}