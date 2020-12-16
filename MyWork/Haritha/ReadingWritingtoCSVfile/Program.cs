using System;
using System.IO;

namespace ReadingWritingtoCSVfile
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, studentid, yearofenrollment;
            string name, csvfilepath, csvfilepath2;
            csvfilepath = "Studentvalues.txt"; // history of all values
            csvfilepath2 = "LastRecordonly.txt"; // holds last value only
            Console.WriteLine("Hello Enter your values to be stored and read at the next application start!");
            Console.WriteLine("Please Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter your StudentID number");
            studentid = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Please Enter your Age");
            age = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Please Enter your Year of Enrollment");
            yearofenrollment = int.Parse(Console.ReadLine());

            Addrecord(name, studentid, age, yearofenrollment,csvfilepath,csvfilepath2);
            

            //Writing to CSV 
            static void Addrecord(string Name,int StudentID, int Age, int Year, string Filepath, string Filepath2)
            {
                try
                {
                    // Streamwriter- class, myinstance - its object
                    // filepath - project/bin/debug/
                    // parameter true - dont overwrite files, just add new
                    using (System.IO.StreamWriter myinstance = new System.IO.StreamWriter(@Filepath, true))
                        {
                            myinstance.WriteLine(Name + "," + StudentID + "," + Age + "," + Year);
                            Console.WriteLine($"Thank you {Name}, your details have been saved successfully.");
                        }
                    // parameter false - overwrite files
                    using (System.IO.StreamWriter myinstance = new System.IO.StreamWriter(@Filepath2, false))
                    {
                        myinstance.WriteLine(Name + "," + StudentID + "," + Age + "," + Year);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Please enter the input in correct format");
                }
            }

            // Reading from CSV 
            Console.WriteLine("Displaying the last added record in this file");
            Console.Write(string.Join("",ReadRecord(csvfilepath2, 1)));
            static string[] ReadRecord (string filepath, int positionofsearchterm)
            {
                // positionofsearchterm not used, as only one record exists in this file
                string[] norecordfound = {"No new record has been added"};
                try
                {
                    string[] lastrecord = System.IO.File.ReadAllLines(@filepath);
                    return lastrecord;
                }
                catch (Exception ex)
                {
                    return norecordfound;  
                }

            }

        }
    }
}
