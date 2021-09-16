using System;

namespace assignment2
{
    class HPLaptop : Laptop
    {
        private string serialNumber;
        public Processors Processor { get { return Processors.AMD_Ryzen_3; } set { Processor = Processors.AMD_Ryzen_3; } }

        public override void Execute(string text)
        {
            Console.WriteLine($"Executing program '{text}' with processor {Processor}");
        }

        public HPLaptop(string serial) : base(serial)
        {
            this.serialNumber = serial;
        }


    }
}
