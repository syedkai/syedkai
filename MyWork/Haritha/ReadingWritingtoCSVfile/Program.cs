using System;
using System.IO;

namespace ReadingWritingtoCSVfile
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, studentid, yearofenrollment;
            string name, csvfilepath;
            csvfilepath = "Studentvalues.txt";
            Console.WriteLine("Hello Enter your values to be stored and read at the next application start!");
            Console.WriteLine("Please Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter your StudentID number");
            studentid = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Please Enter your Age");
            age = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Please Enter your Year of Enrollment");
            yearofenrollment = int.Parse(Console.ReadLine());

            Addrecord(name, studentid, age, yearofenrollment,csvfilepath);
            
            static void Addrecord(string Name,int StudentID, int Age, int Year, string Filepath)
            {
                try
                {
                    // filepath - project/bin/debug/
                    // parameter true - dont overwrite files, just add new
                    using (System.IO.StreamWriter myinstance = new System.IO.StreamWriter(@Filepath, true))
                        {
                            myinstance.WriteLine(Name + "," + StudentID + "," + Age + "," + Year);
                        }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Please enter the input in correct format");
                }
            }

        }
    }
}
