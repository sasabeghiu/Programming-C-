
namespace assignment1
{
    public class InternationalPlayer : FootballPlayer
    {
        public int gamesPlayed;

        public InternationalPlayer(string name, int age, int gamesPlayed)
            : base(name, age)
        {
            this.gamesPlayed = gamesPlayed;
        }

        public override int CalculateTransferValue()
        {
            return base.CalculateTransferValue() + gamesPlayed / 2;
        }

        public override string ToString()
        {
            return $"{base.ToString()} ({gamesPlayed} int. games)";
        }
    }
}
