using System;

namespace ClassProjE4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 newCity = new Class1("Frankfurt", "Hesse", "Germany");
            Console.WriteLine(newCity.Detail());
        }
    }
}
