using System;

namespace InterfaceClassProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Interface Application!");

            double[] data = new double[] { 22.8, 59.5, 30.5, 46.5, 18.1 };
            

            SumClass sum = new SumClass();
            sum.Train(data);
            var output = sum.GetResult();

            Result avg = new Result();
            avg.Train(data);
            var resoutput = avg.GetResult();

            Console.WriteLine("Output result from SumClass : ");
            Console.WriteLine(output);

            Console.WriteLine("Output from Result class");
            Console.WriteLine(resoutput);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
