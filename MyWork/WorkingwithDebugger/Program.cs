using System;
using System.Collections.Generic;

namespace WorkingwithDebugger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>();
            strList.Add("Test");
            strList.Add("my");
            strList.Add("program");
            foreach(var str in strList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
