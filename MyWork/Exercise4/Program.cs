using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int gcf = LCMHCF.GCD(n1,n2);
            int lcm = LCMHCF.LCM(n1, n2);
            Console.WriteLine("The GCF of the two numbers is "+gcf);
            Console.WriteLine("The LCM of the two numbers is " + lcm);
        }
    }
}
