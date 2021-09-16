using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class CardPresentState : IATMState
    {
        private ATMMachine machine;

        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void InsertCard()
        {
            Console.WriteLine("A card has been inserted already");
            Console.WriteLine();
        }

        public void EnterPincode(int pincode)
        {
            Console.WriteLine("You have entered the correct pincode");
            machine.SetMachineState(machine.GetCorrectPinState());
            Console.WriteLine();
        }

        public void WithdrawCash(uint amount)
        {
            Console.WriteLine("Please enter your pincode first");
            Console.WriteLine();
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            machine.SetMachineState(machine.GetNoCardState());
            Console.WriteLine();
        }
    }
}
