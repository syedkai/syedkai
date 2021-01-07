using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("my name");
            string a = "sami ";            
            string b = "patwary";
            
            Class1 d;
            d = new Class1();
            string e=d.add(a, b);
            Console.WriteLine(e);
        }
    }
}
