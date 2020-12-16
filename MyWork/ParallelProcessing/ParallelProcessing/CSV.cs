using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ParallelProcessing
{
    class CSV<T>
    {
        private string path;

        public CSV(string path)
        {
            this.path = path;
        }

        public CSV()
        {

        }

        public void save(List<T> records)
        {
            if (path == null)
            {
                throw new NullReferenceException();
            }

            write(path, records);
        }

        public void save(string path, List<T> records)
        {
            write(path, records);
        }

        private void write(string path, List<T> records)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }
}
