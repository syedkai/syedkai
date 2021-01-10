using System;

namespace HelloWorldWithVS
{
    public class Hello
    {

        public string Name;

        public void Greetings()
        {
            Console.WriteLine("Hello World! I am " + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            hello.Name = "Susmita";
            

            hello.Greetings();
        }
    }
}
