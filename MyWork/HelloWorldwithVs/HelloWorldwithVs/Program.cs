using System;

namespace HelloWorldwithVs
{
    class Program
    {
        static void Main(string[] args)
        {
            string SecretWord = "Giraffe";
            string guess = "";
            while(guess!= SecretWord)
            {
                Console.Write("Enter Guess:");
                    guess = Console.ReadLine();
            }

            Console.Write("You Win!");
            Console.ReadLine();
        }
    }
}
