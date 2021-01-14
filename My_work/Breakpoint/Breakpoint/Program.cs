using System;

namespace Breakpoint
{
    class Program
    {
        public void Test1()

        {
            Console.WriteLine("first processing");

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("the value of i is", +i);
            }

            Console.WriteLine("second processing");
        }

            static void Main(string[] args)
            {
                Program obj = new Program();
                obj.Test1();
            }
        
    }

}
