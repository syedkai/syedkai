using System;

namespace Additional_E6___debug__delayv2
{

    //navigating through code - F11
    // Skip functions and method calls - F10
    //edit while debugging 
    // run into code using mouse
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Testing debug tools!");
            Console.WriteLine("Please select debug tool to run");
            Console.WriteLine("1. Step through code line by line- F11");
            Console.WriteLine("2. Skip function");
            Console.WriteLine("3. Run into code");
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            { 
                for(int i = 0; i<10; i++)
                {
                    Console.WriteLine($"Counter initialized, now at {i} ");
                    Console.WriteLine("Press F11 to increment counter");
                }
            
            }
            if (c == 2)
            {
                    Console.WriteLine("To Function skip, press F10");
                    HugeFunctiontobeskipped();
                    Console.WriteLine("Is this statement running?");
            }
            if(c == 3)
            {
                Console.WriteLine("Go To Visual Studio, hover mouse over line you want to skip to and click ");
                Console.WriteLine(" This Function has been executed due to mouse click ");
            }

        }

        private static void HugeFunctiontobeskipped()
        {
            Console.WriteLine("Function not skipped");
           // throw new NotImplementedException();
        }
    }
}
