using SampleProject;
using System;

namespace HelloWorldWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SampleClass sampleClass = new SampleClass();
            sampleClass.SampleMethod();
        }
    }
}
