using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    abstract class ChampionshipMatch : FootballMatch
    {
        public ChampionshipMatch(FootballTeam homeTeam, FootballTeam awayTeam)
            : base(homeTeam, awayTeam)
        {

        }
    }
}
