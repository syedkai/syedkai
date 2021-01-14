using System;

namespace WorkingWithDebugger
{
    class Program
    {
        static void MyMethod(string name = "Sumi")
        {
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            MyMethod("Rajib");
            MyMethod("Rita");
            MyMethod();
            MyMethod("Rajia");
        }
    }
}
