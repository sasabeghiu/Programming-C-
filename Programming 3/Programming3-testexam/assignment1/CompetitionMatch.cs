using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class CompetitionMatch : FootballMatch
    {
        public int roundNumber;

        public CompetitionMatch(FootballTeam homeTeam, FootballTeam awayTeam, int roundNumber)
            : base(homeTeam, awayTeam)
        {
            this.roundNumber = roundNumber;
        }
    }
}
