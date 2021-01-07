using System;
using System.IO;


namespace HelloWorldWithInterface
{
    /// <summary>
    /// interface class
    /// </summary>
    interface IMyInterface
    {
        /// <summary>
        /// get result from trained model
        /// </summary>
        /// <returns></returns>
        double GetResult();

        /// <summary>
        /// train a model
        /// </summary>
        /// <param name="data"></param>
        void Train(double[] data)
        {

        }

        /// <summary>
        /// save a result
        /// </summary>
        public void Save(string saveFilename)
        {
            GetResult();

            string save_path = String.Concat(Directory.GetCurrentDirectory(),"/",saveFilename);

            System.IO.File.WriteAllText(save_path, GetResult().ToString());

            Console.Write($"Save result in {saveFilename} complete.");
        }

        /// <summary>
        /// load a result
        /// </summary>
        public double Load(string loadFilename)
        {
            string load_path = String.Concat(Directory.GetCurrentDirectory(),"/", loadFilename);

            var readTxt = System.IO.File.ReadAllText(load_path);
            
            Console.Write($"Load result in {loadFilename} complete.");

            return Convert.ToDouble(readTxt);
        }
    }
}
