using System;

namespace HelloWorldWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Welcome, User! Please Enter your name");
            string name = user.getName();
            Console.WriteLine($"Hi {name}! How old are you?");
            int age = user.getAge();
            Console.WriteLine($"Welcome {name}! You are {age} years old :)");
        }
    }
}
