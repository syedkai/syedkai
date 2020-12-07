using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            biodata biodata = new biodata();

            biodata.Name = "Ishfaq Ahmad Jadoon";
            biodata.Age = 25;

            biodata.greeting();

        }
    }
}
