using System.Collections.Generic;

namespace assignment1
{
    class FootballTeam
    {
        private string name;
        public List<FootballPlayer> Players { get; private set; }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int TotalPoints { get; set; }
        public int TotalTransferValue
        {
            get
            {
                int total = 0;
                foreach (FootballPlayer player in Players)
                {
                    total += player.CalculateTransferValue();
                }
                return total;
            }
        }
        public FootballTeam(string name)
        {
            this.name = name;
            this.Players = new List<FootballPlayer>();
            TotalPoints = 0;
        }
    }
}
