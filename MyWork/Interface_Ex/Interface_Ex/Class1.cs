using System;
using System.Collections.Generic;
using System.Text;


    namespace InterfaceTrial2
    {

        class Program : IMyInterface1
        {
            int sum;
            int result;


            public void train(int[] data)

            {
                for (int i = 0; i < data.Length; i++)
                {
                    sum += data[i];
                }
                Console.WriteLine("The  sum is " + sum);

                if (sum > 100)

                {
                    result = 1;
                    Console.WriteLine("The sum of all the data is greater than 100 hence the result is " + result);
                }

                if (sum < 100)

                {
                    result = 0;
                    Console.WriteLine("The sum of all the data is smaller than 100 hence the result is " + result);
                }






            }
            static void Main(string[] args)
            {


                Program obj = new Program();
                obj.train(new int[] { 10, 20, 30, 50 });

                Console.ReadLine();

            }
        }
    }

