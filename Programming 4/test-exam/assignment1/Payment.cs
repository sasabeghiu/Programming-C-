using System;

namespace assignment1
{
    abstract class Payment
    {
        public void Execute()
        {
            EnterInformation();
            Pay();
            Confirmation();
        }

        public void EnterInformation()
        {
            Console.WriteLine("entering information...");
        }

        public abstract void Pay();

        public void Confirmation()
        {
            Console.WriteLine("sending confiramtion mail...");
        }
    }
}
