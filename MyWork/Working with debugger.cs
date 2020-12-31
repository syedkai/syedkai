using System;

namespace HelloWorldWithClass
{
    public class Person
    {

        public string Name;
        public int age;
        public bool Haspet;

        public void Greeting()
        {
            Console.WriteLine("My name is" + Name + " and my age is " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = " Jaffar";
            person.age = 26;
            person.Haspet = true;
            person.Greeting();

        }
    }
}
