using System;

namespace investigate_HPC
{
    class Program
    {
        /// <summary>
        /// Trial for HPC
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SpatialPatternLearning spExperiment = new SpatialPatternLearning();

            spExperiment.Run();

        }
    }
}
