using FileManagement;
using System;

namespace publish_independent
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 C = new Class1();

            C.CreateFile();
            C.WriteFile();
            C.ReadFile();

            Console.ReadLine();
            
        }
    }
}
