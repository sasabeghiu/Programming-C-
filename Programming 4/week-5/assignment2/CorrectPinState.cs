using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class CorrectPinState : IATMState
    {
        private ATMMachine machine;

        public CorrectPinState(ATMMachine machine)
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
            Console.WriteLine("You have entered the pincode already");
            Console.WriteLine();
        }

        public void WithdrawCash(uint amount)
        {
            if (amount <= machine.AmmountInMachine)
            {
                machine.AmmountInMachine -= amount;
                Console.WriteLine($"{amount} withdrawn from machine");
                machine.RejectCard();
            }
            else
            {
                Console.WriteLine("Not enough cash available in machine");
                machine.SetMachineState(machine.GetNoCashState());
                machine.RejectCard();
            }
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            machine.SetMachineState(machine.GetNoCardState());
            Console.WriteLine();
        }
    }
}
