using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using NeoCortexApi;
using NeoCortexApi.DistributedComputeLib;
using NeoCortexApi.Encoders;
using NeoCortexApi.Entities;
using NeoCortexApi.Network;
using NeoCortexApi.Utility;

namespace investigateHPC
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
