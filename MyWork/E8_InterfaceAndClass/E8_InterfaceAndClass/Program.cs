using System;

namespace E8_InterfaceAndClass
{
    class Program
    {
        static void Main(string[] args)
        {
            IMyInterface imp1 = new Implementation1();
            double[] data = { 1, 2, 4, 3, 7 };
            imp1.Train(data);
            Console.WriteLine("Result of Implementation1 is: " + imp1.GetResult());

            IMyInterface imp2 = new Implementation2();
            imp2.Train(data);
            Console.WriteLine("Result of Implementation2 is: " + imp2.GetResult());
        }
    }
}
