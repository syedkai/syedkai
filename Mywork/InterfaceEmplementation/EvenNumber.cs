using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterfaceEmplementation
{
    class EvenNumber : ISeriseInterface
    {
        int[] evenserise = new int[100];
        int iterationnumber = 0;
        public (int[], int) Serise()
        {
            evenserise[0] = 0;

            for (int i = 1; i < 100; i++)
            {
                evenserise[i] = evenserise[i - 1] + 2;
            }
            iterationnumber += 1;

            return (evenserise, iterationnumber);
        }

        public void SavingOutput(int[] serise, int iteration)
        {
            using (StreamWriter sw = new StreamWriter("EvenSerise.txt", true))
            {
                sw.WriteLine(iteration);
                sw.Close();
            }

            //FileStream savedoutput = new FileStream("EvenSerise.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            //savedoutput.WriteByte((byte)iteration);
            using (StreamWriter sw = new StreamWriter("EvenSerise.txt", true))
            {
                for (int i = 0; i < serise.Length; i++)
                {
                    sw.Write(Convert.ToString(serise[i]) + ", ");
                }
                sw.Close();
            }
            //savedoutput.Close();

            //using (StreamWriter sw = new StreamWriter("EvenSerise.txt"))
            //{
            //    sw.WriteLine("");
            //}
            //savedoutput.Position = 0;
        }
    }
}
