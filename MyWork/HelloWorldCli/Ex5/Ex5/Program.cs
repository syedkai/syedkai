using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentInfoObj = new Student();

            studentInfoObj.age = 21;
            studentInfoObj.name = "Elon";

            studentInfoObj.studentInfo();

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
