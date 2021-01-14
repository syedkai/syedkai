using System;

namespace Breakpoint_Program
{
    class Program
    {

        public void Test1()

        {
            Console.WriteLine("First Processing Start");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("The Value of i is :" +i);

            }

            Console.WriteLine("Second Processing Start");


            for (int x = 0; x < 100; x++)
            {
                Console.WriteLine("The Value of x is :" + x);

            }

        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.Test1();

        }
    }
}
