using HelloWorldLibrary;
using System;


namespace HelloWorldWithClass
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int input = 0;

            do
            {
                Console.Write("Hello ! Please type in some number ( equal or greater than 5) : ");

                input = int.Parse(Console.ReadLine());

                Console.WriteLine($"You have entered {input} into the system");
            }
            while (input < 5);
            
            createHeart heart = new createHeart();

            heart.createHeartFromNumber(input);
        }
    }
}
