using System;
using System.IO;
using System.Text;

namespace E8
{
    public class ClassImplemention2 : IFileInterface
    {
        Stats m_Result = new Stats();
        public object GetResult()
        {
            return m_Result;
        }

        public void Train(double[] data)
        {
            double Avg;
            double Med;
            double Var;
            double sum = 0;

            foreach (double fact in data)
            {
                sum += fact;
            }

            Avg = sum / 5.0;
            Med = GetMedian(data);
            Var = GetVariance(data, Avg);

            m_Result.Avg = Avg;
            m_Result.Med = Med;
            m_Result.Var = Var;
        }
            private double GetMedian(double[] data)
            {
                int n = 5;
                Array.Sort(data);
                if (n % 2 != 0)
                {
                    return data[n / 2];
                }
                else

                return (data[(n - 1) / 2] + data[n / 2]) / 2.0;

            }

            private double GetVariance(double[] data, double mean)
            {
                double sumOfSquares = 0;
                int n = 5;
                foreach (double fact in data)
                {
                    sumOfSquares += (fact - mean) * (fact - mean);

                }

                return sumOfSquares / (n-1);
            }

            public void Load()
            {
                if (File.Exists("m_Result.txt"))
                {
                    string content = File.ReadAllText("m_Result.txt", Encoding.UTF8);
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine("\n\nNo data is saved yet!");
                }
            }

            public void Save()
            {
                File.WriteAllText("m_Result.txt", "Earlier result: Average Value: " + m_Result.Avg + ", Median: " + m_Result.Med
                        + ", Variance: " + m_Result.Var);

            }








        }

    }
    
