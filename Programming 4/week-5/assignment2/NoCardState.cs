using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class NoCardState : IATMState
    {
        private ATMMachine machine;

        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void InsertCard()
        {
            machine.SetMachineState(machine.GetCardPresentState());
            Console.WriteLine("Card has been inserted");
            Console.WriteLine();
        }

        public void EnterPincode(int pincode)
        {
            Console.WriteLine("Please insert a card first");
            Console.WriteLine();
        }

        public void WithdrawCash(uint amount)
        {
            Console.WriteLine("Please insert a card  first");
            Console.WriteLine();
        }

        public void RejectCard()
        {
            Console.WriteLine("Please insert a card first");
            Console.WriteLine();
        }
    }
}
