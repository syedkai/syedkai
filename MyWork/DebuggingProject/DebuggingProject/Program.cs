using System;


namespace DebuggingProject
{
    public class Person
    {
        public string fName;
        public string lName;

        public void fullName()
        {
             Console.WriteLine(  "My name is : " + fName +" " +lName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            var obj = new Person();
            obj.fName = "Mehadi";
            obj.lName = "Hasan";
            obj.fullName();


            var result= MyAlgorithm.Add(2, 4.2);
            Console.WriteLine(result);
            Console.ReadKey();
            



             
            

            
        }
    }
}
