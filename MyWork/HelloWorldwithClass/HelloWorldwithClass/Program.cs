using System;

namespace HelloWorldwithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter" , "JK Rowling",400);
            book1.Title="Harry Potter";
                book1.Author = "JK Rowling";
            book1.Pages = 400;

            Console.WriteLine("book1.pages");
            Console.ReadLine();
        }
    }
}
