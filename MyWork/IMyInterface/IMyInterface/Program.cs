using System;

namespace IMyInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = new double[] { 12.4, 10.5, 16.3 };    // declaration of array

            InterfaceAlgo b = new DivideofArrays();


            Sample(b, d);                                       // Passing sum algorithm and data which is array
          

            Console.WriteLine("Press any key");
        }

        public static void Sample(InterfaceAlgo alg, double[] d)           // Interface Method
        {

            if (alg is SumofArrays)                         // if Interface algo use Sum of array implemented in SumofArrays Class
            {
                alg.SumofArray(d);

                var v = alg.getResult();

                Console.WriteLine($" Sum of Array is {v} \n");
            }
            if (alg is DivideofArrays)                      // if Interface algo use divide of array implemented in DivideOfArrays Class
            {
                alg.DivideofArraySum(d);
                var v = alg.getResult();

                Console.WriteLine($" Sum of Array Divided =  {v} \n");


                DivideofArrays q = new DivideofArrays();                    // Using another method which is not defined in the interface
                q.MulofArray(d);

                Console.WriteLine($" Multiply of Array =  {q.getResult()} \n");
            }
        }
    }
}
