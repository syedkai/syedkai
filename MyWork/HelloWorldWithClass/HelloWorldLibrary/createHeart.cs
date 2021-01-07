using System;

namespace HelloWorldLibrary
{
    public class createHeart
    {
        public void createHeartFromNumber(int n)
        {
            int i, j;

            for (i = n / 2; i <= n; i += 2)
            {
                for (j = 1; j < n - i; j += 2)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }

            for (i = n; i >= 1; i--)
            {
                for (j = i; j < n; j++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= (i * 2) - 1; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}
