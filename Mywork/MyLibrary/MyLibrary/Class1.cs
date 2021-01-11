using System;

namespace MyLibrary
{
    public class Class1
    {
        public int[] SerieseBuilder(int a)
        {
            int[] seriese = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    seriese[i] = a;
                }
                else
                {
                    seriese[i] = seriese[i - 1] * 3;
                }
                
            }
            for (int i = 0; i < seriese.Length; i++)
            {
                Console.WriteLine(seriese[i]);
            }
            
            return seriese;
        }
    }
}
