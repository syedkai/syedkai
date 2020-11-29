using System;

namespace HelloWorldWithClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClassStudentInformation newBook = new ClassStudentInformation("Robert T Kiyosaki", "Rich Dad Poor Dad", "Penguin Publishers");
            Console.WriteLine(newBook.Output());
          

        }
    }
}
