using System;
using UserLibrary;

namespace ConsoleAppWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zu der Wishing well!");
            
            System.Threading.Thread.Sleep(500);

            Console.Write("Wie heißen sie? : ");
            String name = Console.ReadLine();

            System.Threading.Thread.Sleep(300);

            
            int age = -1;
            bool success = false;
            while (!success)
            {
                Console.Write("Wie alt sind Sie? : ");
                String strAge = Console.ReadLine();
                success = int.TryParse(strAge, out age);
            }

            User user = new User
            {
               Name = name,
               Age = age
            };

            Console.WriteLine("----------------------------");
            Console.WriteLine("Ein Momment bitte!");
            Console.WriteLine("----------------------------");

            System.Threading.Thread.Sleep(600);

            Console.WriteLine($"Hallo {user.Name}!");

            System.Threading.Thread.Sleep(300);

            Console.WriteLine(user.AgeMessage());

        }
    }
}
