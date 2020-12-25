using System;

namespace appnuget
{
    public class Class1
    {
        public static int Hcf(int n1, int n2)
        {
            int i = 1;
            int gcf = 1;
            while (i <= n1 & i <= n2)
            {
                if (n1 % i == 0 & n2 % i == 0)

                {
                    gcf = i;

                }
                i = i + 1;
            }
            return gcf;
        }

        public static int LCM(int n1, int n2)
        {
            int lcm = 0;
            int i = 1;
            while (n1 >= n2)
            {
                int mul = n1 * i;
                if (mul % n2 == 0)
                {
                    lcm = mul;
                    break;
                }
                i = i + 1;
            }
            while (n1 < n2)
            {
                int mul = n2 * i;
                if (mul % n1 == 0)
                {
                    lcm = mul;
                    break;
                }
                i = i + 1;
            }
            return lcm;
        }
        static void Main()
        {
            Console.WriteLine("Write the numbers2");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int gcd = Hcf(n1, n2);
            int lcm = LCM(n1, n2);
            Console.WriteLine("GCF is" + gcd);
            Console.WriteLine("LCM is" + lcm);
        }
    }
}
