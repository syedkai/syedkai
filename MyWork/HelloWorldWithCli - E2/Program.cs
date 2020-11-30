using System;
using System.Collections.Generic;
using System.Linq;

// String Array , For Loop testing
namespace myApp
{
    class Program
    {
        static void Main()
        {
            var namens = new List<string> { "Haritha", "Freya", "x", "y" };
            foreach (var namen in namens)
            {
                Console.WriteLine($"Hello {namen.ToUpper()} ");
            }
        }
    }
}
