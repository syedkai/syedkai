using HelloWorldWithClass;
using System;

namespace MyApplication
{
    class HelloClass
    {
        string color = "Hello world";

        static void Main(string[] args)
        {
            //HelloClass myObj1 = new HelloClass();
            //HelloClass myObj2 = new HelloClass();
            //Console.WriteLine(myObj1.color);
            //Console.WriteLine(myObj2.color);

            student studentsObj = new student();
            studentsObj.StudentId = 7;
            studentsObj.StudentName = "S M Mehedi Hasan";
            studentsObj.StudentSession = "2020/2021";

            LibraryClass libraryObj = new LibraryClass();
            libraryObj.BookNumber = 23;
            libraryObj.BookName = "Software Engineering";
            libraryObj.BookAuthor = "Kudvenkat";


            Console.WriteLine(libraryObj.BookAuthor+ " " + libraryObj.BookName);
            
        }
    }
}