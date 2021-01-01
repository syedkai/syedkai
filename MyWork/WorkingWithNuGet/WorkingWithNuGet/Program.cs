using System;
using Bank;                         // Using my Package

namespace WorkingWithNuGet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            BankAccount b = new BankAccount(a);
            Console.WriteLine("Your Bank Balance is {0}",a);

            Console.WriteLine("Please Enter the ammount to withdraw: ");
            int c = int.Parse(Console.ReadLine());
            b.WithdrawAmt(c);




        }
    }
}
