using System;
using school;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i< 2; i++)
            {
                Console.WriteLine("Enter Roll no :  ");
                int roll = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Age :  ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Class :  ");
                int standard = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name:  ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Father Name :  ");
                string fathername = Console.ReadLine();
                Console.WriteLine("Enter Mother Name :  ");
                string mothername = Console.ReadLine();
                Console.WriteLine("Enter Blood Group :  ");
                string bloodgroup = Console.ReadLine();

                Console.WriteLine("Add Another student: ");



                student student1 = new student();
                student1.setstudent(roll, Name, age, standard, fathername, mothername, bloodgroup);
                student1.getstudent();
            }



            for (int i = 0; i< 2; i++)
            {
                Console.WriteLine("Enter ID no :  ");
                int idno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Age :  ");
                int Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name :  ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Subject :  ");
                string subject = Console.ReadLine();
                Console.WriteLine("Enter Blood Group :  ");
                string Bloodgroup = Console.ReadLine();

                Console.WriteLine("Add Another Teacher: ");



                Teacher teacher1 = new Teacher();
                teacher1.setTeacher(Name, idno, Age, Bloodgroup, subject);
                teacher1.getTeacher();
            }

        }
    }
}
