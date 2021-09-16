using System;

namespace assignment2
{
    abstract class Laptop : IProcessor
    {
        private string serialNumber;
        public Processors Processor { get { return Processors.Intel_i5; } set { Processor = Processors.Intel_i5; } }

        public abstract void Execute(string text);

        public Laptop(string serial)
        {
            this.serialNumber = serial;
        }
    }
}
