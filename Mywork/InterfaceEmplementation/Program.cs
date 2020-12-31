using System;

namespace InterfaceEmplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EvenNumber even = new EvenNumber();
            var evenreturn = even.Serise();
            int[] evenserise = evenreturn.Item1;
            int eveniter = evenreturn.Item2;
            even.SavingOutput(evenserise, eveniter);
            Console.Write("This is an EVEN serise : ");
            foreach (var item in evenserise)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("");
            


            
            
            OddNumber odd = new OddNumber();
            var oddreturn = odd.Serise();
            int[] oddserise = oddreturn.Item1;
            int odditer = oddreturn.Item2;
            odd.SavingOutput(oddserise, odditer);
            Console.Write("This is a ODD serise : ");
            foreach (var item in oddserise)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("");
            
        }
    }
}
