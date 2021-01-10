using SampleLib;
using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cat("Hans");
            var d = new Dog();
            c.PrintName();
            d.PrintName();
            incrementAnimaleAge(c);
            incrementAnimaleAge(d);
            MoveAnimal(c);
            MoveAnimal(d);
            FeedAnimal(c);
            FeedAnimal(d);
            var a = new SampleClass();
           
        }

        private static void MoveAnimal(IAnimal animal)
        {
            animal.Move();
        }

        private static void FeedAnimal(IAnimal animal)
        {
            animal.Eat();
        }


        private static void incrementAnimaleAge(AnimalBase animal)
        {
            animal.Age++;
        }
    }
}
