using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        void Start()
        {
            BatchProcessor batchProcessor = new BatchProcessor();

            CallDataLoader call = new CallDataLoader();
            TwitterDataLoader twitter = new TwitterDataLoader();
            SensorDataLoader sensor = new SensorDataLoader();

            batchProcessor.AddData(call);
            batchProcessor.AddData(twitter);
            batchProcessor.AddData(sensor);

            batchProcessor.ProcessData();
        }
    }
}
