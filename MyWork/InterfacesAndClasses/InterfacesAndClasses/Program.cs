using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;
namespace InterfacesAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            string filepath = "../../../Result.json";
            if (File.Exists(filepath))
            {
                string result = string.Empty;
                using (StreamReader r = new StreamReader(filepath))
                {
                    var json = r.ReadToEnd();
                    JObject jobj = JObject.Parse(json);
                    result = jobj.ToString();
                    Console.WriteLine("Welcome your previous values of data are {0} and sum is {1} and average is {2}",
                        jobj["data"], jobj["sum"], jobj["average"]);
                }
            }
            else
            {
                Console.WriteLine("You came for the first time there is no saved data");
            }
            Console.WriteLine("Please enter new values seperated by comma");
            try
            {
                var digits = Console.ReadLine().Split(',').Select(r => Convert.ToDouble(r.Trim())).ToArray();
                MLInterface avgAlg = new AverageAlgorithm();
                MLInterface sumAlg = new SumAlgorithm();
                avgAlg.Train(digits);
                sumAlg.Train(digits);
                //Result instance of sum class
                Console.WriteLine("The sum is {0}", sumAlg.GetResult().sum);
                //Result instance of average class
                Console.WriteLine("The average is {0}", avgAlg.GetResult().average);
                JObject videogameRatings = new JObject(
                                new JProperty("sum", sumAlg.GetResult().sum),
                                new JProperty("average", avgAlg.GetResult().average),
                                new JProperty("data", string.Join(",", digits)));
                File.WriteAllText("../../../Result.json", videogameRatings.ToString());
                Console.WriteLine("Your result is saved.");
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter proper data");
            }

        }
    }
}