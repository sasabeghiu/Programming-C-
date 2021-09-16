using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    public class ATMMachine
    {
        private uint ammountInMachine;
        private IATMState machineState;
        private IATMState cardPresent;
        private IATMState correctPinCode;
        private IATMState noCard;
        private IATMState noCash;

        public uint AmmountInMachine
        {
            get { return ammountInMachine; }
            set { ammountInMachine = value; }
        }

        public ATMMachine(uint ammountInMachine)
        {
            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);
            noCard = new NoCardState(this);
            noCash = new NoCashState(this);

            this.ammountInMachine = ammountInMachine;

            machineState = noCard;
        }

        public void EnterPincode(int pincode)
        {
            machineState.EnterPincode(pincode);
        }

        public IATMState GetCardPresentState()
        {
            return cardPresent;
        }

        public IATMState GetCorrectPinState()
        {
            return correctPinCode;
        }

        public IATMState GetNoCardState()
        {
            return noCard;
        }

        public IATMState GetNoCashState()
        {
            return noCash;
        }

        public void InsertCard()
        {
            machineState.InsertCard();
        }

        public void RejectCard()
        {
            machineState.RejectCard();
        }

        public void SetAmountInMachine(uint ammount)
        {
            AmmountInMachine = ammount;
        }

        public void SetMachineState(IATMState atmState)
        {
            machineState = atmState;
        }

        public void WithdrawCash(uint amount)
        {
            machineState.WithdrawCash(amount);
        }
    }
}
