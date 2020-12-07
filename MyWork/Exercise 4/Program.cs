using System;

namespace Exercise_4
    
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Biodata biodata = new Biodata();
            biodata.Name = "Ishfaq Ahmad Jadoon";
            biodata.Age = 36;
            String Nameandage=biodata.Getnameandage();
            
            Console.WriteLine("Hello World! and " + Nameandage );
        }
    }
}
