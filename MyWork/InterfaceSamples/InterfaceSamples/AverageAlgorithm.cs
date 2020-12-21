using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace InterfaceSamples
{
    public class AverageAlgorithm : IMyMLAlgorithm
    {
        private double m_Sum;
        public double sum { get; set; }

        public AverageAlgorithm()
        {
            this.m_Sum = 0;

        }

        public object GetResult()
        {
            return this.m_Sum;
        }

        public void Train(double[] data)
        {
            foreach (var number in data)
            {
                this.m_Sum += number;
            }

            m_Sum = m_Sum / data.Length;
        }




        public void save()
        {

            AverageAlgorithm obj_sum = new AverageAlgorithm();
            obj_sum.sum = this.m_Sum;
            var xs = new XmlSerializer(typeof(AverageAlgorithm));

            using (TextWriter text = new StreamWriter(@"result.xml"))
            {

                xs.Serialize(text, obj_sum);
                text.Close();
            }

          
        }

        public void load()
        {
            var xs = new XmlSerializer(typeof(AverageAlgorithm));
            using (TextReader load_res = new StreamReader(@"result.xml"))
            {
                var tempRes = (AverageAlgorithm)xs.Deserialize(load_res);
                m_Sum = tempRes.sum;
                load_res.Close();

                Console.WriteLine("m_sum read value is: " + this.m_Sum);
            }
        }
    }
}

