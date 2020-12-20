using IndexLibrary;
using System.Collections.Generic;

namespace WorkingWithNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> {3, 8};
            Indexing.Ind(numbers);
        }
    }
}
