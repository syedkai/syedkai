using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexLibrary
{
    public class Indexing
    {
        public static void Ind(List<int> integers)
        {
            while (integers.Count < 20)
            {
                var previous = integers[integers.Count - 1];
                var previous2 = integers[integers.Count - 2];

                integers.Add(previous + previous2);
            }
            foreach (var item in integers)
                Console.WriteLine(item);
        }
    }
}
