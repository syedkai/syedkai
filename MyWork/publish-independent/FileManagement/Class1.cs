using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManagement
{
    public class Class1
    {

        private String FilePath = @"C:\Users\dell 5510 i.7 6th HQ\local repo\se-cloud-2020-2021\MyWork\publish-independent\FileManagement\test.txt";

        // Create a file method

        public void CreateFile()
        {
            if (File.Exists(FilePath) != true)
            {
                 File.Delete(FilePath);


                StreamWriter wf = File.CreateText(FilePath);                         // Creating a File
                string dt = DateTime.Now.ToString();
                wf.WriteLine("File Created Time:",dt);       // Line to Add Time of Creation 
              //  wf.WriteLine("\n");
                wf.Close();
            }   
        }


        public void WriteFile()
        {
            StreamWriter rf = File.AppendText(FilePath);
            Console.WriteLine("Enter the line you want to Add to file :  ");
            string line=Console.ReadLine();
            rf.WriteLine($"\n {line}");

            rf.Close();

        }


        public void ReadFile()
        {
           // string[] rf = File.ReadAllLines(FilePath);          

            List<string> lines = new List<string>();

            lines = File.ReadAllLines(FilePath).ToList();    // File.ReadAllLines(FilePath) gives a string to convert in to list we use .ToList()  

            foreach (string line in lines)
            {

                Console.WriteLine(line);
            }
        }



    }
}
