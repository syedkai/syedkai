using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.name = "Vivek"
            person.age = 26
            person.hasPet = true;

            person.Greeting();
        }
    }
}