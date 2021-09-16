
namespace assignment2
{
    public interface IATMState
    {
        public void InsertCard();
        public void EnterPincode(int pincode);
        public void WithdrawCash(uint amount);
        public void RejectCard();
    }
}
