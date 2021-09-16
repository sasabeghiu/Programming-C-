using System;

namespace assignment1
{
    class CreditCardPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("processing CreditCard payment...");
        }
    }
}
