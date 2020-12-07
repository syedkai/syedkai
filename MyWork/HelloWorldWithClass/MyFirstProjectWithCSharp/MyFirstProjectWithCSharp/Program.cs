using System;
using ClassLibrary1;

namespace MyFirstProjectWithCSharp
{
    class Program
    {
         public class Player
        {
            public string name;
            public int level = 0;

            public Player(string name)
            {
                this.name = name;
            }
            
        }

        static void Main(string[] args)
        {
            Simple sim = new Simple();
            Hard hard = new Hard();

            double num1 = 10, num2 = 20;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Input your player name");

            string playerName = Console.ReadLine();

            Player player1 = new Player(playerName);
            player1.level += 1;

            Console.WriteLine("Your name is: " + player1.name);
            Console.WriteLine("Your level is: " + player1.level);

            Console.WriteLine("Sum: " + sim.Add(num1, num2));
            Console.WriteLine("Div: " + hard.Division(num1, num2));


        }
    }
}
