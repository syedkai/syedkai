using System;

namespace Compare
{
    public class CompareClass
    {
        public static int Comparer(int a, int b, string letter)
        {
            if (letter == "g")
            {
                return a > b ? a : b;
            }
            else
            {
                return a < b ? a : b;
            }
        }
    }
}
