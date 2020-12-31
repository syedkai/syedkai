using System;

namespace InterfaceEmplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EvenNumber even = new EvenNumber();
            int[] evenserise = even.Serise();
            Console.Write("This is an EVEN serise : ");
            foreach (var item in evenserise)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("");
            
            
            OddNumber odd = new OddNumber();
            int[] oddserise = odd.Serise();
            Console.Write("This is a ODD serise : ");
            foreach (var item in oddserise)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("");
        }
    }
}
