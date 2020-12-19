using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class LCMHCF
    {
        public static int GCD(int n1, int n2)
        {
            int gcf = 1;
            int i = 1;
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
                int mtl = n1 * i;
                if (mtl % n2 == 0)
                {
                    lcm = mtl;
                    break;
                }
                i = i + 1;
            }
            while (n1 < n2)
            {
                int mtl = n2 * i;
                if (mtl % n1 == 0)
                {
                    lcm = mtl;
                    break;
                }
                i = i + 1;
            }

            return lcm;
        }
    }
}
