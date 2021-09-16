using System;

namespace assignment1
{
    class PinPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("processing PIN payment...");
        }
    }
}
