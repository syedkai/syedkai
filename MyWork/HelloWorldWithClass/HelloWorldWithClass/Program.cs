using System;
using Info;


namespace HelloWorldWithClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 newBook = new Class1("Robert T Kiyosaki", "Rich Dad Poor Dad", "Penguin Publishers");
            Console.WriteLine(newBook.Output());


        }
    }

}  