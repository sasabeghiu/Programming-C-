using System;

namespace assignment2
{
    class MacBook : Laptop
    {
        private string serialNumber;
        public Processors Processor { get { return Processors.Intel_i5; } set { Processor = Processors.Intel_i5; } }

        public override void Execute(string text)
        {
            Console.WriteLine($"Executing program '{text}' with processor {Processor}");
        }

        public MacBook(string serial) : base(serial)
        {
            this.serialNumber = serial;
        }



    }
}
