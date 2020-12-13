using System;

namespace E8___Interfaces_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; // no of elements
            int[] inputdata = null; // user input array;
            int savechoice, loadchoice;
            Itestinterface sumclass = new Class1();
            Itestinterface avgclass = new Class2();
            Result maininstance = new Result();

            GetchoiceforLoadingResults();
            GetUserInput();
            Executeclass1andclass2();
            GetchoiceforSavingResults();
           
           
            void GetUserInput()
            {
                Console.WriteLine("Hello! Would you like to enter some numerical data and get insights?");
                Console.WriteLine("If so, then enter how many numbers you would like to work with");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the numbers");
                inputdata = new int[n];
                for (int t = 0; t < n; t++)
                {
                    inputdata[t] = int.Parse(Console.ReadLine());
                }
               
            }

            void Executeclass1andclass2()
            {
                // CLASS 1 called
                Console.WriteLine("Do you want to know if the sum is greater than 100 ?");
                Console.ReadLine();
                    sumclass.Train(inputdata);
                    sumclass.GetResult();
                    sumclass.LoadResult();

                // CLASS 2 called
                Console.WriteLine("Do you want to know the Average, Median, Variance?");
                Console.ReadLine();
                    avgclass.Train(inputdata);
                    avgclass.GetResult();
                avgclass.LoadResult();
                
            }

            void GetchoiceforSavingResults()
            {
                Console.WriteLine("Do you want to save the results before closing?\n 1.Yes \n 2.No");
                savechoice = int.Parse(Console.ReadLine());

                if (savechoice == 1)
                {
                    sumclass.SaveResult();
                    avgclass.SaveResult();  
                }
            }

           void GetchoiceforLoadingResults()
            {
                Console.WriteLine("Do you want to view the previous results?\n 1.Yes \n 2.No");
                loadchoice = int.Parse(Console.ReadLine());

                if (loadchoice == 1)
                {
                    sumclass.LoadResult();
                    avgclass.LoadResult();
                }
            }

        }
    }
}
