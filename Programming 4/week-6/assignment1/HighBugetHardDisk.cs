using System;

namespace assignment1
{
    public class HighBugetHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing data very quickly...");
        }
    }
}
