using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var c = new Cat();
            var d = new Dog();

            c.PrintName();
            d.PrintName();
            incrementAnimalAge(c);
            incrementAnimalAge(d);
        }

        private static void incrementAnimalAge(Dog dog)
        {
            dog.Age++;
        }

        private static void incrementAnimalAge(AnimalBase animal)
        {
            animal.Age++;
        }
    }
}
