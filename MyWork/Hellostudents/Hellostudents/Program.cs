﻿using System;
using System.Threading;

namespace Hellostudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 100;

            MyAlgorithm alg = new MyAlgorithm();

            for (int i = 0; i < n; i++)
            {
                double result = alg.Calculate(i);
                Console.WriteLine($"Hello students from Windows! Iteration :{i} generate the result ={result}");
                Thread.Sleep(500);
            }
            Console.WriteLine("Press any key do exit from ...");

            Console.ReadLine();
               }

    }
}