using System;

namespace Haritha_Project___E0
{

    class Program
    {
        static void Main(string[] args)
        {
            // Testing example of Classes, Sealed classes & Polymorphism
            int choice;
            Car myCar = new Car();
            Ford myFord = new Ford();
            Benz myBenz = new Benz(); // create derived class2 object
            BMW myBMW = new BMW(); // create derived class3 object

            Console.WriteLine("Project E2 created through Visual Studio!\n Welcome to Frankfurt AutoHaus!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("...Looking for ?\n Ford - 1\n Benz - 2\n BMW - 3\n");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                myFord.Information(); // polymorphism , using method called "Information" from parent class
                myFord.Model();
            }
            if (choice == 2)
            {
                myBenz.Information(); // polymorphism , using method called "Information" from parent class
                myBenz.Model();
            }
            if (choice == 3)
            {
                myCar.Information(); // polymorphism , using method called "Information" from parent class
                myBMW.Model();
            }
        }
    }
}
