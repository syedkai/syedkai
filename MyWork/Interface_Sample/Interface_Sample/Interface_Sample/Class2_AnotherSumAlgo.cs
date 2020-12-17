using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Interface_Sample
{
    [Serializable()]
    public class Class2_AnotherSumAlgo:IMyInterface
    {
        private double m_sum;

        public double sum { get; set; }
        public Class2_AnotherSumAlgo()
        {
            this.m_sum = 5;
        }

        public object GetResult()
        {
            return this.m_sum;
        }

        public void Train(double[] data)
        {
            foreach (var num in data)
            {
                this.m_sum += num;
            }
            m_sum = m_sum / data.Length;
        }

        public void save()
        {
            var xs = new XmlSerializer(typeof(Class2_AnotherSumAlgo));

            using ( TextWriter text =  new StreamWriter(@"C:\Sweta'sDisk\FUAS_official\Lectures_notes_IT\SW_Project\SE_Repo\MyWork\Interface_Sample\Saved_result.xml") )
            {
                xs.Serialize(text, this);
            }
        }

        public void load()
        { 
            var xs = new XmlSerializer(typeof(Class2_AnotherSumAlgo));
            using ( TextReader load_res = new StreamReader(@"C:\Sweta'sDisk\FUAS_official\Lectures_notes_IT\SW_Project\SE_Repo\MyWork\Interface_Sample\Saved_result.xml"))
            {
                var tempRes = (Class2_AnotherSumAlgo)xs.Deserialize(load_res);
                m_sum = tempRes.m_sum;
                load_res.Close();

                Console.WriteLine("m_sum read value is: " + this.m_sum);
            }
        }
    }
}
