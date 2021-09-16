using System;

namespace assignment1
{
    public class LowBugetHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing data not so quickly...");
        }
    }
}
