using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class Computer
    {
        public IProcessor Processor { get; set; }
        public IHardDisk HardDisk { get; set; }
        public IMonitor Monitor { get; set; }

        public Computer(IProcessor processor, IHardDisk hardDisk, IMonitor monitor)
        {
            this.Processor = processor;
            this.HardDisk = hardDisk;
            this.Monitor = monitor;
        }

        public void Test()
        {
            Processor.PerformOperattion();
            HardDisk.StoreData();
            Monitor.Display();
        }
    }
}
