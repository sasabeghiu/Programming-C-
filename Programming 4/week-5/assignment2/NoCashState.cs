using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class NoCashState : IATMState
    {
        private ATMMachine machine;

        public NoCashState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Card has been inserted");
            machine.SetMachineState(machine.GetCardPresentState());
            Console.WriteLine();
        }

        public void EnterPincode(int pincode)
        {
            Console.WriteLine("Not enough cash available in machine");
            Console.WriteLine();
        }

        public void WithdrawCash(uint amount)
        {
            Console.WriteLine($"Not enough cash available in machine");
             machine.RejectCard();
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            Console.WriteLine();
        }
    }
}
