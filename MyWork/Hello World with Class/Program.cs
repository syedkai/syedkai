using System;

namespace Hello_World_with_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person=new Person();
            person.Name = "Arup Kumar Gope";
            Console.WriteLine(person.Getname());
                
        }
    }
}
