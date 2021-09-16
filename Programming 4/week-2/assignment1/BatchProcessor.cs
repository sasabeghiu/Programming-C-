using System;
using System.Collections.Generic;

namespace assignment1
{
    public class BatchProcessor
    {
        private List<BigDataLoader> dataLoaders = new List<BigDataLoader>();

        public void AddData(BigDataLoader data)
        {
            dataLoaders.Add(data);
        }

        public void ProcessData()
        {
            foreach(BigDataLoader data in dataLoaders)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[ETL-proces started]");
                Console.ResetColor();
                data.ETL();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[ETL-proces finished]");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
