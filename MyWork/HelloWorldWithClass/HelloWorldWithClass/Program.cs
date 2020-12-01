using System;

namespace HelloWorldWithClass
{
    class Program
    {
        public static void Main(string[] args)

        {
            Student newstudent = new Student("Jiji", 18, "Indian");
            Car newcolor = new Car("White");
            School newschool = new School("Carmel Convent");

            Console.WriteLine(newstudent.toString());
            Console.WriteLine(newcolor.aboutcar());
            Console.WriteLine(newschool.aboutschool());
        }        
        
    }
}
