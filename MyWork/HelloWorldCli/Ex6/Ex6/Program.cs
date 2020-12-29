using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calcObj = new Calculator();

            Console.WriteLine("Please enter first int value: ");
            int firstArgs = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second int value: ");
            int secondArgs = int.Parse(Console.ReadLine());

            Console.WriteLine("Addtion of " + firstArgs + " and " + secondArgs + " is : " + calcObj.Addtion(firstArgs,secondArgs));
            Console.WriteLine("Substraction of " + firstArgs + " and " + secondArgs + " is : " + calcObj.Substraction(firstArgs, secondArgs));
            Console.WriteLine("Multiplicaion of " + firstArgs + " and " + secondArgs + " is : " + calcObj.Multiplicaion(firstArgs, secondArgs));
            Console.WriteLine("Devision of " + firstArgs + " and " + secondArgs + " is : " + calcObj.Devision(firstArgs, secondArgs));

            Console.WriteLine("Press Enter key to exit.");
            Console.ReadLine();
        }
    }
}


class Calculator {

    public int Addtion(int firstArgs, int secondArgs) {
        return firstArgs + secondArgs;
    }

    public int Substraction(int firstArgs, int secondArgs)
    {
        return firstArgs - secondArgs;
    }

    public int Multiplicaion(int firstArgs, int secondArgs)
    {
        return firstArgs * secondArgs;
    }

    public int Devision(int firstArgs, int secondArgs)
    {
        return firstArgs / secondArgs;
    }
}
