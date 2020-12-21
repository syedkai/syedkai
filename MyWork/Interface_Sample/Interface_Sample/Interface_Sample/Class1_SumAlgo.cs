using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Interface_Sample
{
    public class Class1_SumAlgo : IMyInterface
    {
        private double m_sum;

        public double sum { get; set; }
        public Class1_SumAlgo()
        {
            this.m_sum = 0;
        }

        public object GetResult()
        {
            return this.m_sum;
        }

        public void Train(double[] data)
        {
            foreach(var num in data)
            {
                this.m_sum += num;
            }
            if (this.m_sum > 100)
                this.m_sum = 1;
            else
                this.m_sum = 0;
        }

        public void save()
        {

            Class1_SumAlgo obj_sum = new Class1_SumAlgo();
            obj_sum.sum = this.m_sum;
            var xs = new XmlSerializer(typeof(Class1_SumAlgo));

            using (TextWriter text = new StreamWriter(@"C:\Sweta'sDisk\FUAS_official\Lectures_notes_IT\SW_Project\SE_Repo\MyWork\Interface_Sample\Saved_result.xml"))
            {

                xs.Serialize(text, obj_sum);
                text.Close();
            }

        }

        public void load()
        {
            var xs = new XmlSerializer(typeof(Class1_SumAlgo));
            using (TextReader load_res = new StreamReader(@"C:\Sweta'sDisk\FUAS_official\Lectures_notes_IT\SW_Project\SE_Repo\MyWork\Interface_Sample\Saved_result.xml"))
            {
                var tempRes = (Class1_SumAlgo)xs.Deserialize(load_res);
                m_sum = tempRes.sum;
                load_res.Close();

                Console.WriteLine("m_sum read value is: " + this.m_sum);
            }
        }
    }
}
