using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelProcessing.model
{
    class Result
    {
        [Name("Sequential")]
        public long Sequential { get; set; }
        
        [Name("Thread")]
        public long Thread { get; set; }

        [Name("Parallel")]
        public long Parallel { get; set; }
    }
}
