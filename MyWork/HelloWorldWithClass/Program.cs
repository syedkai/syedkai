using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int var1 = 2;
            int var2 = 5;
            int Result; 
            

            AdditionClass add = new AdditionClass(); 
            Result = add.Add(var1, var2); 

            Console.WriteLine("Result:" + Result);
           
        }
    }
}
