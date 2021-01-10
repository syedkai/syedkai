
using ClassLibraryN;
using System;
using System.Threading.Tasks;

namespace Hello_world_with_class
{
    class RunClassStaticSample
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World with Class!");
            await RunClassInstanceSampleAsync();
            Console.WriteLine("Press a key to exit.....");
            Console.ReadLine();
            


/////////// await NewMethod();
        }

        

        private static Task RunClassInstanceSampleAsync()
        {
            Console.WriteLine("Please, enter some text and I will calculate the Length");
            var txt = Console.ReadLine();
            var len = MyApi.GetLength(txt);
            Console.WriteLine($"The length of the text is: {len}");

             
            

            while(true)
            {
                

                Console.WriteLine("Please, enter arg 1");
                var arg1 = Console.ReadLine();

                if (arg1 == "exit")
                    break;

                Console.WriteLine("Please, enter arg 2");
                var arg2 = Console.ReadLine();

                if (arg2 == "exit")
                    break;
                try
                {
                    MyApi classInstance = new MyApi();
                    double res = classInstance.Divide(int.Parse(arg1), int.Parse(arg2));

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"THe result of {arg1}/{arg2}= {res}");


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Your Input Is Not The Best");
                    Console.WriteLine(ex);
                    
                }

                finally
                {
                    Console.ResetColor();
                }
               
                

            }
            
        }

        

       

  /*      private static async Task NewMethod()
        {
            int n = 100;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Counter {i}");
                await Task.Delay(500);
            }
        }
  */
    } 
}
















