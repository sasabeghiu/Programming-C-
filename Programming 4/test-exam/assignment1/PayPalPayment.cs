using System;

namespace assignment1
{
    class PayPalPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("processing PayPal payment...");
        }
    }
}
