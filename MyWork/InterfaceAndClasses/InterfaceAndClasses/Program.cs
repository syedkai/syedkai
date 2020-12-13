using System;

namespace InterfaceAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Male
            IPerson male = new Male();
            display(male);

            System.Threading.Thread.Sleep(200);

            IPerson female = new Female();
            display(female);

            Console.ReadLine();
        }

        private static void display(IPerson person)
        {
            person.hair();
            person.height();
            person.voice();

            Console.WriteLine("-----------------------------");
        }
    }
}
