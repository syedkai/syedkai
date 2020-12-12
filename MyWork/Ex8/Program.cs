using System;

namespace Ex8
{
    public class Program
    {
        static void Main (string[] args)
        {           
        IInterface2 f = new Class1();
        int result = f.Calculation();
        Console.WriteLine("Class 1 result = {0}", result);        
        IInterface2 k = new Class2();
        result = k.Calculation();
        Console.WriteLine("Class 2 result = {0}", result);
        Console.ReadLine();
        }
    }
}
